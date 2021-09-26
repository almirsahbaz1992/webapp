using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarskaStanica.Areas.ModulKorisnickiNalog.Models;
using VeterinarskaStanica.DAL;
using VeterinarskaStanica.Interfaces;
using VeterinarskaStanica.Models;

namespace VeterinarskaStanica.Services
{
    public class KorisnickiNalogService: IKorisnickiNalogService
    {
        private readonly VeterinarskaStanicaContext db;
        public KorisnickiNalogService(VeterinarskaStanicaContext context)
        {
            db = context;
        }
        public   List<KorisnickiNalog> GetAdmina()
        {
           return  db.KorisnickiNalozi.Where(a=>a.admin==true).ToList();
        }
       public  void DodajAdministratora(NaloziEditVM vm)
        {
            KorisnickiNalog nalog= new KorisnickiNalog();
            nalog.Username = vm.Username;
            nalog.Password = vm.Password;
            nalog.IsDeleted = false;
            nalog.admin = true;
            db.Add(nalog);
            db.SaveChanges();
        }
        public NaloziEditVM GetAdmin(int  id)
        
        
        {
            var vm = db.KorisnickiNalozi.Where(a=>a.admin==true && a.Id==id).Select(a=>new NaloziEditVM { 
            Username=a.Username,
            Password=a.Password,
            Id=a.Id
            } ).FirstOrDefault();
            return vm;
            
        }
       public  void EditAdmina(NaloziEditVM vm)
        {
            var x = db.KorisnickiNalozi.Where(a => a.admin == true && a.Id == vm.Id).FirstOrDefault();
            x.Username = vm.Username;
            x.Password = vm.Password;
            db.SaveChanges();

        }
       public void DeleteAdmin(int  id)
        {
            var korisnik = db.KorisnickiNalozi.Find(id);
            db.Remove(korisnik);
            db.SaveChanges();
        }
    }
}
