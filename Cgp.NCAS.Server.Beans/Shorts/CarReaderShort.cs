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

        public Guid IdCarReader { get; private set; }
        public string Name { get; private set; }
        public string IpAddress { get; private set; }
        public int Port { get; private set; }
        public string Description { get; private set; }
        public Image Symbol { get; set; }

        public CarReaderShort(CarReader cr)
        {
            IdCarReader = cr.IdCarReader;
            Name = cr.ToString();
            IpAddress = cr.IpAddress;
            Port = cr.Port;
            Description = cr.Description;
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
