using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Domain.Models
{
    public class Address 
    {
        public Address(string description)
        {

            this.Id = Guid.NewGuid();
            this.Description = description;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
