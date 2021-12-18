using ASAP_API.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        public IAddressRepository addressRepository { get; }
        public IpersonRepository IPersonRepository { get; }
        bool Commit();
    }
}
