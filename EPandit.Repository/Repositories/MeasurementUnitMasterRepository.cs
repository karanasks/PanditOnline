using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IMeasurementUnitMasterRepository: IRepository<MeasurementUnitMaster>
    {

    }

    public class MeasurementUnitMasterRepository: RepositoryBase<MeasurementUnitMaster>, IMeasurementUnitMasterRepository
    {
        private readonly EPanditEntities context;

        public MeasurementUnitMasterRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override MeasurementUnitMaster FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}