using System;
using System.Collections.Generic;
using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    [LwSerialize(338)]
    public enum CarReaderType : byte
    {
        [Name("Unknown")]
        Unknown = 0,
        [Name("IPCamera")]
        IPCamera = 1,
        [Name("ANPRCamera")]
        ANPRCamera = 2,
        [Name("Dahua")]
        Dahua = 3,
        [Name("Axis")]
        Axis = 4
    }

    [Serializable]
    [LwSerialize(339)]
    [LwSerializeMode(LwSerializationMode.Selective, DirectMemberType.All)]
    [LwSerializeNoParent]
    public class CarReader :
        AOrmObjectWithVersion,
        IGetDcu,
        ICarReaderObject
    {
        public const string COLUMN_ID_CAR_READER = "IdCarReader";
        public const string COLUMN_NAME = "Name";
        public const string COLUMN_CAMERA_TYPE = "CameraType";
        public const string COLUMN_DCU = "DCU";
        public const string COLUMN_GUID_DCU = "GuidDCU";
        public const string COLUMN_CCU = "CCU";
        public const string COLUMN_GUID_CCU = "GuidCCU";
        public const string COLUMN_IP_ADDRESS = "IpAddress";
        public const string COLUMN_PORT = "Port";
        public const string COLUMN_DESCRIPTION = "Description";
        public const string COLUMNAACARREADERS = "AACarReaders";
        public const string COLUMN_CAR_READER_ALARM_ARCS = "CarReaderAlarmArcs";
        public const string ColumnVersion = "Version";
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
        public const string COLUMNOBJECTTYPE = "ObjectType";
        public const string COLUMNCKUNIQUE = "CkUnique";
        public const string COLUMNENABLEPARENTINFULLNAME = "EnableParentInFullName";

        [LwSerialize]
        public virtual Guid IdCarReader { get; set; }
        public virtual string Name { get; set; }
        [LwSerialize]
        public virtual CarReaderType CameraType { get; set; }

        public virtual DCU DCU { get; set; }
        private Guid _guidDCU = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidDCU { get { return _guidDCU; } set { _guidDCU = value; } }

        public virtual CCU CCU { get; set; }
        private Guid _guidCCU = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidCCU { get { return _guidCCU; } set { _guidCCU = value; } }
        [LwSerialize]
        public virtual string IpAddress { get; set; }
        [LwSerialize]
        public virtual int Port { get; set; }
        [LwSerialize]
        public virtual string Description { get; set; }
        [LwSerialize]
        public virtual ICollection<AACarReader> AACarReaders { get; set; }
        [LwSerialize]
        public virtual string UniqueKey { get; set; }
        [LwSerialize]
        public virtual string InterfaceSource { get; set; }
        [LwSerialize]
        public virtual int PortSsl { get; set; }
        [LwSerialize]
        public virtual string Equipment { get; set; }
        [LwSerialize]
        public override int Version { get; set; }
        [LwSerialize]
        public virtual bool Locked { get; set; }
        [LwSerialize]
        public virtual string LockingClientIp { get; set; }
        [LwSerialize]
        public virtual string MacAddress { get; set; }
        [LwSerialize]
        public virtual string Serial { get; set; }
        [LwSerialize]
        public virtual string Model { get; set; }
        [LwSerialize]
        public virtual string Type { get; set; }
        [LwSerialize]
        public virtual string Build { get; set; }
        public virtual ICollection<CarReaderAlarmArc> CarReaderAlarmArcs { get; set; }
        public virtual byte ObjectType { get; set; }
        public virtual Guid CkUnique { get; set; }
        public virtual bool EnableParentInFullName { get; set; }
        public override bool Compare(object obj)
        {
            var carReader = obj as CarReader;
            return carReader != null && carReader.IdCarReader.Equals(IdCarReader);
        }

        public override string GetIdString()
        {
            return IdCarReader.ToString();
        }

        public override ObjectType GetObjectType()
        {
            return Cgp.Globals.ObjectType.CarReader;
        }

        public override object GetId()
        {
            return IdCarReader;
        }

        public override IModifyObject CreateModifyObject()
        {
            return null;
        }

        public virtual IEnumerable<ICarReaderObject> GetChildObjects()
        {
            yield break;
        }

        public virtual DCU GetDcu()
        {
            return DCU;
        }

        public override string ToString()
        {
            var result = string.Empty;
            if (EnableParentInFullName)
            {
                if (CCU != null)
                {
                    result += CCU + StringConstants.SLASHWITHSPACES;
                }
                else if (DCU != null)
                {
                    result += DCU + StringConstants.SLASHWITHSPACES;
                }
            }

            result += Name;

            if (!string.IsNullOrEmpty(UniqueKey))
            {
                result += $" ({UniqueKey})";
            }

            return result;
        }

        public CarReader()
        {
            ObjectType = (byte)Cgp.Globals.ObjectType.CarReader;
            CkUnique = Guid.NewGuid();
            EnableParentInFullName = Support.EnableParentInFullName;
            UniqueKey = Guid.NewGuid().ToString();
        }
    }
}
