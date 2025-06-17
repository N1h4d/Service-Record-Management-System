using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DrivingLicenseManager>().As<IDrivingLicenseService>();
            builder.RegisterType<EfDrivingLicenseDal>().As<IDrivingLicenseDal>();

            builder.RegisterType<FamilyInformationManager>().As<IFamilyInformationService>();
            builder.RegisterType<EfFamilyInformationDal>().As<IFamilyInformationDal>();


            builder.RegisterType<MilitaryServiceManager>().As<IMilitaryServiceService>();
            builder.RegisterType<EfMilitaryServiceDal>().As<IMilitaryServiceDal>();

            builder.RegisterType<EmploymentHistoryManager>().As<IEmploymentHistoryService>();
            builder.RegisterType<EfEmploymentHistoryDal>().As<IEmploymentHistoryDal>();

            builder.RegisterType<PersonalInformationManager>().As<IPersonalInformationService>();
            builder.RegisterType<EfPersonalInformationDal>().As<IPersonalInformationDal>();



            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                 .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                 {
                     Selector = new AspectInterceptorSelector()
                 }).SingleInstance();

        }
    }
}
