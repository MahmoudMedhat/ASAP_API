using ASAP_API.Application.Interfaces;
using ASAP_API.Application.ViewModels.Person;
using ASAP_API.Domain;
using ASAP_API.Domain.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.Services
{
    public class PersonAppServices : IPersonAppServices
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _IUnitOfWork;

        public PersonAppServices(IMapper mapper, IUnitOfWork IUnitOfWork)
        {
            _mapper = mapper;
            _IUnitOfWork = IUnitOfWork;
        }

        public bool Create(PersonSaveViewModel model)
        {
            var Data = _mapper.Map<Person>(model);

            _IUnitOfWork.IPersonRepository.Add(Data);
            return _IUnitOfWork.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<PersonViewModel> GetAll()
        {
            var data = _IUnitOfWork.IPersonRepository.GetAll().Include(x=>x.Address);
            return _mapper.Map<IEnumerable<PersonViewModel>>(data);

        }

        public PersonViewModel GetById(Guid id)
        {
            var data = _IUnitOfWork.IPersonRepository.GetById(id);
            return _mapper.Map<PersonViewModel>(data);
        }

        public bool Remove(Guid id)
        {
            _IUnitOfWork.IPersonRepository.Remove(id);
            return _IUnitOfWork.Commit();
        }

        public bool Update(UpdatePersonViewModel model)
        {
            var data = _mapper.Map<Person>(model);
            _IUnitOfWork.IPersonRepository.Update(data);
            return _IUnitOfWork.Commit();
        }
    }
}
