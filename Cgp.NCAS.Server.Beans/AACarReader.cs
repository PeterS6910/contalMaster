using System;

using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    [LwSerialize(340)]
    [LwSerializeMode(LwSerializationMode.Selective, DirectMemberType.All)]
    [LwSerializeNoParent]
    public class AACarReader : AOrmObjectWithVersion
    {
        public const string COLUMNIDAACARREADER = "IdAACarReader";
        public const string COLUMNALARMAREA = "AlarmArea";
        public const string COLUMNGUIDALARMAREA = "GuidAlarmArea";
        public const string COLUMNCARREADER = "CarReader";
        public const string COLUMNGUIDCARREADER = "GuidCarReader";
        public const string COLUMNAASET = "AASet";
        public const string COLUMNAAUNSET = "AAUnset";
        public const string COLUMNAAUNCONDITIONALSET = "AAUnconditionalSet";
        public const string COLUMNPERMANENTLYUNLOCK = "PermanentlyUnlock";
        public const string COLUMNENABLEEVENTLOG = "EnableEventlog";
        public const string ColumnVersion = "Version";

        [LwSerialize]
        public virtual Guid IdAACarReader { get; set; }
        public virtual AlarmArea AlarmArea { get; set; }
        private Guid _guidAlarmArea = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidAlarmArea { get { return _guidAlarmArea; } set { _guidAlarmArea = value; } }
        public virtual CarReader CarReader { get; set; }
        private Guid _guidCarReader = Guid.Empty;
        [LwSerialize]
        public virtual Guid GuidCarReader { get { return _guidCarReader; } set { _guidCarReader = value; } }
        [LwSerialize]
        public virtual bool AASet { get; set; }
        [LwSerialize]
        public virtual bool AAUnset { get; set; }
        [LwSerialize]
        public virtual bool AAUnconditionalSet { get; set; }
        [LwSerialize]
        public virtual bool PermanentlyUnlock { get; set; }
        [LwSerialize]
        public virtual bool EnableEventlog { get; set; }

        public override bool Compare(object obj)
        {
            var aaCarReader = obj as AACarReader;

            return aaCarReader != null && aaCarReader.IdAACarReader == IdAACarReader;
        }

        public virtual void PrepareToSend()
        {
            GuidAlarmArea = AlarmArea != null ? AlarmArea.IdAlarmArea : Guid.Empty;

            GuidCarReader = CarReader != null ? CarReader.IdCarReader : Guid.Empty;
        }

        public override string GetIdString()
        {
            return IdAACarReader.ToString();
        }

        public override object GetId()
        {
            return IdAACarReader;
        }

        public override IModifyObject CreateModifyObject()
        {
            return null;
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.CarReader;
        }
    }
}
