using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Application.ViewModels.Person
{
    public class UpdatePersonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid AddressId { get; set; }
    }
}
