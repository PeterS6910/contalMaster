using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using NHibernate;

using Contal.Cgp.RemotingCommon;
using Contal.Cgp.Server.Beans;
using Contal.Cgp.BaseLib;
using Contal.Cgp.Globals;

namespace Contal.Cgp.Server.DB
{
    public sealed class Cars :
        ABaserOrmTableWithAlarmInstruction<Cars, Car>,
        ICars
    {
        private Cars()
            : base(null, new CudPreparationForObjectWithVersion<Car>())
        {
        }

        protected override void AddOrder(ref ICriteria c)
        {
            c.AddOrder(new Order(Car.COLUMNLP, true));
        }

        protected override IEnumerable<Car> GetObjectsWithLocalAlarmInstruction()
        {
            return null;
        }

        public override bool HasAccessView(Login login)
        {
            return AccessChecker.HasAccessControl(
                BaseAccess.GetAccessesForGroup(LoginAccessGroups.PERSONS), login);
        }

        public override bool HasAccessInsert(Login login)
        {
            return AccessChecker.HasAccessControl(
                BaseAccess.GetAccess(LoginAccess.PersonsInsertDeletePerform), login);
        }

        public override bool HasAccessUpdate(Login login)
        {
            return AccessChecker.HasAccessControl(
                BaseAccess.GetAccessesForGroup(LoginAccessGroups.PERSONS), login);
        }

        public override bool HasAccessDelete(Login login)
        {
            return AccessChecker.HasAccessControl(
                BaseAccess.GetAccess(LoginAccess.PersonsInsertDeletePerform), login);
        }

        public ICollection<CarShort> ShortSelectByCriteria(IList<FilterSettings> filterSettings, out Exception error)
        {
            var listCars = SelectByCriteria(filterSettings, out error);
            ICollection<CarShort> result = new List<CarShort>();
            if (listCars != null)
            {
                foreach (var car in listCars)
                {
                    result.Add(new CarShort(car));
                }
            }
            return result;
        }

        public IList<IModifyObject> ListModifyObjects(out Exception error)
        {
            var listCars = List(out error);
            IList<IModifyObject> result = null;
            if (listCars != null)
            {
                result = new List<IModifyObject>();
                foreach (var car in listCars)
                    result.Add(new CarModifyObj(car));
                result = result.OrderBy(c => c.ToString()).ToList();
            }
            return result;
        }

        public override Contal.Cgp.Globals.ObjectType ObjectType
        {
            get { return ObjectType.Car; }
        }
    }
}
