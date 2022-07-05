using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace WEBAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public DepartamentoController(IConfiguration configuracion)
        {
            this.configuration = configuracion;
        }

        [HttpGet]
        
        public JsonResult Get()
        {
            string query = @"select DepartamentoID, Nombre from departamento ";
        }
    }
}
