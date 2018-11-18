using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IPanditPoojaMappingRepository: IRepository<PanditPoojaMapping>
    {

    }

    public class PanditPoojaMappingRepository: RepositoryBase<PanditPoojaMapping>, IPanditPoojaMappingRepository
    {
        private readonly EPanditEntities context;

        public PanditPoojaMappingRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override PanditPoojaMapping FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}