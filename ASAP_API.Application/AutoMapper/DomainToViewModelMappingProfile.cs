using ASAP_API.Application.ViewModels.Address;
using ASAP_API.Application.ViewModels.Person;
using ASAP_API.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Address, AdressViewModel>().ReverseMap();
            CreateMap<Address, AdressSaveViewModel>().ReverseMap();

            CreateMap<Person, PersonViewModel>().ReverseMap();
            CreateMap<Person, PersonSaveViewModel>().ReverseMap();

            CreateMap<Person, UpdatePersonViewModel>().ReverseMap();

        }
    }
}
