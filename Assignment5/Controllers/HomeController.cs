using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        EmpContext context = new EmpContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            Emp e = new Emp();
            var Cities = context.Ctys.ToList();
            var States = context.States.ToList();
            var viewModel = new EmployeeVM
            {
                Employee = new Emp(),
                State = States,
                City = Cities

            };

            return View("Create", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(EmployeeVM person)
         {

             if (ModelState.IsValid)
             {
                 context.Emps.Add(person.Employee);
                 context.SaveChanges();
               
             }
                 return RedirectToAction("Index");



         }
        public ActionResult GetData()
        {
            using (EmpContext db = new EmpContext())
            {
                var WorkerData = db.Emps.OrderBy(a => a.Name).ToList();
                return Json(new { data = WorkerData }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult FillCity(int state)
        {
            EmpContext db = new EmpContext();

            var cities = db.Ctys.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

    }
}