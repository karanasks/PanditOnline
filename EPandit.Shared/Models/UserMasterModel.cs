using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPandit.Shared.Models
{
    public class UserMasterModel: ModelBase
    {
        public long UserMasterId { get; set; }
        public int UserRoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginId { get; set; }
        public long MobileNumber { get; set; }
        public long? WhatsappMobileNumber { get; set; }
        public long? AlternateMobileNumber1 { get; set; }
        public long? AlternateMobileNumber2 { get; set; }
        public long? AlternateMobileNumber3 { get; set; }
        public string UserAddress { get; set; }
        public string HomeLongitude { get; set; }
        public string HomeLatitude { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string UserPassword { get; set; }
        public string UserImage { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public int PinCode { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}