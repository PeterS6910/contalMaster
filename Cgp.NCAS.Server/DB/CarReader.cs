using Contal.Cgp.BaseLib;
using Contal.Cgp.NCAS.RemotingCommon;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.NCAS.Server.Beans.Shorts;
using Contal.Cgp.Server.Beans;
using Contal.Cgp.Server.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contal.Cgp.NCAS.Server.DB
{
    public sealed class CarReaders :
        ANcasBaseOrmTable<CarReaders, CarReader>,
        ICarReaders
    {
        private CarReaders() : base(null)
        {
        }

        public override bool HasAccessView(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccessesForGroup(AccessNcasGroups.CARD_READERS), login);
        }

        public override bool HasAccessInsert(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccess(AccessNCAS.CardReadersInsertDeletePerform), login);
        }

        public override bool HasAccessUpdate(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccessesForGroup(AccessNcasGroups.CARD_READERS), login);
        }

        public override bool HasAccessDelete(Login login)
        {
            return AccessChecker.HasAccessControl(NCASAccess.GetAccess(AccessNCAS.CardReadersInsertDeletePerform), login);
        }

        public ICollection<CarReaderShort> ShortSelectByCriteria(IList<FilterSettings> filterSettings, out Exception error)
        {
            var list = SelectByCriteria(filterSettings, out error);
            return list != null ? new LinkedList<CarReaderShort>(list.Select(cr => new CarReaderShort(cr))) : null;
        }
    }
}
