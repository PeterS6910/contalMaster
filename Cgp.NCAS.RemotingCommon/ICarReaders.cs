using Contal.Cgp.BaseLib;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.NCAS.Server.Beans.Shorts;
using Contal.Cgp.Server.Beans;
using System;
using System.Collections.Generic;

namespace Contal.Cgp.NCAS.RemotingCommon
{
    public interface ICarReaders : IBaseOrmTable<CarReader>
    {
        ICollection<CarReaderShort> ShortSelectByCriteria(IList<FilterSettings> filterSettings, out Exception error);
    }
}
