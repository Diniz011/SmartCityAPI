using Microsoft.AspNetCore.Mvc;

namespace SmartCityAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrafficController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTrafficData()
        {
            return Ok(new { message = "Dados de tráfego retornados." });
        }

        // Adicionar mais métodos para POST, DELETE, etc.

        [HttpPost]
        public IActionResult GetTrafficData2()
        {
            return Ok(new { message = "Dados de tráfego adicionados." });
        }
        
        [HttpPut]
        public IActionResult GetTrafficData3()
        {
            return Ok(new { message = "Dados de tráfego atualizados." });
        }

        [HttpDelete]
        public IActionResult GetTrafficData4()
        {
            return Ok(new { message = "Dados de tráfego deletado com sucesso." });
        }
    }
}
