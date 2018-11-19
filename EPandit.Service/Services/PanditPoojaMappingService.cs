using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface IPanditPoojaMappingService
    {

    }

    public class PanditPoojaMappingService: IPanditPoojaMappingService
    {
        private readonly IPanditPoojaMappingRepository repository;

        public PanditPoojaMappingService(IPanditPoojaMappingRepository repository)
        {
            this.repository = repository;
        }
    }
}