using AluraApiSolid.Context;
using AluraApiSolid.Daos.Interfaces;
using AluraApiSolid.Models;
using AluraApiSolid.Pagination;
using AluraApiSolid.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NinjasController : ControllerBase
    {
        private readonly INinjaService _ninjaService;

        public NinjasController(INinjaService ninjaservice)
        {
            _ninjaService = ninjaservice;
        }

        [HttpGet]
        public IActionResult GetNinjas([FromQuery] Parameters parameters)
        {
            return Ok(_ninjaService.GetNinjas(parameters));
        }

        [HttpGet("{id}")]
        public IActionResult GetNinjaById(int id)
        {
            return Ok(_ninjaService.GetNinjaById(id));
        }

        [HttpPost]
        public IActionResult PostNinja(Ninja ninja)
        {
            _ninjaService.PostNinja(ninja);
            return CreatedAtAction("PostNinja", new { id = ninja.Id }, ninja);
        }
        [HttpPut("{id}")]
        public IActionResult PutNinja(Ninja ninja, int id)
        {
            bool success = _ninjaService.PutNinja(ninja, id);
            if (success) return NoContent();
            else return NotFound();
        }

        [HttpDelete]
        public IActionResult DeleteNinja(int ninja)
        {
            bool success = _ninjaService.DeleteNinja(ninja);
            if (success) return NoContent();
            else return NotFound();

        }
    }
}
