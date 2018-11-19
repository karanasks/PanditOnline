using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class MeasurementUnitMasterModel: ModelBase
    {
        public int MeasurementUnitMasterId { get; set; }
        public string MeasurementUnit { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}