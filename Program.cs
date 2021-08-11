using System;
using Taller_POO.Clientes;
using Taller_POO.Productos;
using ModuloC;


namespace taller_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;

            var Modulo1 = new ModuloClientes();

        
            Boolean iniciar = true;

            while (iniciar)
            {
               switch (respuesta)
                {
                    case 1:
                   
                     break;

                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                       
                        break;
                     case 5:
                        
                        break;
                    case 6:
                        Console.WriteLine("Gracias por usar este programa, adiós. :^)");
                        iniciar = false;
                        break;
                }

                if (iniciar)
                {
                    Console.WriteLine("-------------------- Bienvenido al programa: ###### -----------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Ingresar al módulo de clientes.");
                    Console.WriteLine("2: Ingresar al módulo de productos.");
                    Console.WriteLine("3: Ingresar al módulo de ventas.");
                    Console.WriteLine("4: Ingresar al módulo de reportes.");
                    Console.WriteLine("5: Configurar el sistema.");
                    Console.WriteLine("6: salir del programa. ");
                    
                    respuesta = int.Parse(Console.ReadLine());
                }

            }
        }
}
}