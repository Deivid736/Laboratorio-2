using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero entero");
        int numint = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero decimal");
        decimal numdeci = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el texto");
        string texto = (Console.ReadLine());
        Console.WriteLine("Ingrese un valor booleano");
        bool valorbool = bool.Parse(Console.ReadLine());


        Console.WriteLine("El valor del numero es:" + numint);
        Console.WriteLine("El valor de el numero decimal es: " + numdeci);
        Console.WriteLine("El texto es: " + texto);
        Console.WriteLine("El valor boleano es:" + valorbool);
    }
}