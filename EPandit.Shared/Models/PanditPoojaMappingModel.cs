using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class PanditPoojaMappingModel: ModelBase
    {
        public int PanditPoojaMappingId { get; set; }
        public long UserMasterId { get; set; }
        public int PoojaMasterId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}