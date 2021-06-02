using Microsoft.AspNetCore.Mvc;
using HddWebApp.Models;
using System.Linq;

namespace HddWebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly HddContext db;
        public HomeController(HddContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var model = new MainViewModel
            {
                Hdds = db.Hdds.ToList(),
                Disks = db.Disks.ToList()
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Install(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.hddId = id;
            return View();
        }
        [HttpPost]
        public string Install(Disk disk)
        {
            db.Disks.Add(disk);
            db.SaveChanges();
            return "Диск установлен в компьютер " + disk.ComputerName;
        }
    }
}
