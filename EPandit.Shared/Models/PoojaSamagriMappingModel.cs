using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class PoojaSamagriMappingModel: ModelBase
    {
        public int PoojaSamagriMappingId { get; set; }
        public int PoojaMasterId { get; set; }
        public int SamagriMasterId { get; set; }
        public double Quantity { get; set; }
        public int MeasurementUnitMasterId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}