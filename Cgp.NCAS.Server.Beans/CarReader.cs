using System;
using System.Collections.Generic;
using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    [LwSerialize(339)]
    [LwSerializeMode(LwSerializationMode.Selective, DirectMemberType.All)]
    [LwSerializeNoParent]
    public class CarReader :
        AOrmObjectWithVersion,
        IGetDcu,
        ICardReaderObject
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
        public const string COLUMN_CAR_READER_ALARM_ARCS = "CarReaderAlarmArcs";
        public const string ColumnVersion = "Version";
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
        public virtual string Description { get; set; }

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

        public virtual IEnumerable<ICardReaderObject> GetChildObjects()
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

            return result;
        }

        public CarReader()
        {
            ObjectType = (byte)Cgp.Globals.ObjectType.CardReader;
            CkUnique = Guid.NewGuid();
            EnableParentInFullName = Support.EnableParentInFullName;
        }
    }
}
