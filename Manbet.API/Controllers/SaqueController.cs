using Manbet.Application;
using Manbet.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manbet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaqueController : ControllerBase
    {
        private readonly ILogger<SaqueController> _logger;
        private readonly ISaqueService _saqueService;

        public SaqueController(ILogger<SaqueController> logger, ISaqueService saqueService)
        { 
            _logger = logger;
            _saqueService = saqueService;
        }
        
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var saque = await _saqueService.ObterTodos();

            return Ok(saque);

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]ISaque saque)
        {
            var Saque = await _saqueService.CriarSaque(saque);

            return Ok(saque);

        }
    }
}