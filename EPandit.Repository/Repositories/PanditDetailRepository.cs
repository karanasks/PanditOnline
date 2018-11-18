using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IPanditDetailRepository: IRepository<PanditDetail>
    {

    }

    public class PanditDetailRepository: RepositoryBase<PanditDetail>, IPanditDetailRepository
    {
        private readonly EPanditEntities context;

        public PanditDetailRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override PanditDetail FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}