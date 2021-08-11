using System;
using System.Collections.Generic;
using System.Linq;
using Taller_POO.Clientes;
using Taller_POO.Productos;
using taller_POO;

namespace ModuloP

{

  public class ModuloProductos
  {
    public static void ModuloProducto (List <Productos> ListaProductos)
    {
        int respuesta = 0;
    
        Boolean iniciar = true;

            while (iniciar)
            {

               switch (respuesta)
                {
                    case 1:
                    
                       //ProductoService.Agregar(ListaProductos);
                    break;

                    case 2:
                       //ProductoService.Buscar(ListaProductos); 
                    break;

                    case 3:
                        //ProductoService.Editar(ListaProductos);
                    break;

                    case 4:
                        //ProductoService.Eliminar(ListaProductos);
                    break;

                    case 5:
                        Console.WriteLine("Gracias por ingresar a este módulo, adiós. :^)");
                        iniciar = false;
                        break;
                }

                if (iniciar)
                {
                    Console.WriteLine("-------------------- Bienvenido al módulo de productos. -----------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Agregar producto.");
                    Console.WriteLine("2: Buscar producto.");
                    Console.WriteLine("3: Editar producto.");
                    Console.WriteLine("4: Eliminar producto.");
                    Console.WriteLine("6: Salir de este módulo. ");
                    
                    respuesta = int.Parse(Console.ReadLine());
                }

            }
    }
  }
}