using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendAssignmentPt1.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace BackendAssignmentPt1.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Invoices = Repository.Invoices;
            return View();
        }
    }
}
