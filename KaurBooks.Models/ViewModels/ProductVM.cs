using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KaurBooks.Models.ViewModels
{
    public class ProductVM
    {

        public Product Pdoduct { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
        public Product Product { get; set; }
    }
}
