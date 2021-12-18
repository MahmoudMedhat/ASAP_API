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
    public class PersonRepository : Repository<Person>, IpersonRepository
    {
        private readonly ASAPContext context;

        public PersonRepository(ASAPContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
