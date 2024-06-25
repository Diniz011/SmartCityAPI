using Xunit;
using Microsoft.AspNetCore.Mvc;
using SmartCityAPI.Controllers;

public class TrafficControllerTests
{
    [Fact]
    public void GetTrafficData_ReturnsStatusCode200()
    {
        // Cria uma instância do controller
        var controller = new TrafficController();

        // Executa o método GetTrafficData
        var result = controller.GetTrafficData();

        // Verifica se o resultado é um StatusCode 200
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(200, okResult.StatusCode);
    }
}
