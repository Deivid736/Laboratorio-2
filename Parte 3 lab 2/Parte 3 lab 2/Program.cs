using System;
class Program
{
    static void Main ()
    {
       // int num1, num2;
        Console.WriteLine("Ingrese dos numeros");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine($"{num1} es mayor que {num2}");
        else if (num1 < num2)
            Console.WriteLine($"{num1} es menor que {num2}");
        else
            Console.WriteLine($"{num1} es igual que {num2}");

        if (num1 > 0 && num2 > 0)
            Console.WriteLine("Los dos numeros son mayores que 0");
        else
            Console.WriteLine("Ninguno de los dos numeros son mayores a 0");
        if (num1 < 0 || num2 < 0)
            Console.WriteLine("Al menos uno de los dos numeros es menor que 0");
        else
            Console.WriteLine("Ninguno de lo dos numeros son menores que 0");



    }
}
