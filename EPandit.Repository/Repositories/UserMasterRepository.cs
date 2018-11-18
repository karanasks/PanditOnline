using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IUserMasterRepository: IRepository<UserMaster>
    {

    }

    public class UserMasterRepository: RepositoryBase<UserMaster>, IUserMasterRepository
    {
        private readonly EPanditEntities context;

        public UserMasterRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override UserMaster FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}