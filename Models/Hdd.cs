using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HddWebApp.Models
{
    public class Hdd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal Capacity { get; set; }
    }
}
