using System;
using System.Collections.Generic;
using System.Linq;

using Contal.Cgp.NCAS.RemotingCommon;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.Server.Beans;
using Contal.Cgp.Server.DB;

namespace Contal.Cgp.NCAS.Server.DB
{
    public sealed class AACarReaders :
        ANcasBaseOrmTable<AACarReaders, AACarReader>,
        IAACarReaders
    {
        private AACarReaders()
            : base(
                  null,
                  new CudPreparationForObjectWithVersion<AACarReader>())
        {
        }

        public override bool HasAccessView(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccessesForGroup(AccessNcasGroups.CAR_READERS), login);
        }

        public override bool HasAccessInsert(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccess(AccessNCAS.CarReadersInsertDeletePerform), login);
        }

        public override bool HasAccessUpdate(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccessesForGroup(AccessNcasGroups.CAR_READERS), login);
        }

        public override bool HasAccessDelete(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccess(AccessNCAS.CarReadersInsertDeletePerform), login);
        }

        protected override void LoadObjectsInRelationship(AACarReader obj)
        {
            if (obj.AlarmArea != null)
                obj.AlarmArea = AlarmAreas.Singleton.GetById(obj.AlarmArea.IdAlarmArea);

            if (obj.CarReader != null)
                obj.CarReader = CarReaders.Singleton.GetById(obj.CarReader.IdCarReader);
        }

        public AlarmArea GetImplicitAlarmArea(CarReader carReader)
        {
            ICollection<AACarReader> aaCarReaders = SelectLinq<AACarReader>(aaCarReader => aaCarReader.CarReader == carReader && aaCarReader.PermanentlyUnlock == false);

            if (aaCarReaders != null && aaCarReaders.Count > 0 && aaCarReaders.ToList()[0].AlarmArea != null)
            {
                return AlarmAreas.Singleton.GetById(aaCarReaders.ToList()[0].AlarmArea.IdAlarmArea);
            }

            return null;
        }

        public void GetParentCCU(ICollection<Guid> ccus, Guid idAAcarReader)
        {
            AACarReader aaCarreader = GetById(idAAcarReader);
            if (ccus != null && aaCarreader != null)
            {
                if (aaCarreader.CarReader != null)
                {
                    CarReaders.Singleton.GetParentCCU(ccus, aaCarreader.CarReader.IdCarReader);
                }
            }
        }

        public void SetImplicitAAToCarReader(Guid guidAlarmArea)
        {
            AlarmArea alarmArea = AlarmAreas.Singleton.GetById(guidAlarmArea);
            if (alarmArea == null) return;
            foreach (AACarReader aaCarReader in alarmArea.AACarReaders)
            {
                if (!aaCarReader.PermanentlyUnlock)
                {
                    CancelPermanentlyUnlockinCardReaders(aaCarReader.CarReader, guidAlarmArea);
                }
            }
        }

        private void CancelPermanentlyUnlockinCardReaders(CarReader carReader, Guid guidAlarmArea)
        {
            ICollection<AACarReader> aaCarReaders = SelectLinq<AACarReader>(aaCarReader => aaCarReader.CarReader == carReader);
            if (aaCarReaders == null) return;
            foreach (AACarReader aaCr in aaCarReaders)
            {
                if (!aaCr.PermanentlyUnlock && aaCr.AlarmArea.IdAlarmArea != guidAlarmArea)
                {
                    try
                    {
                        AACarReader editAaCarReader = GetObjectForEdit(aaCr.IdAACarReader);
                        if (editAaCarReader != null)
                        {
                            editAaCarReader.PermanentlyUnlock = true;
                            Update(editAaCarReader);
                        }
                    }
                    catch { }
                }
            }
        }

        public override Contal.Cgp.Globals.ObjectType ObjectType
        {
            get { return Contal.Cgp.Globals.ObjectType.AACarReader; }
        }
    }
}
