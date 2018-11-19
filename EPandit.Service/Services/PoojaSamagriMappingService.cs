using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface IPoojaSamagriMappingService
    {

    }

    public class PoojaSamagriMappingService: IPoojaSamagriMappingService
    {
        private readonly IPoojaSamagriMappingRepository repository;

        public PoojaSamagriMappingService(IPoojaSamagriMappingRepository repository)
        {
            this.repository = repository;
        }
    }
}