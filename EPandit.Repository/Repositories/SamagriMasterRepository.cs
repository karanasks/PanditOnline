using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface ISamagriMasterRepository: IRepository<SamagriMaster>
    {

    }

    public class SamagriMasterRepository: RepositoryBase<SamagriMaster>, ISamagriMasterRepository
    {
        private readonly EPanditEntities context;

        public SamagriMasterRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override SamagriMaster FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}