using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayaTeknolojiCRM.Web.Controllers
{
    public class PermitController : Controller
    {

        private readonly IPermitService _permitService;


        public PermitController(IPermitService permitService)
        {
            _permitService = permitService;
        }
        // GET: Permit
        public ActionResult Index()
        {
            DateTime today = DateTime.Today;
            //var permit = _permitService.GetList(filter: x => x.StartDate >= today);
            var permit = _permitService.EmployeePermit(filter: x => x.StartDate >= today);
            return View(permit);
        }

        public ActionResult PermitHistory()
        {
            DateTime today = DateTime.Today;
            ViewBag.EmpID = new SelectList(_permitService.GetEmployees(), "EmpId", "Name");
            var permit = _permitService.EmployeePermit(filter: x => x.EndDate < today).Where(y => y.Status == "Onaylandı");
            return View(permit);
        }

        public ActionResult PermitDetail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var permit = _permitService.GetPermitById(id);
            return View(permit);
        }
        public ActionResult Create()
        {
            ViewBag.EmpID = new SelectList(_permitService.GetEmployees(), "EmpId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeePermit permit)
        {
            _permitService.Create(permit);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            EmployeePermit permit = _permitService.GetPermitById(id);
            if (permit == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpID = new SelectList(_permitService.GetEmployees(), "EmpId", "Name");
            return View(permit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeePermit permit)
        {
            if (ModelState.IsValid)
            {
                _permitService.Update(permit);
                return RedirectToAction("Index");
            }
            return View(permit);
        }

        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            EmployeePermit permit = _permitService.GetPermitById(id);
            if (permit == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpID = new SelectList(_permitService.GetEmployees(), "EmpId", "Name");
            return View(permit);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id)
        {
            EmployeePermit permit = _permitService.GetById(id); 
           
            _permitService.Delete(permit);
            return RedirectToAction("Index");
        }
    }
}