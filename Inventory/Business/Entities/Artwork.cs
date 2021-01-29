using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Artwork
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int ArtTypeId { get; set; }

        [Display(Name = "Art Type")]
        public string ArtType { get; set; }

        [Display(Name = "Art Type")]
        public List<SelectListItem> ArtTypes { get; set; }

        public int ArtistId { get; set; }

        public string Artist { get; set; }

        [Display(Name = "Artist")]
        public List<SelectListItem> Artists { get; set; }

        public int ItemId { get; set; }

        public string Item { get; set; }

        [Display(Name = "Item")]
        public List<SelectListItem> Items { get; set; }

        public string Notes { get; set; }
        
        public string ImageName { get; set; }

    }
}
