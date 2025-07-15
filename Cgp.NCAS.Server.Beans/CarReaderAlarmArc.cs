using System;
using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    public class CarReaderAlarmArc :
        AOrmObject,
        IAlarmArcForAlarmType
    {
        public const string COLUMN_ID_CAR_READER_ALARM_ARC = "IdCarReaderAlarmArc";
        public const string COLUMN_CAR_READER = "CarReader";
        public const string COLUMN_ALARM_TYPE = "AlarmType";
        public const string COLUMN_ALARM_ARC = "AlarmArc";
        public const string COLUMN_ID_ALARM_ARC = "IdAlarmArc";

        public virtual Guid IdCarReaderAlarmArc { get; set; }
        public virtual CarReader CarReader { get; set; }
        public virtual byte AlarmType { get; set; }
        public virtual AlarmArc AlarmArc { get; set; }

        public virtual Guid IdAlarmArc
        {
            get { return AlarmArc != null ? AlarmArc.IdAlarmArc : Guid.Empty; }
        }

        public CarReaderAlarmArc()
        {
        }

        public CarReaderAlarmArc(CarReader carReader, AlarmArc alarmArc, AlarmType alarmType)
        {
            CarReader = carReader;
            AlarmArc = alarmArc;
            AlarmType = (byte)alarmType;
        }

        public override bool Compare(object obj)
        {
            var carReaderAlarmArc = obj as CarReaderAlarmArc;
            if (carReaderAlarmArc == null)
                return false;
            return carReaderAlarmArc.IdCarReaderAlarmArc.Equals(IdCarReaderAlarmArc);
        }

        public override string GetIdString()
        {
            return IdCarReaderAlarmArc.ToString();
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.CardReaderAlarmArc;
        }

        public override object GetId()
        {
            return IdCarReaderAlarmArc;
        }

        public override IModifyObject CreateModifyObject()
        {
            return null;
        }
    }
}
