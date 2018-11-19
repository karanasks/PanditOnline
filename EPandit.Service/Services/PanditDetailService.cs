using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface IPanditDetailService
    {

    }

    public class PanditDetailService: IPanditDetailService
    {
        private readonly IPanditDetailRepository repository;

        public PanditDetailService(IPanditDetailRepository repository)
        {
            this.repository = repository;
        }
    }
}