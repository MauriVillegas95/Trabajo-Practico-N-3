using System;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {
        int eleccion = 0;
        int[][] vuelo = new int[10][];
        bool vueloCreado = false;

        Console.Clear();
        Console.WriteLine("Bienvenida a Aerolineas Fly");
        Thread.Sleep(1500);

        do
        {
            Console.Clear();
            Menu();
            Console.Write("\nOpción elegida: ");
            eleccion = int.Parse(Console.ReadLine());

            if (eleccion <= 0 || eleccion >= 8)
            {
                Console.WriteLine("\nOpción incorrecta, elija una opción válida.");
                Thread.Sleep(2000);
            }
            if (eleccion == 7)
            {
                break;
            }

            switch (eleccion)
                {
                    case 1:
                        if (vueloCreado == false)
                        {
                            CrearVuelo(vuelo);
                            vueloCreado = true;
                            Thread.Sleep(1000);
                            Console.WriteLine("\nSu vuelo se creó correctamente.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("El vuelo ya se encuentra creado.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                        }
                        break;                    
                    case 2:
                        if (vueloCreado == false)
                        {
                            Console.Clear();
                            Console.WriteLine("El vuelo aún no se encuentra creado.");
                            Console.WriteLine("Cree uno para poder avanzar.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                            break;                        
                        }
                        else
                        {
                            ReservarAsiento(vuelo);
                            break;
                        }
                    case 3:
                        if (vueloCreado == false)
                        {
                            Console.Clear();
                            Console.WriteLine("El vuelo aún no se encuentra creado.");
                            Console.WriteLine("Cree uno para poder avanzar.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            CancelarVuelo(vuelo);
                            break;
                        }
                    case 4:
                        if (vueloCreado == false)
                        {
                            Console.Clear();
                            Console.WriteLine("El vuelo aún no se encuentra creado.");
                            Console.WriteLine("Cree uno para poder avanzar.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            MostrarEstadoVuelo(vuelo);
                            break;
                        }
                    case 5:
                        if (vueloCreado == false)
                        {
                            Console.Clear();
                            Console.WriteLine("El vuelo aún no se encuentra creado.");
                            Console.WriteLine("Cree uno para poder avanzar.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            MostrarVuelo(vuelo);
                            break;
                        }
                    case 6:
                        if (vueloCreado == false)
                        {
                            Console.Clear();
                            Console.WriteLine("El vuelo aún no se encuentra creado.");
                            Console.WriteLine("Cree uno para poder avanzar.");
                            Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            BuscarVuelo(vuelo);
                            break;
                        }
                }
        }
        while (eleccion != 7);


        Console.WriteLine("\nSaliendo del sistema.");
        Console.WriteLine("Muchas gracias por elegir nuestra aerolinea.");
    }

    public static void Menu() //Funcion menu de opciones.
    {
        Console.WriteLine("Menu de opciones:");
        Console.WriteLine("1- Crear un vuelo.");
        Console.WriteLine("2- Reservar asiento.");
        Console.WriteLine("3- Cancelar reserva.");
        Console.WriteLine("4- Estado del vuelo.");
        Console.WriteLine("5- Asientos disponibles y ocupados.");
        Console.WriteLine("6- Buscar asiento.");
        Console.WriteLine("7- Salir.");
    }

    public static void CrearVuelo(int [][] vuelo) //Funcion para crear un vuelo con todas las filas y columnas en 0.
    {
        Console.Clear();
        Console.WriteLine("A continuación se va a mostrar el vuelo creado.\n");
        Thread.Sleep(750);
        for (int i = 0; i < vuelo.Length; i++)
        {
            vuelo[i] = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        for (int i = 0; i < vuelo.Length; i++)
        {
            if (i < 9)
            {
                Console.Write("Fila " + (i + 1) + ":  ");
            }
            else { Console.Write("Fila " + (i + 1) + ": "); }
            for (int j = 0; j < vuelo[i].Length; j++)
            {
                Console.Write(vuelo[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void MostrarVuelo(int[][] vuelo) //Funcion para mostrar la cantidad de asientos libres y ocupados en el vuelo.
    {
        int contadorOcupado = 0;
        int contadorLibre = 0;

        Console.Clear();
        for (int i = 0; i < vuelo.Length; i++)
        {
            for (int j = 0; j < vuelo[i].Length; j++)
            {
                if(vuelo[i][j] != 0)
                {
                    contadorOcupado++;
                }
                else
                {
                    contadorLibre++;
                }
            }
        }
        Console.WriteLine("La cantidad de asientos libres es de: " + contadorLibre);
        Console.WriteLine("La cantidad de asientos ocupados es de : " + contadorOcupado);
        Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
        Console.ReadLine();
    }

    static void MostrarEstadoVuelo(int[][] vuelo) //Funcion para mostrar vuelo en el estado actual.
    {
        Console.Clear();
        Console.WriteLine("El estado actual del vuelo es el siguiente: \n");
        for (int i = 0; i < vuelo.Length; i++)
        {
            if (i < 9)
            {
                Console.Write("Fila " + (i + 1) + ":  ");
            }
            else { Console.Write("Fila " + (i + 1) + ": "); }
            for (int j = 0; j < vuelo[i].Length; j++)
            {
                Console.Write(vuelo[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nPresione ENTER para volver al menú anterior.");
        Console.ReadLine ();
    }

    public static void ReservarAsiento(int[][] vuelo) //Funcion para reservar el vuelo.
    {
        int fila = 0;
        int asiento = 0;
        bool asientoElejido = false;

        do
        {
            do
            {
                Console.Clear();
                Console.Write("Seleccione la fila en la cual quiere sentarse: ");
                fila = int.Parse(Console.ReadLine());
                Console.Write("Seleccione el asiento en la cual quiere sentarse: ");
                asiento = int.Parse(Console.ReadLine());

                if (fila > 10 || fila <= 0 || asiento > 6 || asiento <= 0)
                {
                    asientoElejido = true;
                    Console.WriteLine("\nLa fila y el asiento seleccionados no son válidos.");
                    Console.WriteLine("\nSeleccione una fila y una asiento dentro del rango.");
                    Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
                    Console.ReadLine();
                    break;
                }

                for (int i = fila - 1; i < fila; i++)
                {
                    asientoElejido = false;
                    for (int j = asiento - 1; j < asiento; j++)
                    {
                        do
                        {
                            if (vuelo[i][j] == 1)
                            {
                                Console.WriteLine("\nEl asiento se encuentra ocupado, por favor, elija otro.");
                                Thread.Sleep(2000);
                                asientoElejido = true;
                                break;
                            }
                            else if(asientoElejido == false)
                            {
                                Console.WriteLine("\nSu asiento se encuentra disponible.");
                                Console.Write("\nReservando asiento");
                                Thread.Sleep(650);
                                Console.Write(".");
                                Thread.Sleep(650);
                                Console.Write(".");
                                Thread.Sleep(650);
                                Console.WriteLine(".");
                                Thread.Sleep(650);
                                Console.WriteLine("\nAsiento reservado.");
                                Thread.Sleep(750);
                                vuelo[i][j] = 1;
                                break;
                            }
                        }
                        while (vuelo[i][j] >= 0);
                    }
                }
            }
            while (fila > 10 || fila <= 0 || asiento > 6 || asiento <= 0);
        }
        while (asientoElejido == true);
        Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
        Console.ReadLine();
    }

    public static void BuscarVuelo(int[][] vuelo) //Funcion busqueda asiento en particular.
    {
        int filaBuscada = 0;
        int asientoBuscado = 0;

            do
            {
                Console.Clear();
                Console.Write("Seleccione la fila que quiere buscar: ");
                filaBuscada = int.Parse(Console.ReadLine());
                Console.Write("Seleccione el asiento que quiere buscar: ");
                asientoBuscado = int.Parse(Console.ReadLine());

                if (filaBuscada > 10 || filaBuscada <= 0 || asientoBuscado > 6 || asientoBuscado <= 0)
                {
                    Console.WriteLine("\nLa fila y el asiento seleccionados no son válidos.");
                    Console.WriteLine("\nSeleccione una fila y una asiento dentro del rango.");
                    Console.WriteLine("\nPresione ENTER para volver a ingresar.");
                    Console.ReadLine();
                }
            }
            while (filaBuscada > 10 || filaBuscada <= 0 || asientoBuscado > 6 || asientoBuscado <= 0);
        
            for (int i = filaBuscada - 1; i < filaBuscada; i++)
                {
                    for (int j = asientoBuscado - 1; j < asientoBuscado; j++)
                    {
                        if (vuelo[i][j] == 1)
                        {
                            Console.WriteLine("\nEl asiento buscado se encuentra ocupado.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else if (vuelo[i][j] == 0)
                        {
                            Console.WriteLine("\nEl asiento buscado se encuentra disponible.");
                            break;
                        }
                    }
                }
        Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
        Console.ReadLine();
    }

    public static void CancelarVuelo(int[][] vuelo) //Funcion para cancelar asiento.
    {
        int filaCancelar = 0;
        int asientoCancelar = 0;

        do
        {
            Console.Clear();
            Console.Write("Seleccione la fila que quiere cancelar: ");
            filaCancelar = int.Parse(Console.ReadLine());
            Console.Write("Seleccione el asiento que quiere calcelar: ");
            asientoCancelar = int.Parse(Console.ReadLine());

            if (filaCancelar > 10 || filaCancelar <= 0 || asientoCancelar > 6 || asientoCancelar <= 0)
            {
                Console.WriteLine("\nLa fila y el asiento seleccionados no son válidos.");
                Console.WriteLine("\nSeleccione una fila y una asiento dentro del rango.");
                Console.WriteLine("\nPresione ENTER para volver a ingresar.");
                Console.ReadLine();
            }
        }
        while (filaCancelar > 10 || filaCancelar <= 0 || asientoCancelar > 6 || asientoCancelar <= 0);

        for (int i = filaCancelar - 1; i < filaCancelar; i++)
        {
            for (int j = asientoCancelar - 1; j < asientoCancelar; j++)
            {
                if (vuelo[i][j] == 1)
                {
                    Console.WriteLine("\nEl asiento se canceló correctamente.");
                    vuelo[i][j] = 0;
                    Thread.Sleep(1000);
                    break;
                }
                else if (vuelo[i][j] == 0)
                {
                    Console.WriteLine("\nEl asiento buscado se encuentra disponible, no se puede cancelar.");
                    break;
                }
            }
        }
        Console.WriteLine("\nPresione ENTER para volver al menu anterior.");
        Console.ReadLine();
    }
}