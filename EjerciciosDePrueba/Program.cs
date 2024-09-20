internal class Program
{
    private static void Main(string[] args)
    {
        //Llamamos al metodo PedirNombreYSaludar, permite ejecurarse 
        //PedirNombreYSaludar();
        CalcularDíasDevida();
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
