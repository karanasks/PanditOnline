using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class SamagriMasterModel: ModelBase
    {
        public int SamagriMasterId { get; set; }
        public string SamagriName { get; set; }
        public string SamagriDescription { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}