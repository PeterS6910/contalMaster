using Contal.Cgp.Globals;
using Contal.Cgp.NCAS.Server.DB;
using Contal.Cgp.Server;
using Contal.Cgp.Server.Beans.Extern;
using Contal.Cgp.Server.DB;
using Contal.IwQuick.CrossPlatform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

// SB
namespace Contal.Cgp.NCAS.Server.Notifications
{
    /// <summary>
    /// AccessPermintedNotification
    /// </summary>
    public class AccessPermintedNotification
    {
        public AccessPermintedNotification(DateTime time, string userName, string cardNumber, string readerName, string eventType)
        {
            this.Time = time;
            this.UserName = userName;
            this.CardNumber = cardNumber;
            this.ReaderName = readerName;
            this.EventType = eventType;
        }

        public DateTime Time { get; private set; }

        public string UserName { get; private set; }

        public string CardNumber { get; private set; }

        public string ReaderName { get; private set; }

        public string EventType { get; private set; }
    }

    public static class EventlogParametersHelper
    {
        public static Guid GetTypeGuid(this IEnumerable<EventlogParameter> eventlogParameters, byte typeObjectType)
        {
            return eventlogParameters
                .Where(eventlogParameter => eventlogParameter.TypeObjectType == typeObjectType)
                .Select(eventlogParameter => eventlogParameter.TypeGuid)
                .FirstOrDefault();
        }

        public static string GetTypeValue(this IEnumerable<EventlogParameter> eventlogParameters, string typeName)
        { 
            return eventlogParameters
                .Where(eventlogParameter => eventlogParameter.Type == typeName)
                .Select(eventlogParameter => eventlogParameter.Value)
                .FirstOrDefault();
        }
    }

    /// <summary>
    /// EmailNotificationService
    /// </summary>
    public sealed class EmailNotificationService
    {
        private class NotificationsBatchExecutor : IBatchExecutor<AccessPermintedNotification>
        {
            private readonly EmailNotificationService _emailNotificationService;

            public NotificationsBatchExecutor(EmailNotificationService emailNotificationService)
            {
                _emailNotificationService = emailNotificationService;
            }

            public int Execute(ICollection<AccessPermintedNotification> requests)
            {
                try
                {
                    using (var smtpClient = new SmtpClient(_emailNotificationService.generalOptions.SmtpServer))
                    using (var mail = _emailNotificationService.ToMailMessage(requests))
                    {
                        smtpClient.Port = _emailNotificationService.generalOptions.SmtpPort;
                        smtpClient.EnableSsl = _emailNotificationService.generalOptions.SmtpSsl;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                        var useDefaultCredentials = string.IsNullOrEmpty(_emailNotificationService.generalOptions.SmtpCredentials);

                        smtpClient.UseDefaultCredentials = useDefaultCredentials;

                        if (!useDefaultCredentials)
                        {
                            string[] credentials = _emailNotificationService.generalOptions.SmtpCredentials.Split('|');

                            smtpClient.Credentials = new NetworkCredential(credentials[0], credentials[1]);
                        }

                        smtpClient.Send(mail);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }

                return requests.Count;
            }
        }

        private readonly BatchWorker<AccessPermintedNotification> batchWorker;
        private GeneralOptions generalOptions;

        public EmailNotificationService() 
        {
            batchWorker = new BatchWorker<AccessPermintedNotification>(
                new NotificationsBatchExecutor(this),
                60000 /* 1 minute timeout */);

            EventlogInsertQueue.Singleton.OnInsertEventlogSucceded += OnInsertEventlogSucceded;
        }

        public void Initialize(GeneralOptions generalOptions)
        {
            this.generalOptions = generalOptions;
        }

        private bool IsServiceEnabled
        {
            get { return generalOptions.IsSetSMTP() && !string.IsNullOrEmpty(generalOptions.EventlogReportsEmails); }
        }

        private bool GetIsPersonWatched(string cardNumber)
        {
            return PersonAttributes.Singleton.GetIsPersonWatched(cardNumber);
        }

        private static AccessPermintedNotification ToAccessPermintedNotification(EventlogInsertItem eventlogInsertItem)
        {            
            var eventlog = eventlogInsertItem.Eventlog;
            var eventlogParameters = eventlogInsertItem.EventlogParameters;

            var idCardReader = eventlogParameters.GetTypeGuid((byte)ObjectType.CardReader); 
            var cardReader = idCardReader == Guid.Empty ? null : CardReaders.Singleton.GetById(idCardReader);

            if (cardReader == null)
            {
                return null;
            }

            var userName = eventlogParameters.GetTypeValue("User name");
            var cardNumber = eventlogParameters.GetTypeValue("Card number");

            if (string.IsNullOrEmpty(cardNumber) && string.IsNullOrEmpty(userName))
            {
                Debug.Assert(!string.IsNullOrEmpty(cardNumber) && !string.IsNullOrEmpty(userName));
                return null;
            }

            return new AccessPermintedNotification(eventlog.EventlogDateTime, userName, cardNumber, cardReader.Name, eventlog.Type);
        }
        
        private void OnInsertEventlogSucceded(EventlogInsertItem eventlogInsertItem)
        {
            if (IsServiceEnabled && 
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIED) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDCARDBLOCKEDORINACTIVE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPE_ACCESS_DENIED_ENTER_TO_AA_MENU_INVALID_CODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPE_ACCESS_DENIED_ENTER_TO_AA_MENU_INVALID_PIN) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPE_ACCESS_DENIED_ENTER_TO_EVENTLOGS_MENU_INVALID_CODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPE_ACCESS_DENIED_ENTER_TO_EVENTLOGS_MENU_INVALID_PIN) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPE_ACCESS_DENIED_ENTER_TO_SENSORS_MENU_INVALID_CODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPE_ACCESS_DENIED_ENTER_TO_SENSORS_MENU_INVALID_PIN) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDINVALIDCODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDINVALIDEMERGENCYCODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDINVALIDPIN) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDSETALARMAREAINVALIDCODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDSETALARMAREAINVALIDPIN) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDSETALARMAREANORIGHTS) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEUNKNOWNCARD) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDUNSETALARMAREAINVALIDCODE) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDUNSETALARMAREAINVALIDPIN) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEACCESSDENIEDUNSETALARMAREANORIGHTS) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEDSMACCESSINTERRUPTED) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEDSMACCESSPERMITTED) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEDSMACCESSRESTRICTED) ||
                (eventlogInsertItem.Eventlog.Type == Eventlog.TYPEDSMNORMALACCESS) )
            {
                var accessPermintedNotification = ToAccessPermintedNotification(eventlogInsertItem);

                if (accessPermintedNotification != null && GetIsPersonWatched(accessPermintedNotification.CardNumber))
                {
                    batchWorker.Add(accessPermintedNotification);
                }
            }
        }

        private MailMessage ToMailMessage(IEnumerable<AccessPermintedNotification> notifications)
        {
            var text = new StringBuilder();

            foreach (var accessPermintedNotification in notifications)
            {
                text.AppendLine($"{accessPermintedNotification.Time} - {accessPermintedNotification.EventType}\n {accessPermintedNotification.ReaderName}, {accessPermintedNotification.UserName} ({accessPermintedNotification.CardNumber})");
            }

            var mail = new MailMessage();

            mail.From = new MailAddress(generalOptions.SmtpSourceEmailAddress);
            mail.To.Add(generalOptions.EventlogReportsEmails);

            mail.Subject = "Contal Nova Notification Report";
            mail.Body = text.ToString();
            
            return mail;
        }
    }
}