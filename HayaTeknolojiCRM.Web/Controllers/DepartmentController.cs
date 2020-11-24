using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.Entities.Concreate;
using HayaTeknolojiCRM.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HayaTeknolojiCRM.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        public DepartmentController(IDepartmentService departmentService, IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
        } 
        // GET: Department
        public ActionResult Index()
        {
            var result = _departmentService.GetList();
            return View(result);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentService.Create(department);
                return RedirectToAction("Index");
            }           
            return View(department);
        }
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = _departmentService.GetById(id);
            if (department==null)
            {
                return HttpNotFound();
            }
            return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentService.Update(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public ActionResult DepartmentDetail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var department = _departmentService.GetList().Where(x => x.DepartmentId == id).ToList();
            var employee = _employeeService.GetList().Where(x => x.DepartmentID == id).ToList();
            DepartmentDetailVM departmentDetail = new DepartmentDetailVM()
            {
                Employee = employee,
                Department = department
            };
            return View(departmentDetail);
        }
    }
}
