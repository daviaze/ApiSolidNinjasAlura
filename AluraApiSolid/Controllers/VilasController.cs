using AluraApiSolid.Models;
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
    public class VilasController : ControllerBase
    {
        private readonly IVilaService _vilaService;

        public VilasController(IVilaService vilaService)
        {
            _vilaService = vilaService;
        }

        [HttpGet]
        public IActionResult GetVilas()
        {
            return Ok(_vilaService.GetVilas());
        }

        [HttpGet("{id}")]
        public IActionResult GetVilaById(int id)
        {
            return Ok(_vilaService.GetVilaById(id));
        }

        [HttpPost]
        public IActionResult PostVila(Vila vila)
        {
            _vilaService.PostVila(vila);
            return CreatedAtAction("PostVila", new { id = vila.Id }, vila);
        }

        [HttpPut("{id}")]
        public IActionResult PutVila(Vila vila, int id)
        {
            bool success = _vilaService.PutVila(vila, id);
            if (success) return NoContent();
            return NotFound();
        }

        [HttpDelete]
        public IActionResult DeleteVila(int id)
        {
            bool success = _vilaService.DeleteVila(id);
            if (success) return NoContent();
            return NotFound();
        }
    }
}
