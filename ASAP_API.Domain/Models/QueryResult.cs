using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAP_API.Domain.Models
{
    public class QueryResult<T>
    {
        public IEnumerable<T> data { get; set; }
        public bool success { get; set; } = true;
        public List<String> Errors { get; set; } = new List<string>();
        public int Total { get; set; }
    }



}
