using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IUserRoleRepository: IRepository<UserRole>
    {

    }

    public class UserRoleRepository: RepositoryBase<UserRole>, IUserRoleRepository
    {
        private readonly EPanditEntities context;

        public UserRoleRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override UserRole FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}