using System;

class Program
{
    static void Main()
    {
        Figura cuadrado = new Cuadrado(5);
        Figura circulo = new Circulo(3);

        MostrarArea(cuadrado);
        MostrarArea(circulo);
    }

    static void MostrarArea(Figura figura)
    {
        Console.WriteLine($"Área de la figura: {figura.CalcularArea()}");
    }
}

abstract class Figura
{
    public abstract double CalcularArea();
}

class Cuadrado : Figura
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
}
