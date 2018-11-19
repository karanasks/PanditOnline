using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class PanditDetailModel: ModelBase
    {
        public int PanditDetailId { get; set; }
        public long UserMasterId { get; set; }
        public double? YearsOfExperience { get; set; }
        public string PanditDescription { get; set; }
        public string OrganisationName { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}