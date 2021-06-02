namespace HddWebApp.Models
{
    public class Disk
    {
        public int DiskId { get; set; }
        public string ComputerName { get; set; } // название компьютера, где установлен диск
        public decimal UsedBytes  { get; set; } // занятое пространство на диске
        public int HddId { get; set; } // ссылка на связанную модель Hdd
        public Hdd Hdd { get; set; }
    }
}
