using System;
using System.Drawing;
using Contal.Cgp.Globals;

namespace Contal.Cgp.NCAS.Server.Beans.Shorts
{
    [Serializable]
    public class CarReaderShort : IShortObject
    {
        public const string COLUMN_ID_CAR_READER = "IdCarReader";
        public const string COLUMN_NAME = "Name";
        public const string COLUMN_IP_ADDRESS = "IpAddress";
        public const string COLUMN_PORT = "Port";
        public const string COLUMN_DESCRIPTION = "Description";
        public const string COLUMN_SYMBOL = "Symbol";
        public const string COLUMN_UNIQUE_KEY = "UniqueKey";
        public const string COLUMN_INTERFACE_SOURCE = "InterfaceSource";
        public const string COLUMN_PORT_SSL = "PortSsl";
        public const string COLUMN_EQUIPMENT = "Equipment";
        public const string COLUMN_LOCKED = "Locked";
        public const string COLUMN_LOCKING_CLIENT_IP = "LockingClientIp";
        public const string COLUMN_MAC_ADDRESS = "MacAddress";
        public const string COLUMN_SERIAL = "Serial";
        public const string COLUMN_MODEL = "Model";
        public const string COLUMN_TYPE = "Type";
        public const string COLUMN_BUILD = "Build";

        public Guid IdCarReader { get; private set; }
        public string Name { get; private set; }
        public string IpAddress { get; private set; }
        public string Port { get; private set; }
        public string Description { get; private set; }
        public Image Symbol { get; set; }
        public string UniqueKey { get; private set; }
        public string InterfaceSource { get; private set; }
        public string PortSsl { get; private set; }
        public string Equipment { get; private set; }
        public bool Locked { get; private set; }
        public string LockingClientIp { get; private set; }
        public string MacAddress { get; private set; }
        public string Serial { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public string Build { get; private set; }

        public CarReaderShort(CarReader cr)
        {
            IdCarReader = cr.IdCarReader;
            Name = cr.ToString();
            IpAddress = cr.IpAddress;
            Port = cr.Port;
            Description = cr.Description;
            UniqueKey = cr.UniqueKey;
            InterfaceSource = cr.InterfaceSource;
            PortSsl = cr.PortSsl;
            Equipment = cr.Equipment;
            Locked = cr.Locked;
            LockingClientIp = cr.LockingClientIp;
            MacAddress = cr.MacAddress;
            Serial = cr.Serial;
            Model = cr.Model;
            Type = cr.Type;
            Build = cr.Build;
        }

        public override string ToString()
        {
            return Name;
        }

        #region IShortObject Members

        public ObjectType ObjectType { get { return ObjectType.CarReader; } }

        public string GetSubTypeImageString(object value)
        {
            return string.Empty;
        }

        public object Id { get { return IdCarReader; } }

        #endregion
    }
}
