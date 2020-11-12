using Autofac;
using Autofac.Integration.Mvc;
using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.Concreate;
using HayaTeknolojiCRM.DataAccess.Abstract;
using HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HayaTeknolojiCRM.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EmployeeDal>().As<IEmployeeDal>();
            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<DepartmentDal>().As<IDepartmentDal>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
