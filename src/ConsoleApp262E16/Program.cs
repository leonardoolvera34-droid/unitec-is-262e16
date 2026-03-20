//volumen de un cilindro  es (3.14*radio*radio*altura)=area*altura
double radio = 5;
double altura=10;
double perimetro = Figura262E16.Perimetro(radio);
double area = Figura262E16.Area(radio);
double volumen = Figura262E16.Volumen(area, altura);
Console.WriteLine($"El perímetro de un circulo con radio de {radio}cm  es {perimetro:F2}cm");
Console.WriteLine($"El área de un circulo de {radio}cm es {area}cm2");
Console.WriteLine($"El volumen de un cilindro con area de {area}cm2 y con una altura de {altura}cm  es {volumen}cm3");
