using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface IPoojaMasterService
    {

    }

    public class PoojaMasterService: IPoojaMasterService
    {
        private readonly IPoojaMasterRepository repository;

        public PoojaMasterService(IPoojaMasterRepository repository)
        {
            this.repository = repository;
        }
    }
}