using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick;
using Contal.IwQuick.Data;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    [LwSerialize(348)]
    [LwSerializeMode(LwSerializationMode.Selective, DirectMemberType.All)]
    [LwSerializeNoParent]
    public class CarsReader :
        AOrmObjectWithVersion,
        IOrmObjectWithAlarmInstructions,
        IEquatable<CarsReader>,
        IGetDcu,
        ICardReaderObject
    {
        public const string COLUMN_ID_CARS_READER = "IdCameraReader";
        public const string COLUMN_NAME = "Name";
        public const string COLUMN_DCU = "DCU";
        public const string COLUMN_CCU = "CCU";
        public const string COLUMN_GUID_DCU = "GuidDCU";
        public const string COLUMN_GUID_CCU = "GuidCCU";
        public const string COLUMN_PORT = "Port";
        public const string COLUMN_ADDRESS = "Address";
        public const string COLUMN_ALARM_OFFLINE = "AlarmOffline";
        public const string COLUMN_BLOCK_ALARM_OFFLINE = "BlockAlarmOffline";
        public const string COLUMN_OBJ_BLOCK_ALARM_OFFLINE_OBJECT_TYPE = "ObjBlockAlarmOfflineObjectType";
        public const string COLUMN_OBJ_BLOCK_ALARM_OFFLINE_ID = "ObjBlockAlarmOfflineId";
        public const string COLUMN_ALARM_TAMPER = "AlarmTamper";
        public const string COLUMN_BLOCK_ALARM_TAMPER = "BlockAlarmTamper";
        public const string COLUMN_OBJ_BLOCK_ALARM_TAMPER_OBJECT_TYPE = "ObjBlockAlarmTamperObjectType";
        public const string COLUMN_OBJ_BLOCK_ALARM_TAMPER_ID = "ObjBlockAlarmTamperId";
        public const string COLUMN_EVENTLOG_DURING_BLOCK_ALARM_TAMPER = "EventlogDuringBlockAlarmTamper";
        public const string COLUMN_CK_UNIQUE = "CkUnique";
        public const string COLUMN_ENABLE_PARENT_IN_FULL_NAME = "EnableParentInFullName";
        public const string COLUMN_QUERY_DB_STAMP = "QueryDbStamp";
        public const string COLUMN_SPECIAL_OUTPUT_FOR_TAMPER = "SpecialOutputForTamper";
        public const string COLUMN_GUID_SPECIAL_OUTPUT_FOR_TAMPER = "GuidSpecialOutputForTamper";
        public const string COLUMN_SPECIAL_OUTPUT_FOR_OFFLINE = "SpecialOutputForOffline";
        public const string COLUMN_GUID_SPECIAL_OUTPUT_FOR_OFFLINE = "GuidSpecialOutputForOffline";
        public const string COLUMN_LOCAL_ALARM_INSTRUCTION = "LocalAlarmInstruction";
        public const string COLUMN_DESCRIPTION = "Description";
        public const string COLUMN_VERSION = "Version";

        [LwSerialize]
        public virtual Guid IdCarsReader { get; set; }
        public virtual string Name { get; set; }
        public virtual DCU DCU { get; set; }
        private Guid _guidDCU = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidDCU { get { return _guidDCU; } set { _guidDCU = value; } }
        public virtual CCU CCU { get; set; }
        private Guid _guidCCU = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidCCU { get { return _guidCCU; } set { _guidCCU = value; } }
        [LwSerialize]
        public virtual string Port { get; set; }
        [LwSerialize]
        public virtual byte Address { get; set; }

        [LwSerialize]
        public virtual bool? AlarmOffline { get; set; }
        [LwSerialize]
        public virtual bool? BlockAlarmOffline { get; set; }
        [LwSerialize]
        public virtual byte? ObjBlockAlarmOfflineObjectType { get; set; }
        [LwSerialize]
        public virtual Guid? ObjBlockAlarmOfflineId { get; set; }

        [LwSerialize]
        public virtual bool? AlarmTamper { get; set; }
        [LwSerialize]
        public virtual bool? BlockAlarmTamper { get; set; }
        [LwSerialize]
        public virtual byte? ObjBlockAlarmTamperObjectType { get; set; }
        [LwSerialize]
        public virtual Guid? ObjBlockAlarmTamperId { get; set; }
        [LwSerialize]
        public virtual bool? EventlogDuringBlockAlarmTamper { get; set; }

        public virtual Guid CkUnique { get; set; }
        public virtual bool EnableParentInFullName { get; set; }
        [LwSerialize]
        public virtual byte? QueryDbStamp { get; set; }
        public virtual Output SpecialOutputForTamper { get; set; }
        private Guid _guidSpecialOutputForTamper = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidSpecialOutputForTamper { get { return _guidSpecialOutputForTamper; } set { _guidSpecialOutputForTamper = value; } }
        public virtual Output SpecialOutputForOffline { get; set; }
        private Guid _guidSpecialOutputForOffline = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidSpecialOutputForOffline { get { return _guidSpecialOutputForOffline; } set { _guidSpecialOutputForOffline = value; } }
        public virtual string LocalAlarmInstruction { get; set; }
        public virtual string Description { get; set; }

        public CarsReader()
        {
            CkUnique = Guid.NewGuid();
            EnableParentInFullName = Support.EnableParentInFullName;
            Port = string.Empty;
        }

        public override bool Compare(object obj)
        {
            var carsReader = obj as CarsReader;
            return carsReader != null && carsReader.IdCarsReader == IdCarsReader;
        }

        public bool Equals(CarsReader other)
        {
            if (ReferenceEquals(this, other))
                return true;
            return other != null && !IdCarsReader.Equals(Guid.Empty) && IdCarsReader.Equals(other.IdCarsReader);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CarsReader);
        }

        public override string ToString()
        {
            var result = string.Empty;
            if (EnableParentInFullName)
            {
                if (CCU != null)
                    result += CCU + StringConstants.SLASHWITHSPACES;
                else if (DCU != null)
                    result += DCU + StringConstants.SLASHWITHSPACES;
            }
            result += Name;
            return result;
        }

        public virtual void PrepareToSend()
        {
            GuidCCU = CCU != null ? CCU.IdCCU : Guid.Empty;
            GuidDCU = DCU != null ? DCU.IdDCU : Guid.Empty;
            GuidSpecialOutputForOffline = SpecialOutputForOffline != null ? SpecialOutputForOffline.IdOutput : Guid.Empty;
            GuidSpecialOutputForTamper = SpecialOutputForTamper != null ? SpecialOutputForTamper.IdOutput : Guid.Empty;
        }

        public override string GetIdString()
        {
            return IdCarsReader.ToString();
        }

        public override object GetId()
        {
            return IdCarsReader;
        }

        public override IModifyObject CreateModifyObject()
        {
            return new CarsReaderModifyObj(this);
        }

        public virtual IEnumerable<ICardReaderObject> GetChildObjects()
        {
            yield break;
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.NotSupport;
        }

        public virtual string GetLocalAlarmInstruction()
        {
            return LocalAlarmInstruction;
        }

        public virtual DCU GetDcu()
        {
            return DCU;
        }
    }

    [Serializable]
    public class CarsReaderShort : IShortObject
    {
        public const string COLUMN_ID_CARS_READER = "IdCarsReader";
        public const string COLUMN_FULL_NAME = "FullName";
        public const string COLUMN_NAME = "Name";
        public const string COLUMN_DESCRIPTION = "Description";

        public Guid IdCarsReader { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public CarsReaderShort(CarsReader carsReader)
        {
            IdCarsReader = carsReader.IdCarsReader;
            Name = carsReader.Name;
            FullName = carsReader.ToString();
            Description = carsReader.Description;
        }

        public ObjectType ObjectType { get { return ObjectType.NotSupport; } }
        public string GetSubTypeImageString(object value)
        {
            return string.Empty;
        }
        public object Id { get { return IdCarsReader; } }
    }

    [Serializable]
    public class CarsReaderModifyObj : AModifyObject
    {
        public override ObjectType GetOrmObjectType { get { return ObjectType.NotSupport; } }

        public CarsReaderModifyObj(CarsReader cameraReader)
        {
            Id = cameraReader.IdCarsReader;
            FullName = cameraReader.ToString();
            Description = cameraReader.Description;
        }
    }
}
