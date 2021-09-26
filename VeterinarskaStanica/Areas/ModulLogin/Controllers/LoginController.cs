using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.Interfaces;
using VeterinarskaStanica.Models;
using VeterinasrkaStanica.Helper;

namespace VeterinasrkaStanica.Areas.ModulLogin.Controllers
{
    [Area("ModulLogin")]
    public class LoginController : Controller
    {
        private readonly VeterinarskaStanicaContext ctx;
        private IEmailService _emailService;

        public LoginController(VeterinarskaStanicaContext context, IEmailService  email)
        {
            ctx = context;
            _emailService = email;
        }

        // GET: ModulLogin/Login
        public ActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Provjera(string username, string password)
        {
            //    string hashPass = MD5Hash.GetMD5Hash(password);
            KorisnickiNalog k = ctx.KorisnickiNalozi.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (k == null)
            {
                TempData["Message"] = "Pogrešno korisničko ime ili lozinka!";
                return Redirect("Login");
            }

            if (k.admin == true)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext);
                _emailService.SendEmailAsync(k.Username, "Veterinarska sluzba", "<h1>Nova prijava</h1>" +
                    $"<p>Poštovani " + k.Username + ", neko je upravo izvršio prijavu na našu stranicu Veterinarska stanica. </p>");

                return Redirect("/ModulAdmin/Administrator/Home"); // ModulAdmin/Admin/Pregled
            }

            if (k.doc == true)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext);
                _emailService.SendEmailAsync(k.Username, "Veterinarska sluzba", "<h1>Nova prijava</h1>" +
                   $"<p>Poštovani " + k.Username + ", neko je upravo izvršio prijavu na našu stranicu Veterinarska stanica. </p>");

                return Redirect("/ModulDoktor/Doktor/Home"); // ModulDoktor/Doktor/Pregled
            }

            if (k.teh_osob == true)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext);
                _emailService.SendEmailAsync(k.Username, "Veterinarska sluzba", "<h1>Nova prijava</h1>" +
                   $"<p>Poštovani " + k.Username + ", neko je upravo izvršio prijavu na našu stranicu Veterinarska stanica. </p>");

                return Redirect("/ModulTehnickoOsoblje/TehnickoOsoblje/Home"); // ModulDoktor/Doktor/Pregled
            }

            return Redirect("Login");

        }

        public ActionResult Logout()
        {
            Autentifikacija.PokreniNovuSesiju(null, HttpContext);
            return RedirectToAction("Login");
        }
    }
}