using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayaTeknolojiCRM.Web.ViewModels
{
    public class EmployeeDetailVM
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<EmployeeEmergencyContact> EmployeeEmergencyContacts { get; set; }
        public IEnumerable<EmployeeAddressEmployee> EmployeeAddressEmployees { get; set; }
        public IEnumerable<EmployeeEducation> EmployeeEducations { get; set; }
        public IEnumerable<EmployeePermit> EmployeePermits { get; set; }
        public IEnumerable<EmployeeCourseEmployee> EmployeeCourseEmployees { get; set; }
        public IEnumerable<EmployeeCertificateEmployee> EmployeeCertificateEmployees { get; set; }
        public IEnumerable<EmployeeExperience> EmployeeExperiences { get; set; }
    }
}