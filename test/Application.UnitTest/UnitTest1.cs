public class UnitTestApplication
{
// PRUEBA 1: PERÍMETRO
[Theory]
[InlineData(2, 8)] // Lado 2 -> Perímetro 8
[InlineData(5, 20)] // Lado 5 -> Perímetro 20
[InlineData(10, 40)] // Lado 10 -> Perímetro 40
public void CalcularPerimetroCirculo_radioValido_Correcto(double radio, double expected)
{
// Arrange
// (No necesitamos Arrange para inicializar objetos porque el método es estático)
// Act
// Llamamos al método directamente usando el nombre de la clase (Figura)
double actual = Figura262E16.Perimetro(radio);
// Assert
Assert.Equal(expected, actual);
}

// PRUEBA 2: ÁREA

[Theory]
[InlineData(2, 4)] // Lado 2 -> Área 4
[InlineData(5, 25)] // Lado 5 -> Área 25
[InlineData(10, 100)] // Lado 10 -> Área 100
public void CalcularAreaCirculo_RadioValido_Correcto(double radio, double expected)
{
// Arrange
// Act
double actual = Figura262E16.Area (radio);
// Assert
Assert.Equal(expected, actual);
}
// PRUEBA 3: VOLUMEN (CUBO)
[Theory]
[InlineData(4, 2, 8)] // Área 4, Altura 2 -> Volumen 8
[InlineData(9, 3, 27)] // Área 9, Altura 3 -> Volumen 27
[InlineData(25, 5, 125)] // Área 25, Altura 5 -> Volumen 125
public void CalcularVolumenCubo_AreaYAlturaValidas_Correcto(double area, double altura, double expected)
{
// Arrange
// Act
double actual = Figura262E16.Volumen(area, altura);
// Assert
Assert.Equal(expected, actual);
}

  }
 