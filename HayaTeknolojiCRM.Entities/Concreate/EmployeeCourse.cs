using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeCourse
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [StringLength(150)]
        public string CourseName { get; set; }
        [DataType(DataType.Date),DisplayFormat(DataFormatString ="{0:dd.MM.yyyy",ApplyFormatInEditMode =true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [StringLength(100)]
        public string Institution { get; set; }
        [StringLength(100)]
        public string Instructor { get; set; }
        public virtual ICollection<EmployeeCourseEmployee> EmployeeCourseEmployees { get; set; }
    }
}
