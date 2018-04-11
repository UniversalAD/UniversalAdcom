using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UniversalAdcom.Models
{
    public class FreeArtworkContact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        [Display(Name = "Website/Facebook")]
        public string Website { get; set; }
    }
}