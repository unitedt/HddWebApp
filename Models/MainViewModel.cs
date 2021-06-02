using System.Collections.Generic;

namespace HddWebApp.Models
{
    public class MainViewModel
    {
        public IEnumerable<Hdd> Hdds { get; set; }
        public IEnumerable<Disk> Disks { get; set; }
    }
}
