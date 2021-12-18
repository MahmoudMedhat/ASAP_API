using ASAP_API.Application.Interfaces;
using ASAP_API.Application.ViewModels.Address;
using ASAP_API.Domain;
using ASAP_API.Domain.Interface;
using ASAP_API.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.Services
{
    public class AddressAppServices : IAdressAppServices
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _IUnitOfWork;

        public AddressAppServices(IMapper mapper, IUnitOfWork IUnitOfWork)
        {
            _mapper = mapper;
            _IUnitOfWork = IUnitOfWork;
        }

        public bool Create(AdressSaveViewModel model)
        {
            var Data = _mapper.Map<Address>(model);

            _IUnitOfWork.addressRepository.Add(Data);
            return _IUnitOfWork.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<AdressViewModel> GetAll()
        {
            var data = _IUnitOfWork.addressRepository.GetAll();
            return _mapper.Map<IEnumerable<AdressViewModel>>(data);

        }

        public AdressViewModel GetById(Guid id)
        {
            var data = _IUnitOfWork.addressRepository.GetById(id);
            return _mapper.Map<AdressViewModel>(data);
        }

        public bool Remove(Guid id)
        {
            _IUnitOfWork.addressRepository.Remove(id);
            return _IUnitOfWork.Commit();
        }

        public bool Update(AdressViewModel model)
        {
            var data = _mapper.Map<Address>(model);
            _IUnitOfWork.addressRepository.Update(data);
            return _IUnitOfWork.Commit();
        }
    }
}
