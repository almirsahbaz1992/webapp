using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarskaStanica.Areas.ModulKorisnickiNalog.Models;
using VeterinarskaStanica.Models;

namespace VeterinarskaStanica.Interfaces
{
   public interface IKorisnickiNalogService
    {
       public  List<KorisnickiNalog> GetAdmina();
       public  void DodajAdministratora(NaloziEditVM vm);
         public NaloziEditVM GetAdmin(int id);
       public  void EditAdmina(NaloziEditVM vm);
        public void DeleteAdmin(int id);
    }
}
