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
    public class CasaApostaController : ControllerBase
    {
        private readonly ILogger<CasaApostaController> _logger;
        private readonly ICasaApostaService _casaApostaService;

        public CasaApostaController(ILogger<CasaApostaController> logger, ICasaApostaService casaApostaService)
        { 
            _logger = logger;
            _casaApostaService = casaApostaService;
        }
        
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var casaApostas = await _casaApostaService.ObterTodos();

            return Ok(casaApostas);

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]ICasaAposta casaAposta)
        {
            var casaApostas = await _casaApostaService.CriarCasaAposta(casaAposta);

            return Ok(casaApostas);

        }
    }
}
