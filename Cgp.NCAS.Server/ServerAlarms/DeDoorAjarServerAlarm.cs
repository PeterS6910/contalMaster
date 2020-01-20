using System;
using System.Collections.Generic;
using System.Linq;

using Contal.Cgp.Globals;
using Contal.Cgp.Globals.PlatformPC;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.NCAS.Server.DB;
using Contal.Cgp.Server.Alarms;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.ServerAlarms
{
    [LwSerialize(818)]
    public class DeDoorAjarServerAlarm : ServerAlarm
    {
        private DeDoorAjarServerAlarm()
        {
            
        }

        public DeDoorAjarServerAlarm(
            CCU ccu,
            DoorEnvironment doorEnvironment,
            Alarm alarm)
            : base(
                new ServerAlarmCore(
                    ccu.IdCCU,
                    alarm,
                    new LinkedList<IdAndObjectType>(
                        GetParentObjects(
                            ccu.IdCCU,
                            doorEnvironment)),
                    GetName(doorEnvironment),
                    ccu.Name,
                    string.Format(
                        "Door environment '{0}' is in door ajar",
                        doorEnvironment.DCU != null
                            ? doorEnvironment.DCU.Name
                            : doorEnvironment.Name)))
        {

        }

        public static string GetName(DoorEnvironment doorEnvironment)
        {
            return string.Format(
                "{0} : {1}",
                AlarmType.DoorEnvironment_DoorAjar,
                doorEnvironment.DCU != null
                    ? doorEnvironment.DCU.Name
                    : doorEnvironment.Name);
        }

        private static IEnumerable<IdAndObjectType> GetParentObjects(
            Guid idCcu,
            DoorEnvironment doorEnvironment)
        {
            var parentObjects = Enumerable.Repeat(
                new IdAndObjectType(
                    idCcu,
                    ObjectType.CCU),
                1);

            if (doorEnvironment.DCU != null)
            {
                parentObjects = parentObjects.Concat(
                    Enumerable.Repeat(
                        new IdAndObjectType(
                            doorEnvironment.DCU.IdDCU,
                            ObjectType.DCU),
                        1));
            }

            return parentObjects;
        }

        public static IEnumerable<IdAndObjectType> GetRelatedObjects(
            Guid idCcu,
            DoorEnvironment doorEnvironment)
        {
            var relatedObjects = GetParentObjects(
                idCcu,
                doorEnvironment);

            relatedObjects = relatedObjects.Concat(
                Enumerable.Repeat(
                    new IdAndObjectType(
                        doorEnvironment.IdDoorEnvironment,
                        ObjectType.DoorEnvironment),
                    1));

            return relatedObjects;
        }

        public override PresentationGroup GetPresentationGroup()
        {
            var doorEnvironment = DoorEnvironments.Singleton.GetById(ServerAlarmCore.Alarm.AlarmKey.AlarmObject.Id);

            return doorEnvironment != null && doorEnvironment.DoorAjarPresentationGroup != null
                ? doorEnvironment.DoorAjarPresentationGroup
                : DevicesAlarmSettings.Singleton.AlarmDeDoorAjarPresentationGroup();
        }
    }
}
