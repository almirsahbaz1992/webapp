using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Areas.ModulAdmin.Models;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.Helper;
using VeterinarskaStanica.Models;

namespace VeterinasrkaStanica.Areas.ModulAdmin.Controllers
{
    [Area("ModulAdmin")]
    [Autorizacija(KorisnickeUloge.Administrator)]
    public class OdjeliController : Controller
    {
        private readonly VeterinarskaStanicaContext db;

        public OdjeliController(VeterinarskaStanicaContext context)
        {
            db = context;
        }

        // GET: ModulAdmin/Odjeli/Create
        public ActionResult Create()
        {
            PodaciAddVM model = new PodaciAddVM();
            return PartialView("Create", model);
        }

        // POST: ModulAdmin/Odjeli/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PodaciAddVM vm)
        {
            Odjeli odjeli = new Odjeli();
            if (ModelState.IsValid)
            {
                odjeli.Naziv = vm.Naziv;
                db.Odjelii.Add(odjeli);
                db.SaveChanges();

                TempData["Message"] = "Uspješno dodavanje!";
                return RedirectToAction("Create");
            }
            return PartialView(vm);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
