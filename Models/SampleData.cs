using System.Linq;
using HddWebApp.Models;

namespace HddWebApp
{
    public static class SampleData
    {
        public static void Initialize(HddContext context)
        {
            if (!context.Hdds.Any())
            {
                context.Hdds.AddRange(
                    new Hdd
                    {
                        Name = "One Touch",
                        Company = "Seagate",
                        Capacity = 5e12m // terabytes
                    },
                    new Hdd
                    {
                        Name = "Mobile Drive",
                        Company = "LaCie",
                        Capacity = 5e12m
                    },
                    new Hdd
                    {
                        Name = "Passport",
                        Company = "Western Digital",
                        Capacity = 4e12m
                    },
                    new Hdd
                    {
                        Name = "Elements",
                        Company = "Western Digital",
                        Capacity = 14e12m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}