using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Repositories;

namespace EPandit.Service.Services
{
    public interface IMeasurementUnitMasterService
    {

    }

    public class MeasurementUnitMasterService: IMeasurementUnitMasterService
    {
        private readonly IMeasurementUnitMasterRepository repository;

        public MeasurementUnitMasterService(IMeasurementUnitMasterRepository repository)
        {
            this.repository = repository;
        }
    }
}