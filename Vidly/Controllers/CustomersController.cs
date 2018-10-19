using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        CustomerModel customerModel = new CustomerModel();

        // GET: Customers
        [Route("customers", Order = 1)]
        [Route("", Order = 2)]
        public ActionResult List()
        {          
            return View(customerModel);
        }

        [Route("customers/details/{id:int}")]
        public ActionResult Details(int id)
        {
            return View(customerModel.GetCustomerById(id));
        }
    }
}