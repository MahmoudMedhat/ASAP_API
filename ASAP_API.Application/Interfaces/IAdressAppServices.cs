using ASAP_API.Application.ViewModels.Address;
using ASAP_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.Interfaces
{
    public interface IAdressAppServices : IDisposable
    {
        bool Create(AdressSaveViewModel model);
        IEnumerable<AdressViewModel> GetAll();

        bool Update(AdressViewModel model);
        AdressViewModel GetById(Guid id);
        bool Remove(Guid id);
    }
}
