using ASAP_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Infra.Data
{
    public class ASAPContext : DbContext
    {
        public ASAPContext(DbContextOptions<ASAPContext> options)
           : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> People { get; set; } 
    }
}
