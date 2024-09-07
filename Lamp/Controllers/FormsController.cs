using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lamp.Controllers
{
    public class FormsController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Elais()
        {
            return View();
        }

        public IActionResult Consignee()
        {
            return View();
        }

        public IActionResult PdfElais()
        {
            return View();
        }

        public IActionResult Review()
        {
            return View();
        }

        public IActionResult Swdl_Ilias()
        {
            return View();
        }
        public IActionResult Swdl_Preview()
        {
            return View();
        }
        public IActionResult Product_Compliance_CheckList()
        {
            return View();
        }
        public IActionResult Product_Compliance_CheckList_Preview()
        {
            return View();
        }
    }
}
