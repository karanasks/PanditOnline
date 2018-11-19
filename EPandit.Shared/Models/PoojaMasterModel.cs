using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class PoojaMasterModel: ModelBase
    {
        public int PoojaMasterId { get; set; }
        public string PoojaName { get; set; }
        public string PoojaDescription { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}