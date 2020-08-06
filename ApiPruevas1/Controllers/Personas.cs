using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ApiPruevas1.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruevas1.Controllers
{

    [ApiController]
    public class Personas : ControllerBase
    {

        [HttpGet]
        [Route("api/Personas/GetPerson")]
        public async Task<ActionResult<int>> GetPerson(int Id)
        {
            try
            {
                Persona per = listaPersonas.GetElement(Id);
                return Ok(per);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("api/Personas/GetAllPerson")]
        public async Task<ActionResult<int>> GetAllPerson()
        {       
            try
            {
                var personas = listaPersonas.GetAllElements();
                return Ok(personas);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message.ToString());
            }

        }

        [HttpPost]
        [Route("api/Personas/AddPerson")]
        public async Task<ActionResult> AddPerson([FromBody] Persona per)
        {
            try {
                listaPersonas.addElement(per);
                return Ok(true);
            }
            catch (Exception ex) {
                return Ok(ex.Message.ToString());
            }  
        }

        [HttpPost]
        [Route("api/Personas/UpdatePerson")]
        public async Task<ActionResult> UpdatePerson([FromBody] Persona per)
        {
            try
            {
                listaPersonas.UpdateElement(per);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("api/Personas/DeletePerson")]
        public async Task<ActionResult> DeletePerson(int id)
        {
            try
            {
                listaPersonas.RemoveElement(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message.ToString());
            }
        }
    }
}
