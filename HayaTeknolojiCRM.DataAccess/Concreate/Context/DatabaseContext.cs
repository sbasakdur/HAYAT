using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Concreate.Context
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<EmployeeAddressEmployee> EmployeeAddressEmployees { get; set; }
        public DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        public DbSet<EmployeeCertificateEmployee> EmployeeCertificateEmployees { get; set; }
        public DbSet<EmployeeCourse> EmployeeCourses { get; set; }
        public DbSet<EmployeeCourseEmployee> EmployeeCourseEmployees { get; set; }
        public DbSet<EmployeeDependent> EmployeeDependents { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeEmergencyContact> EmployeeEmergencyContacts { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperiences { get; set; }
        public DbSet<EmployeePermit> EmployeePermits { get; set; }
        public DbSet<EmployeePhone> EmployeePhones { get; set; }
        public DbSet<EmployeePhoneEmployee> EmployeePhoneEmployees { get; set; }
        public DbSet<Reference> References { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                  .HasRequired<Department>(e => e.Department)
                  .WithMany(c => c.Employees)
                 .HasForeignKey<int>(e => e.DepartmentID);

            modelBuilder.Entity<Reference>()
                .HasRequired<Employee>(r => r.Employee)
                .WithMany(e => e.References)
                .HasForeignKey<int>(r => r.EmpID);

            modelBuilder.Entity<EmployeeExperience>()
                .HasRequired<Employee>(r => r.Employee)
                .WithMany(e => e.EmployeeExperiences)
                .HasForeignKey<int>(r => r.EmpID);

            modelBuilder.Entity<EmployeeDependent>()
                .HasRequired<Employee>(r => r.Employee)
                .WithMany(e => e.EmployeeDependents)
                .HasForeignKey<int>(r => r.EmpID);

            modelBuilder.Entity<EmployeeEducation>()
               .HasRequired<Employee>(r => r.Employee)
               .WithMany(e => e.EmployeeEducations)
               .HasForeignKey<int>(r => r.EmpID);

            modelBuilder.Entity<EmployeeEmergencyContact>()
              .HasRequired<Employee>(r => r.Employee)
              .WithMany(e => e.EmployeeEmergencyContacts)
              .HasForeignKey<int>(r => r.EmpID);

            modelBuilder.Entity<EmployeePermit>()
               .HasRequired<Employee>(r => r.Employee)
               .WithMany(e => e.EmployeePermits)
               .HasForeignKey<int>(r => r.EmpID);

            modelBuilder.Entity<EmployeeAddressEmployee>()
                .HasKey(bc => new { bc.EmpID, bc.AddressID });
            modelBuilder.Entity<EmployeeAddressEmployee>()
                .HasRequired(eae => eae.Employee)
                .WithMany(b => b.EmployeeAddressEmployees)
                .HasForeignKey(bc => bc.EmpID);
            modelBuilder.Entity<EmployeeAddressEmployee>()
                .HasRequired(eae => eae.EmployeeAddress)
                .WithMany(c => c.EmployeeAddressEmployees)
                .HasForeignKey(bc => bc.AddressID);

            modelBuilder.Entity<EmployeePhoneEmployee>()
                .HasKey(bc => new { bc.EmpID, bc.PhoneID });
            modelBuilder.Entity<EmployeePhoneEmployee>()
                .HasRequired(eae => eae.Employee)
                .WithMany(b => b.EmployeePhoneEmployees)
                .HasForeignKey(bc => bc.EmpID);
            modelBuilder.Entity<EmployeePhoneEmployee>()
                .HasRequired(eae => eae.EmployeePhone)
                .WithMany(c => c.EmployeePhoneEmployees)
                .HasForeignKey(bc => bc.PhoneID);

            modelBuilder.Entity<EmployeeCertificateEmployee>()
              .HasKey(bc => new { bc.EmpID, bc.CertificateID });
            modelBuilder.Entity<EmployeeCertificateEmployee>()
                .HasRequired(eae => eae.Employee)
                .WithMany(b => b.EmployeeCertificateEmployees)
                .HasForeignKey(bc => bc.EmpID);
            modelBuilder.Entity<EmployeeCertificateEmployee>()
                .HasRequired(eae => eae.EmployeeCertificate)
                .WithMany(c => c.EmployeeCertificateEmployees)
                .HasForeignKey(bc => bc.CertificateID);

            modelBuilder.Entity<EmployeeCourseEmployee>()
              .HasKey(bc => new { bc.EmpID, bc.CourseID });
            modelBuilder.Entity<EmployeeCourseEmployee>()
                .HasRequired(eae => eae.Employee)
                .WithMany(b => b.EmployeeCourseEmployees)
                .HasForeignKey(bc => bc.EmpID);
            modelBuilder.Entity<EmployeeCourseEmployee>()
                .HasRequired(eae => eae.EmployeeCourse)
                .WithMany(c => c.EmployeeCourseEmployees)
                .HasForeignKey(bc => bc.CourseID);





        }
    }
}
