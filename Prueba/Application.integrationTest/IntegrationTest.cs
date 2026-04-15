public class IntegrationTestApplication
{
    [Theory]
    [InlineData(1, 10, 31.416)]
    [InlineData(2, 5, 62.832)]
    [InlineData(3, 2, 56.549)]
    [InlineData(4, 2, 100.531)]
    [InlineData(5, 2, 157.080)]
    [InlineData(6, 1, 113.097)]
    [InlineData(7, 2, 307.876)]
    [InlineData(8, 0.5, 100.531)]
    [InlineData(9, 1, 254.469)]
    [InlineData(10, 10, 3141.593)]
    [InlineData(0.5, 10, 7.854)]
    [InlineData(1.5, 4, 28.274)]
    [InlineData(2.5, 2, 39.270)]
    [InlineData(100, 0.01, 314.159)]
    [InlineData(12, 2, 904.779)]
    [InlineData(15, 1, 706.858)]
    [InlineData(20, 0.5, 628.319)]
    [InlineData(25, 2, 3926.991)]
    [InlineData(0.1, 100, 3.142)]
    [InlineData(50, 1, 7853.982)]
    public void CalcularVolumen_IntegrandoAreaCilindro_Correcto(double radio, double altura, double expected)
    {
        // Arrange - Setup
        // Obtenemos un dato real del Componente A.
        double area = Figura262E16.Area(radio); 
        // Act - Perform
        // Le pasamos ese dato real al Componente B.
        double actual = Figura262E16.Volumen(area, altura);
        // Assert - Verify
        // Verificamos si el flujo completo produjo el resultado correcto.
        Assert.Equal(expected, actual, 1);
    }
}