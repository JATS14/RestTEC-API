using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestTEC.DB;
using System.Collections.Generic;
using System.Text.Json;


namespace RestTEC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost]
        public respuesta Post(LoginEntrada login)
        {
            respuesta res = new respuesta(Administrador.login(login.correo,login.contrasena));
            return res;
        }
        
    }
}

public class LoginEntrada
{
    public string correo;
    public string contrasena;
}

public class respuesta
{
    public string ingreso;
    public string status;

    public respuesta(string ingreso)
    {
        this.ingreso = ingreso;
    }

    public string Ingreso
    {
        get => ingreso;
        set => ingreso = value;
    }

    public string Status
    {
        get => status;
        set => status = value;
    }
    
    /*
    if (this.res1[0].ingreso === 'admin') {
        this.router.navigate([ '/administrador']);
    }
if ( this.res1[0].ingreso === 'chef') {
    this.router.navigate([ '/chef']);
}else{
    alert('Error en el ingreso de datos');
    */

}
