using ASAP_API.Application.ViewModels.Person;
using ASAP_API.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.Interfaces
{
    public interface IPersonAppServices
    {
        bool Create(PersonSaveViewModel model);
        IEnumerable<PersonViewModel> GetAll();

        bool Update(UpdatePersonViewModel model);
        PersonViewModel GetById(Guid id);
        bool Remove(Guid id);
    }
}
