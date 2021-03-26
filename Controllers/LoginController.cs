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
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost]
        public void Post()
        {
            
        }
        
    }
}