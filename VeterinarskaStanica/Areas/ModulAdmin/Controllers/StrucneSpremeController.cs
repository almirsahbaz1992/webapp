using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Areas.ModulAdmin.Models;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.Helper;
using VeterinarskaStanica.Models;

namespace VeterinasrkaStanica.Areas.ModulAdmin.Controllers
{
    [Area("ModulAdmin")]
    [Autorizacija(KorisnickeUloge.Administrator)]
    public class StrucneSpremeController : Controller
    {
        private readonly VeterinarskaStanicaContext db;

        public StrucneSpremeController(VeterinarskaStanicaContext context)
        {
            db = context;
        }

        // GET: ModulAdmin/StrucneSpreme/Create
        public ActionResult Create()
        {
            PodaciAddVM model = new PodaciAddVM();
            return PartialView("Create", model);
        }

        // POST: ModulAdmin/StrucneSpreme/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PodaciAddVM vm)
        {
            StrucneSpreme strucneSpreme = new StrucneSpreme();
            if (ModelState.IsValid)
            {
                strucneSpreme.Naziv = vm.Naziv;
                db.StrucneSpremee.Add(strucneSpreme);
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
