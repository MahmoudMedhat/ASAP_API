using ASAP_API.Data.Repository;
using ASAP_API.Domain.Interface;
using ASAP_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Infra.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        private readonly ASAPContext context;

        public AddressRepository(ASAPContext context)
            : base(context)
        {
            this.context = context;
        }

    }
}
