using System;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Impresión de los 10 primeros numeros primos");
                Console.WriteLine("[6] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[7] Convertir de farenheit a celcius o viceversa");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", f, g, Multiplicar(f, g));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", h, i, Division(h, i));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("¿Desea convertir a Farenheit o a Celcius?");
                        Console.WriteLine("[1] De Farenheit a Celcius");
                        Console.WriteLine("[2] De Celcius a Farenheit");
                        Console.WriteLine("Ingrese una opción y presione ENTER");
                        option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                Console.WriteLine("Ingrese el valor en Farenheit");
                                int farenheit = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("La conversión de {0} Farenheit a Celcius es de: {1} Celcius", farenheit, FareheitACelcius(farenheit));
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.WriteLine("Ingrese el valor en Celcius");
                                int celcius = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("La conversión de {0} Celcius a Farenheit es de: {1} Farenheit", celcius, FareheitACelcius(celcius));
                                Console.ReadKey();
                                break;
                        }
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b) 
        {
            return a + b;
        }

        //Función para calcular la resta de 2 números enteros
        static int Resta(int c, int d)
        {
            return c - d;
        }

        //Función para calcular la multiplicación de 2 números enteros
        static int Multiplicar(int f, int g)
        {
            return f * g;
        }

        //Función para calcular la multiplicación de 2 números enteros
        static int Division(int h, int i)
        {
            return h / i;
        }

        //Función para convertir de Fareheit a Celcius
        static int FareheitACelcius(int farenheit)
        {
            return (5*(farenheit-32))/9;
        }

        //Función para convertir de Celcius a Fareheit
        static int CelciusAFarenheit(int celcius)
        {
            return ((9*celcius)/5)+32;
        }

        //Función para calcular los 10 primeros numeros primos
        static void Primos()
        {
            int n = 2;
            int total = 1;
            while (total <= 10)
            {
                Boolean esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }

                n++;
            }
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
    }
}
