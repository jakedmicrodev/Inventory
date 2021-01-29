using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Company { get; set; }

        [Display(Name = "Company")]
        public List<SelectListItem> Companies { get; set; }

        public int MerchantId { get; set; }

        public string Merchant { get; set; }

        [Display(Name = "Merchant")]
        public List<SelectListItem> Merchants { get; set; }

        [Display(Name = "Support URL")]
        public string SupportUrl { get; set; }

        [Display(Name = "Date Added")]
        public DateTime AddDate { get; set; }

        [Display(Name = "Date Removed")]
        public DateTime RemoveDate { get; set; }

        public int ItemId { get; set; }

        public string Item { get; set; }

        [Display(Name = "Item")]
        public List<SelectListItem> Items { get; set; }
    }
}
