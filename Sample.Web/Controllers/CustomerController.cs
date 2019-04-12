using SampleCode.Business;
using SampleCode.Service;
using SampleCode.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService Service { get; set; }

        public CustomerController()
        {
            Service = new CustomerService();
        }
        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<CustomerObj> customers = Service.GetAll();
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            CustomerObj customer = Service.Get(id);
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            CustomerObj customer = Service.GetNew();
            TryUpdateModel(customer);

            if (ModelState.IsValid)
            {
                Service.Insert(customer);
                return RedirectToAction("Index");
            }
            else
            {

            }

            return View();
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            CustomerObj instance = Service.Get(id);
            return View(instance);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            CustomerObj instance = Service.Get(id);
            TryUpdateModel(instance);

            if (ModelState.IsValid)
            {
                Service.Update(instance);
                return RedirectToAction("Index");
            }
            else
            {

            }
            return View();
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
