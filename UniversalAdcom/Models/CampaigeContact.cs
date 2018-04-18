using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UniversalAdcom.Models
{
    public class CampaignContact
    {
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Display (Name ="Last Name")]
        public string LastName { get; set; }
        [Display (Name ="Country Prefix")]
        public string CountryPrefix { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Boolean Hidden { get; set; }
    }
}