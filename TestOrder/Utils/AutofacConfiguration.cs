using System.Configuration;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using TestOrder.BL.Interfaces;
using TestOrder.BL.Services;
using TestOrder.DL;
using TestOrder.DL.Interfaces;
using TestOrder.DL.Services;

namespace TestOrder.Utils
{
    public static class AutofacConfiguration
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            //Context
            builder.RegisterType<ApplicationDbContext>()
                .WithParameter("connectionString", ConfigurationManager.ConnectionStrings["ApplicationConnection"]?.ConnectionString)
                .InstancePerRequest();

            //UoW
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            
            //Repos
            builder.RegisterType<TestOrderRepository>().As<ITestOrderRepository>();
            builder.RegisterType<TestCategoryRepository>().As<ITestCategoryRepository>();
            builder.RegisterType<TestProductRepository>().As<ITestProductRepository>();

            builder.RegisterType<TestOrderProductRepository>().As<ITestOrderProductRepository>();
            builder.RegisterType<TestProductCategoryRepository>().As<ITestProductCategoryRepository>();
            
            //Services
            builder.RegisterType<TestOrderService>().As<ITestOrderService>();
            builder.RegisterType<TestCategoryService>().As<ITestCategoryService>();
            builder.RegisterType<TestProductService>().As<ITestProductService>();

            builder.RegisterType<TestOrderProductService>().As<ITestOrderProductService>();
            builder.RegisterType<TestProductCategoryService>().As<ITestProductCategoryService>();


            builder.RegisterType<ShipmentService>().As<IShipmentService>();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}