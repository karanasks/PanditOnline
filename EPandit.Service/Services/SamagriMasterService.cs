using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface ISamagriMasterService
    {

    }

    public class SamagriMasterService: ISamagriMasterService
    {
        private readonly SamagriMasterRepository repository;

        public SamagriMasterService(SamagriMasterRepository repository)
        {
            this.repository = repository;
        }
    }
}