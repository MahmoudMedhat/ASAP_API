using ASAP_API.Application.ViewModels.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.ViewModels.Person
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public AdressViewModel Address { get; set; }
    }
}
