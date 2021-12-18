using ASAP_API.Domain;
using ASAP_API.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Infra.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ASAPContext _context;

        public IAddressRepository addressRepository { get; }
        public IpersonRepository IPersonRepository { get; }
        public UnitOfWork(ASAPContext context, IAddressRepository addressRepository, IpersonRepository ipersonRepository)
        {
            _context = context;
            this.addressRepository = addressRepository;
            IPersonRepository = ipersonRepository;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
           
        }
    }
}
