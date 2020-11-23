using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.Entities.Concreate;
using HayaTeknolojiCRM.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HayaTeknolojiCRM.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: Employee
        public ActionResult Index()
        {
            var result = _employeeService.GetList();


            //var result = _employeeService.GetEmployeePhone();
            return View(result);
        }
        public ActionResult EmployeeDetail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var employee = _employeeService.GetById(id);

            EmployeeDetailVM employeeDetail = new EmployeeDetailVM()
            {
                Employees=_employeeService.GetList()
            };
            return View(employeeDetail);
        }

        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_employeeService.GetDepartment(), "DepartmentID", "DepartmentName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Create(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            Employee employee = _employeeService.GetById(id);
            _employeeService.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}
