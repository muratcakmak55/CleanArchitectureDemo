using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {

        public static void RegisterSevices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
