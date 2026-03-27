public class UnitTestApplication
{
// PRUEBA 1: PERÍMETRO
[Theory]
[InlineData(1, 6.283)]
[InlineData(2, 12.566)]
[InlineData(3, 18.850)]
[InlineData(4, 25.133)]
[InlineData(5, 31.416)]
[InlineData(6, 37.699)]
[InlineData(7, 43.982)]
[InlineData(8, 50.265)]
[InlineData(9, 56.549)]
[InlineData(10, 62.832)]
[InlineData(0.5, 3.142)]
[InlineData(1.5, 9.425)]
[InlineData(2.5, 15.708)]
[InlineData(100, 628.319)]
[InlineData(12, 75.398)]
[InlineData(15, 94.248)]
[InlineData(20, 125.664)]
[InlineData(25, 157.080)]
[InlineData(0.1, 0.628)]
[InlineData(50, 314.159)]
public void CalcularPerimetroCirculo_radioValido_Correcto(double radio, double expected)
{
// Arrange
// (No necesitamos Arrange para inicializar objetos porque el método es estático)
// Act
// Llamamos al método directamente usando el nombre de la clase (Figura)
double actual = Figura262E16.Perimetro(radio);
// Assert
Assert.Equal(expected, actual,1);
}

// PRUEBA 2: ÁREA

[Theory]
[InlineData(1, 3.142)]
[InlineData(2, 12.566)]
[InlineData(3, 28.274)]
[InlineData(4, 50.265)]
[InlineData(5, 78.540)]
[InlineData(6, 113.097)]
[InlineData(7, 153.938)]
[InlineData(8, 201.062)]
[InlineData(9, 254.469)]
[InlineData(10, 314.159)]
[InlineData(0.5, 0.785)]
[InlineData(1.5, 7.069)]
[InlineData(2.5, 19.635)]
[InlineData(100, 31415.927)]
[InlineData(12, 452.389)]
[InlineData(15, 706.858)]
[InlineData(20, 1256.637)]
[InlineData(25, 1963.495)]
[InlineData(0.1, 0.031)]
[InlineData(50, 7853.982)]
public void CalcularAreaCirculo_RadioValido_Correcto(double radio, double expected)
{
// Arrange
// Act
double actual = Figura262E16.Area(radio);
// Assert
Assert.Equal(expected, actual,1);
}
// PRUEBA 3: VOLUMEN (CUBO)
[Theory]
[InlineData(3.142, 10, 31.420)]
[InlineData(12.566, 5, 62.830)]
[InlineData(28.274, 2, 56.548)]
[InlineData(50.265, 2, 100.530)]
[InlineData(78.540, 2, 157.080)]
[InlineData(113.097, 1, 113.097)]
[InlineData(153.938, 2, 307.876)]
[InlineData(201.062, 0.5, 100.531)]
[InlineData(254.469, 1, 254.469)]
[InlineData(314.159, 10, 3141.590)]
[InlineData(0.785, 10, 7.850)]
[InlineData(7.069, 4, 28.276)]
[InlineData(19.635, 2, 39.270)]
[InlineData(31415.927, 0.01, 314.159)]
[InlineData(452.389, 2, 904.778)]
[InlineData(706.858, 1, 706.858)]
[InlineData(1256.637, 0.5, 628.319)]
[InlineData(1963.495, 2, 3926.990)]
[InlineData(0.031, 100, 3.100)]
[InlineData(7853.982, 1, 7853.982)]
public void CalcularVolumenCubo_AreaYAlturaValidas_Correcto(double area, double altura, double expected)
{
// Arrange
// Act
double actual = Figura262E16.Volumen(area, altura);
// Assert
Assert.Equal(expected, actual,1);
}

  }
 