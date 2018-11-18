using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IPoojaMasterRepository: IRepository<PoojaMaster>
    {

    }

    public class PoojaMasterRepository: RepositoryBase<PoojaMaster>, IPoojaMasterRepository
    {
        private readonly EPanditEntities context;

        public PoojaMasterRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override PoojaMaster FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}