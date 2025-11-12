// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

var circ = new Circulo();
circ.Radio = 20;
var result_area = circ.Area();
var result_perim = circ.Perimetro();
Console.WriteLine($"El area es: {result_area} - el perímetro es: {result_perim} - El nuevo radio es: {circ.Add10()}");

int prev = 0, next = 1, sum;
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum; 
}

try
{
    Console.WriteLine("Número a dividir: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Divisor: ");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }
    Console.WriteLine($"Resultado: {n / divisor}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por cero!");
}
catch (Exception)
{
    Console.WriteLine("Error desconocido");
}

/*abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();
}*/

interface IExtraCalculatios
{
    public double Add10();
}

interface IFigura
{
    public double Area();
    public double Perimetro();
}

class Circulo : IFigura, IExtraCalculatios
{
    public double Radio { get; set; }
    public double Area() => Math.PI * Radio * Radio;
    public double Perimetro() => 2 * Math.PI * Radio;

    public double Add10()
    {
        return Radio * 10;
    }
}
