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
    }
}
