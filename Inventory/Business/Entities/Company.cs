using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Company : IdName
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public int CityId { get; set; }
        public string City { get; set; }

        [Display(Name = "City")]
        public List<SelectListItem> Cities { get; set; }

        public int StateId { get; set; }
        public string State { get; set; }

        [Display(Name = "State")]
        public List<SelectListItem> States { get; set; }

        public int CountryId { get; set; }
        public string Country { get; set; }

        [Display(Name = "Country")]
        public List<SelectListItem> Countries { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }


    }
}
