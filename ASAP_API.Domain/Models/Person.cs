using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Domain.Models
{
    [Table("Person")]
    public class Person
    {
        public Person(string name , Guid addressId)
        {

            this.Id = Guid.NewGuid();
            this.Name = name;
            this.AddressId = addressId;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid AddressId { get; set; }
        public Address  Address { get; set; }
    }

}