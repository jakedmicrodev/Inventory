using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Appraisal
    {
        public int Id { get; set; }

        public int AppraiserId { get; set; }

        public string Appraiser { get; set; }

        [Display(Name = "Appraiser")]
        public List<SelectListItem> Appraisers { get; set; }

        [Display(Name = "Appraisal Date")]
        public DateTime AppraisalDate { get; set; }

        public decimal AppraisedValue { get; set; }

        public int ArtworkId { get; set; }
        public string Artwork { get; set; }

        [Display(Name = "Artwork")]
        public List<SelectListItem> Artworks { get; set; }

    }
}
