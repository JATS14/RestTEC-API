using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestTEC.DB;
using System.Collections.Generic;

namespace RestTEC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaPlatosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ListaPlatosController> _logger;

        public ListaPlatosController(ILogger<ListaPlatosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<Plato> Get()
        {
            return Menu.Lista_Platos;
        }
    }
}
