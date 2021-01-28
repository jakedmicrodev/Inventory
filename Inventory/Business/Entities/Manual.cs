using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Manual : IdName
    {
        public int ModelId { get; set; }

        public string Model { get; set; }

        [Display(Name = "Model")]
        public List<SelectListItem> Models { get; set; }
    }
}
