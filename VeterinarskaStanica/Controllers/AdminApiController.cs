using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarskaStanica.Areas.ModulKorisnickiNalog.Models;
using VeterinarskaStanica.Interfaces;

namespace VeterinarskaStanica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private IKorisnickiNalogService _adminInterface;
        public AdminApiController(IKorisnickiNalogService k)
        {
            _adminInterface = k;
        }
        [HttpGet]
        public IActionResult GetAdmina()
        {
            return Ok(_adminInterface.GetAdmina());
        }
        [HttpPost]
        public IActionResult DodajNovog(NaloziEditVM vm)
        {
            _adminInterface.DodajAdministratora(vm);
            return Ok();
        }
        [HttpGet("{id}")]

        public IActionResult GetByID(int id)
        {
            return Ok(_adminInterface.GetAdmin(id));
        }
        [HttpPut]
        public IActionResult EditAdmina(NaloziEditVM vm)
        {
            _adminInterface.EditAdmina(vm);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAdmin(int id)
        {
            _adminInterface.DeleteAdmin(id);
            return Ok();
        }
    }
}
