using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
       

        Console.WriteLine("Ingrese el primer numero");
       int num1= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int num2 = int.Parse(Console.ReadLine());


        Console.WriteLine($"La suma de los numeros es:{ num1+num2}" );
        Console.WriteLine($"La resta de los numeros es:{num1 - num2}");
        Console.WriteLine($"La multiplicacion de los numeros es:{num1 * num2}");
        Console.WriteLine($"La division de los numeros es:{num1 / num2}");

        //Decimal
        Console.WriteLine("Ingrese el primer numero");
        decimal decimal1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        decimal decimal2 = decimal.Parse(Console.ReadLine());


        Console.WriteLine($"La suma de los numeros es:{decimal1 + decimal2}");
        Console.WriteLine($"La resta de los numeros es:{decimal1 - decimal2}");
        Console.WriteLine($"La multiplicacion de los numeros es:{decimal1 * decimal2}");
        Console.WriteLine($"La division de los numeros es:{decimal1 / decimal2}");

        //float
        Console.WriteLine("Ingrese el primer numero");
        float float1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        float float2 = float.Parse(Console.ReadLine());


        Console.WriteLine($"La suma de los numeros es:{float1 + float2}");
        Console.WriteLine($"La resta de los numeros es:{float1 - float2}");
        Console.WriteLine($"La multiplicacion de los numeros es:{float1 * float2}");
        Console.WriteLine($"La division de los numeros es:{float1 / float2}");

        //int16
        Console.WriteLine("Ingrese el primer numero");
        Int16 int161 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        Int16 int162 = Int16.Parse(Console.ReadLine());


        Console.WriteLine($"La suma de los numeros es:{int161 + int162}");
        Console.WriteLine($"La resta de los numeros es:{int161 - int162}");
        Console.WriteLine($"La multiplicacion de los numeros es:{int161 * int162}");
        Console.WriteLine($"La division de los numeros es:{int161 / int162}");

        //byte
        Console.WriteLine("Ingrese el primer numero");
        byte byte1 = byte.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        byte byte2 = byte.Parse(Console.ReadLine());


        Console.WriteLine($"La suma de los numeros es:{byte1 + byte2}");
        Console.WriteLine($"La resta de los numeros es:{byte1 - byte2}");
        Console.WriteLine($"La multiplicacion de los numeros es:{byte1 * byte2}");
        Console.WriteLine($"La division de los numeros es:{byte1 / byte2}");

    }
}