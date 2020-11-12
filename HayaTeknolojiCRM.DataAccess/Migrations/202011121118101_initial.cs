namespace HayaTeknolojiCRM.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        SSN = c.String(nullable: false, maxLength: 11),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 100),
                        Gender = c.String(maxLength: 20),
                        BirthDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        MaritalStatus = c.String(maxLength: 50),
                        MilitaryStatus = c.String(maxLength: 50),
                        DrivingLicence = c.String(maxLength: 50),
                        BloodType = c.String(maxLength: 20),
                        EmployeeImage = c.String(),
                        Status = c.Boolean(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.SSN, unique: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.EmployeeAddressEmployees",
                c => new
                    {
                        EmpID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmpID, t.AddressID })
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeAddresses", t => t.AddressID, cascadeDelete: true)
                .Index(t => t.EmpID)
                .Index(t => t.AddressID);
            
            CreateTable(
                "dbo.EmployeeAddresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Country = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        District = c.String(maxLength: 50),
                        Neighborhood = c.String(maxLength: 50),
                        Street = c.String(maxLength: 50),
                        Number = c.String(maxLength: 10),
                        PostCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.EmployeeCertificateEmployees",
                c => new
                    {
                        EmpID = c.Int(nullable: false),
                        CertificateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmpID, t.CertificateID })
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCertificates", t => t.CertificateID, cascadeDelete: true)
                .Index(t => t.EmpID)
                .Index(t => t.CertificateID);
            
            CreateTable(
                "dbo.EmployeeCertificates",
                c => new
                    {
                        CertificateId = c.Int(nullable: false, identity: true),
                        CertificateName = c.String(),
                        TakenDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Institution = c.String(maxLength: 100),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CertificateId);
            
            CreateTable(
                "dbo.EmployeeCourseEmployees",
                c => new
                    {
                        EmpID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmpID, t.CourseID })
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCourses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.EmpID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.EmployeeCourses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(maxLength: 150),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Institution = c.String(maxLength: 100),
                        Instructor = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.EmployeeDependents",
                c => new
                    {
                        DependentId = c.Int(nullable: false, identity: true),
                        DependentSSN = c.String(maxLength: 11),
                        DependentName = c.String(maxLength: 100),
                        Proximity = c.String(maxLength: 50),
                        EmpID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DependentId)
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
            CreateTable(
                "dbo.EmployeeEducations",
                c => new
                    {
                        EducationId = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(maxLength: 35),
                        SchoolDepartment = c.String(maxLength: 50),
                        Grade = c.String(maxLength: 25),
                        Status = c.String(maxLength: 25),
                        EmpID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EducationId)
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
            CreateTable(
                "dbo.EmployeeEmergencyContacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        ContactName = c.String(maxLength: 100),
                        Proximity = c.String(maxLength: 50),
                        Phone = c.String(),
                        EmpID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId)
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
            CreateTable(
                "dbo.EmployeeExperiences",
                c => new
                    {
                        ExperienceId = c.Int(nullable: false, identity: true),
                        CorporationName = c.String(maxLength: 100),
                        JobRole = c.String(maxLength: 100),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Reason = c.String(maxLength: 100),
                        EmpID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExperienceId)
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
            CreateTable(
                "dbo.EmployeePermits",
                c => new
                    {
                        PermitID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        StartHour = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        EndHour = c.DateTime(nullable: false),
                        PermitType = c.String(maxLength: 20),
                        Status = c.String(maxLength: 20),
                        Day = c.Int(nullable: false),
                        EmpID = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PermitID)
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
            CreateTable(
                "dbo.EmployeePhoneEmployees",
                c => new
                    {
                        EmpID = c.Int(nullable: false),
                        PhoneID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmpID, t.PhoneID })
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .ForeignKey("dbo.EmployeePhones", t => t.PhoneID, cascadeDelete: true)
                .Index(t => t.EmpID)
                .Index(t => t.PhoneID);
            
            CreateTable(
                "dbo.EmployeePhones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(maxLength: 50),
                        PhoneType = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PhoneId);
            
            CreateTable(
                "dbo.References",
                c => new
                    {
                        ReferenceId = c.Int(nullable: false, identity: true),
                        ReferenceFullName = c.String(maxLength: 100),
                        JobRole = c.String(maxLength: 100),
                        Contact = c.String(maxLength: 100),
                        EmpID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReferenceId)
                .ForeignKey("dbo.Employees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.References", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeePhoneEmployees", "PhoneID", "dbo.EmployeePhones");
            DropForeignKey("dbo.EmployeePhoneEmployees", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeePermits", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeExperiences", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeEmergencyContacts", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeEducations", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeDependents", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeCourseEmployees", "CourseID", "dbo.EmployeeCourses");
            DropForeignKey("dbo.EmployeeCourseEmployees", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeCertificateEmployees", "CertificateID", "dbo.EmployeeCertificates");
            DropForeignKey("dbo.EmployeeCertificateEmployees", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeAddressEmployees", "AddressID", "dbo.EmployeeAddresses");
            DropForeignKey("dbo.EmployeeAddressEmployees", "EmpID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.References", new[] { "EmpID" });
            DropIndex("dbo.EmployeePhoneEmployees", new[] { "PhoneID" });
            DropIndex("dbo.EmployeePhoneEmployees", new[] { "EmpID" });
            DropIndex("dbo.EmployeePermits", new[] { "EmpID" });
            DropIndex("dbo.EmployeeExperiences", new[] { "EmpID" });
            DropIndex("dbo.EmployeeEmergencyContacts", new[] { "EmpID" });
            DropIndex("dbo.EmployeeEducations", new[] { "EmpID" });
            DropIndex("dbo.EmployeeDependents", new[] { "EmpID" });
            DropIndex("dbo.EmployeeCourseEmployees", new[] { "CourseID" });
            DropIndex("dbo.EmployeeCourseEmployees", new[] { "EmpID" });
            DropIndex("dbo.EmployeeCertificateEmployees", new[] { "CertificateID" });
            DropIndex("dbo.EmployeeCertificateEmployees", new[] { "EmpID" });
            DropIndex("dbo.EmployeeAddressEmployees", new[] { "AddressID" });
            DropIndex("dbo.EmployeeAddressEmployees", new[] { "EmpID" });
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropIndex("dbo.Employees", new[] { "SSN" });
            DropTable("dbo.References");
            DropTable("dbo.EmployeePhones");
            DropTable("dbo.EmployeePhoneEmployees");
            DropTable("dbo.EmployeePermits");
            DropTable("dbo.EmployeeExperiences");
            DropTable("dbo.EmployeeEmergencyContacts");
            DropTable("dbo.EmployeeEducations");
            DropTable("dbo.EmployeeDependents");
            DropTable("dbo.EmployeeCourses");
            DropTable("dbo.EmployeeCourseEmployees");
            DropTable("dbo.EmployeeCertificates");
            DropTable("dbo.EmployeeCertificateEmployees");
            DropTable("dbo.EmployeeAddresses");
            DropTable("dbo.EmployeeAddressEmployees");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
