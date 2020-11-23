using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        [Index(IsUnique = true), StringLength(11), Required]
        public string SSN { get; set; }

        [StringLength(50), Required]
        public string Name { get; set; }

        [StringLength(50), Required]
        public string Surname { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true),
            DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date),
         DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        public IEnumerable<Employee> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        [StringLength(50)]
        public string MaritalStatus { get; set; }

        [StringLength(50)]
        public string MilitaryStatus { get; set; }

        [StringLength(50)]
        public string DrivingLicence { get; set; }

        [StringLength(20)]
        public string BloodType { get; set; }

        public string EmployeeImage { get; set; }

        public bool Status { get; set; }
        public int PermitDate
        {
            get
            {
                DateTime today = DateTime.Now;
                TimeSpan day = today.Subtract(StartDate);
                TimeSpan age = today.Subtract(BirthDate);
                if (age.TotalDays >= 365 * 50 || age.TotalDays < 365 * 18)
                {
                    if (day.TotalDays < 365)
                        return 0;
                    else
                        return 20;
                }
                else
                {
                    if (day.TotalDays < 365)
                        return 0;

                    else if (day.TotalDays >= 365 && day.TotalDays <= 365 * 6)
                        return 14;

                    else if (day.TotalDays >= 365 * 6 && day.TotalDays <= 365 * 16)
                        return 20;

                    else
                        return 26;
                }

            }
        }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Reference> References { get; set; }
        public virtual ICollection<EmployeeAddressEmployee> EmployeeAddressEmployees { get; set; }
        public virtual ICollection<EmployeePhoneEmployee> EmployeePhoneEmployees { get; set; }
        public virtual ICollection<EmployeeCertificateEmployee> EmployeeCertificateEmployees { get; set; }
        public virtual ICollection<EmployeeCourseEmployee> EmployeeCourseEmployees { get; set; }
        public virtual ICollection<EmployeeExperience> EmployeeExperiences { get; set; }
        public virtual ICollection<EmployeeDependent> EmployeeDependents { get; set; }
        public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; }
        public virtual ICollection<EmployeePermit> EmployeePermits { get; set; }
        public virtual ICollection<EmployeeEmergencyContact> EmployeeEmergencyContacts { get; set; }
    }
}
