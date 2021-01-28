using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Appraiser : IdName
    {

        public int CompanyId { get; set; }

        public string Company { get; set; }

        [Display(Name = "Company")]
        public List<SelectListItem> Companies { get; set; }
    }
}
