using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.Server.Beans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contal.Cgp.NCAS.RemotingCommon
{
    public interface IAACarReaders : IBaseOrmTable<AACarReader>
    {
        AlarmArea GetImplicitAlarmArea(CarReader carReader);
    }
}
