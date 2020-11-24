using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HayaTeknolojiCRM.Web.Controllers
{
    public class EmployeeExperienceController : Controller
    {
        private readonly IEmployeeExperienceService _employeeExpService;
        public EmployeeExperienceController(IEmployeeExperienceService employeeExpService)
        {
            _employeeExpService = employeeExpService;
        }
        // GET: EmployeeExperience
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var experience = _employeeExpService.GetExperienceById(id);
            return View(experience);
        }
        [HttpPost]
        public ActionResult Create(EmployeeExperience experience)
        {
            if (ModelState.IsValid)
            {
                _employeeExpService.Create(experience);
                return RedirectToAction("~/Employee/EmployeeDetail/" + experience.EmpID);
            }
            return View(experience);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var experience = _employeeExpService.GetExperienceById(id);
            return View(experience);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeExperience experience)
        {
            if (ModelState.IsValid)
            {
                _employeeExpService.Update(experience);
                return RedirectToAction("~/Employee/EmployeeDetail/" + experience.EmpID);
            }
            return View(experience);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeExperience experience = _employeeExpService.GetExperienceById(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View(experience);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            EmployeeExperience experience = _employeeExpService.GetExperienceById(id);
            _employeeExpService.Delete(experience);
            return RedirectToAction("~/Employee/EmployeeDetail/" + experience.EmpID);
        }
    }
}