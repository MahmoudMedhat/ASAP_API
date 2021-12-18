using ASAP_API.Application.Interfaces;
using ASAP_API.Application.Services;
using ASAP_API.Domain;
using ASAP_API.Domain.Interface;
using ASAP_API.Infra.Data;
using ASAP_API.Infra.Data.Repository;
using ASAP_API.Infra.Data.UOW;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ASAPContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAdressAppServices, AddressAppServices>();
            services.AddScoped<IAddressRepository, AddressRepository>();


            services.AddScoped<IPersonAppServices, PersonAppServices>();
            services.AddScoped<IpersonRepository, PersonRepository>();
        }
    }
}
