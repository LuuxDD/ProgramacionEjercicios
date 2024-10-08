﻿
using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Enums;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        //Llamamos al metodo PedirNombreYSaludar, permite ejecurarse 
        //PedirNombreYSaludar();
        //CalcularDíasDevida();
        //ImprimirMinimode4();
        //Triangulos();
        //FechaValidaInvalida();
        //PruebaDeObjetoSplit();
        //PruebaDeObjetoPersona();
        //PavaElectrica();
        //ClasesAbtractasYHerencias();
        PruebaDeCalculadoraPasajePorReferencia();

    }

    private static void PruebaDeCalculadoraPasajePorReferencia()
    {
        int a = 5;
        int b = 10;
        int total = 0;

        Calculadora calculadora = new Calculadora();
        calculadora.Sumar(a, b, ref total);
        Console.WriteLine($"El resultado de la suma es: {total}");

    }

    private static void ClasesAbtractasYHerencias()
    {
        Gerente gerente = new Gerente("Juan", "Perez", 123456);
        Console.WriteLine(gerente.ImprimirDatos());
    }

    private static void PavaElectrica()
    {
       PavaElectrica miPava = new PavaElectrica("Philips", "Acero", 1);
        miPava.Encender();
        miPava.CambiarModo(ModoEnums.TemperaturaMate);
        Console.WriteLine($"La pava esta en modo {miPava.Modo} y a {miPava.Temperatura} grados");
        miPava.CambiarModo(ModoEnums.TemperaturaTe);
        Console.WriteLine($"La pava esta en modo {miPava.Modo} y a {miPava.Temperatura} grados");
        miPava.CambiarModo(ModoEnums.TemperaturaCafe);
        Console.WriteLine($"La pava esta en modo {miPava.Modo} y a {miPava.Temperatura} grados");
    }

    private static void PruebaDeObjetoPersona()
    {
        Persona albert = new Persona("Albert Einstein", "9 de julio 1111", 1879);
        Persona robert = new Persona("Robert Oppenheider", "Manhattan 2222", 1904);
        albert.Decir("La imaginación es más importante que el conocimiento");
        robert.Decir("No se que armas se usarán en la tercera guerra mundial, pero en la cuarta se usarán palos y piedras");

    }

    private static void PruebaDeObjetoSplit()
    {
        //Creamos un objeto de la clase "Instaciamos el objeto"
        Split miSplit = new Split("Blanco","Samsung",3000);
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.Encender();
        miSplit.CambiarModo("Dry");
        miSplit.SubirTemperatura();
    }

    //Realizar un metodo que pida una fecha y determine si es valida o no. Que tenga en cuenta los años bisiestos, los meses con 30 y 31 dias
    private static void FechaValidaInvalida()
    {
        // Declaramos las variables

        int dia, mes, año;

        //Pedimos la fecha al usuario

        Console.Write("Ingrese el día: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año: ");
        año = int.Parse(Console.ReadLine());

        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            Console.WriteLine("Fecha Valida");

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            Console.WriteLine("Fecha Valida ");

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            Console.WriteLine("Fecha Valida ");
        else
            Console.WriteLine("Fecha Invalida");

    }

    //Realizar un metodo que pida los lados de un triangulo y determine si es un triangulo equilatero, isosceles o escaleno
    private static void Triangulos()
    {
        //Declaramos las variables
        int lado1, lado2, lado3;

        //Pedimos los lados al usuario
        Console.Write("Ingrese el primer lado: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        lado3 = int.Parse(Console.ReadLine());

        //Comparamos los lados para saber que tipo de triangulo es

        if (lado1 == lado2 && lado1 == lado3)
        {
            Console.WriteLine("Es un triangulo equilatero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("Es un triangulo isosceles");
        }
        else
        {
            Console.WriteLine("Es un triangulo escaleno");
        }
    }

    /// <summary>
    /// Algoritmo que Imprime un minimode 4
    /// </summary>
    private static void ImprimirMinimode4()
    {
        //declaramos las variables
        int num1, num2, num3, num4;

        //Pedimos los numeros al usuario
        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        num4 = int.Parse(Console.ReadLine());

        //Compraramos los numeros para saber cual es el menor

        if ( num1 < num2 && num1 < num3 && num1 < num4)
        {
            Console.WriteLine($"El número menor es: {num1}");
        }
        else if (num2 < num1 && num2 < num3 && num2 < num4)
        {
            Console.WriteLine($"El número menor es: {num2}");
        }
        else if (num3 < num1 && num3 < num2 && num3 < num4)
        {
            Console.WriteLine($"El número menor es: {num3}");
        }
        else
        {
            Console.WriteLine($"El número menor es: {num4}");
        }

    }

    // Creamos un metodo que pida el nombre del usuario y posteriormente lo salude con "Bienvenido [Apellido], [Nombre]


    private static void PedirNombreYSaludar()
    {
        // Declaración de variables 
        /* Comentar varias lineas */

        string nombre, apellido;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine(); //Lee lo que escribe el usuario 
        apellido = Console.ReadLine();
        Console.WriteLine("Hola Bienvenido ");
        Console.WriteLine($"Hola Bienvenido{apellido}, {nombre}");
    }

    //Crear un metodo que nos pida los años, meses y dias de vida y muestr el final la cantidad total de los dias de vida 

    private static void CalcularDíasDevida()

    {
        // Declaramos la variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida: ");
        años=int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida: ");
        meses=int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus días de vida: ");
        dias=int.Parse(Console.ReadLine());

        diasDeVida=(años * 365) + (meses * 30 ) + dias;
        Console.WriteLine($"Los días de vida totales son: {diasDeVida}");

    }

}
