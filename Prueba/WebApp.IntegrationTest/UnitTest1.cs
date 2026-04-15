using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public IntegrationTestPages(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

// Usamos [Theory] para pasarle las 5 rutas distintas a probar
[Theory]
[InlineData("/")]               // Prueba1: Index.cshtml
[InlineData("/about")]          // Prueba2: about.cshtml
[InlineData("/terminos")]       // Prueba3: terminos.cshtml
[InlineData("/privacidad")]     // Prueba4: privacidad.cshtml
[InlineData("/objetivo")]       // Prueba5: objetivo.cshtml
public async Task Get_PaginasDeLaApp_RetornanStatusCode200(string url)
{
    //Arrange: Creamos el cliente HTTP virtual
    var client = _factory.CreateClient();

    // Act: Simulamos la navegacion a la  URL que xUnit nos inyecta en cada iteración
    var response = await client.GetAsync(url);

    // Assert 1: Verificamos que no haya errores de servidor (500) ni no encontradas (404)
    response.EnsureSuccessStatusCode();
    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
     
    //Assert 2: (Buena práctica) Verificamos que nos está devolviendo una página web (HTML)
    Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType?.ToString());
}
}