using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Item : IdName
    {
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string Category { get; set; }

        [Display(Name = "Category")]
        public List<SelectListItem> Categories { get; set; }

        public int SubCategoryId { get; set; }

        [Display(Name = "Sub Category")]
        public string SubCategory { get; set; }

        [Display(Name = "Sub Category")]
        public List<SelectListItem> SubCategories { get; set; }

    }
}
