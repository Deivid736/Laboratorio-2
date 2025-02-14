# Laboratorio-2

¿Para qué crees que se usan los operadores lógicos en programación?
para tomar deciciones, validar cosas como contraseñas y usuarios tambien para hacer el codigo mas eficiente.

¿Por qué es importante declarar correctamente el tipo de dato de una variable?
Para evitar errores en el codigo y que funcione de manera correcta.



#Enunciados.

##Enunciado 1: Clasificacion de edad
Utilice if-else porque puede evaluar los rangos de edad 

```csharp
        Console.WriteLine("Ingrese la edad de la persona:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 12)
            Console.WriteLine("La categoria es niño");
        else if (edad >= 12 && edad <= 17) 
        Console.WriteLine("La categoria es adolesente");
        else if (edad >= 18 && edad <= 59) 
        Console.WriteLine("La categoria es adulto");
        else Console.WriteLine("La categoria es adulto mayor");
```
  
###Enunciado 2: Dia de la semana
Utilice switch, al ser un programa de selección y no de rango
es mas facil hacerlo de esta manera y evito hacer muchos else-if

```csharp
Console.WriteLine("Ingrese un número del 1 al 7:");
int numdias = Convert.ToInt32(Console.ReadLine());
string dia = "";

switch (numdias) 
{
    case 1: dia = "Lunes"; break;
    case 2: dia = "Martes"; break;
    case 3: dia = "Miércoles"; break;
    case 4: dia = "Jueves"; break;
    case 5: dia = "Viernes"; break;
    case 6: dia = "Sábado"; break;
    case 7: dia = "Domingo"; break;
    default: dia = "Número inválido"; break;
}

Console.WriteLine($"El día que corresponde al número es: {dia}");
```

####Enunciado 3: Verificacion de acceso
Utilice if-else porque se debe evaluar diferentes condiciones de autentificación

```csharp
        string usuario = "Deivid";
        string contra = "123";
        Console.WriteLine("Ingrese su usuario");
        string ingresario = Console.ReadLine();
        Console.WriteLine("Ingrese su contraseña");
        string ingseña = Console.ReadLine();

        if (ingresario == usuario)
        {
           
        if (ingseña == contra)
                
            {
                Console.WriteLine("Los datos son correctos");
             
            }
        else
            {
                Console.WriteLine("Contraseña incorrecta");

            }
            }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
```
