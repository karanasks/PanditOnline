using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;


namespace EPandit.Service.Services
{
    public interface IUserMasterService
    {

    }

    public class UserMasterService: IUserMasterService
    {
        private readonly IUserMasterRepository repository;

        public UserMasterService(IUserMasterRepository repository)
        {
            this.repository = repository;
        }
    }
}