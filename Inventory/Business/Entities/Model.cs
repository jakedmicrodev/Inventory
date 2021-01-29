using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Model : IdName
    {
        public int ProductId { get; set; }

        public string Product { get; set; }

        [Display(Name = "Product")]
        public List<SelectListItem> Products { get; set; }

        public string ModelNumber { get; set; }

        public string SerialNumber { get; set; }

        public string ImageName { get; set; }
    }
}
