using DuWebsite1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Controllers
{
    public class DuyuruController : Controller
    {
        EFDuWebsiteRepository websiteRepository = new EFDuWebsiteRepository(new DuDbContext());
        public int PageSize = 8;

    
        public ActionResult Index()
        {
            var Duyurular = websiteRepository.Duyurular;

            return View(Duyurular);
        }

        public ActionResult DuyuruDetay(int id)
        {
            var duyuru = websiteRepository.Duyurular.FirstOrDefault(x => x.DuyuruId == id);
            return View(duyuru);
        }

        public ActionResult Privacy()
        {
            return View();
        }


    }
}
