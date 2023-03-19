using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussiness.Abstract;
using Bussiness.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;



namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AboutMeManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<EfAboutMeDal>().As<IAboutMeDal>().SingleInstance();

            builder.RegisterType<BlogManager>().As<IBlogService>().SingleInstance();
            builder.RegisterType<EfBlogDal>().As<IBlogDal>().SingleInstance();

            builder.RegisterType<BlogImageManager>().As<IBlogImageService>().SingleInstance();
            builder.RegisterType<EfBlogImageDal>().As<IBlogImageDal>().SingleInstance();

            builder.RegisterType<ProjectManager>().As<IProjectService>().SingleInstance();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>().SingleInstance();

            builder.RegisterType<ProjectImageManager>().As<IProjectImageService>().SingleInstance();
            builder.RegisterType<EfProjectImageDal>().As<IProjectImageDal>().SingleInstance();

            builder.RegisterType<SkillManager>().As<ISkillService>().SingleInstance();
            builder.RegisterType<EfSkillDal>().As<ISkillDal>().SingleInstance();

            builder.RegisterType<SkillImageManager>().As<ISkillImageService>().SingleInstance();
            builder.RegisterType<EfSkillImageDal>().As<ISkillImageDal>().SingleInstance();

            builder.RegisterType<SliderManager>().As<ISliderService>().SingleInstance();
            builder.RegisterType<EfSliderDal>().As<ISliderDal>().SingleInstance();

            builder.RegisterType<WelcomePageManager>().As<IWelcomePageService>().SingleInstance();
            builder.RegisterType<EfWelcomePageDal>().As<IWelcomePageDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

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
