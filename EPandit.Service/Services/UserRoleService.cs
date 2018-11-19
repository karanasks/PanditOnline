using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface IUserRoleService
    {

    }

    public class UserRoleService: IUserRoleService
    {
        private readonly IUserRoleRepository repository;

        public UserRoleService(IUserRoleRepository repository)
        {
            this.repository = repository;
        }

    }
}