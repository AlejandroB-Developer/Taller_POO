using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_POO.Clientes

{
    public class ClienteService
    {

    // --------------------------------- AGREGAR --------------------------
        public static void Agregar(List<Clientes> ListaClientes)
        {
            String cedula;
            String nombre;
            String direccion;
            String telefono;

            Console.WriteLine("------------ AGREGAR CLIENTE ----------");
            Console.WriteLine("Por favor, ingrese los siguientes datos: ");
            Console.WriteLine("Cédula: ");
            cedula = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Dirección: ");
            direccion = Console.ReadLine();
            Console.WriteLine("Teléfono: ");
            telefono = Console.ReadLine();

            var clientes = new Clientes(cedula, nombre, direccion, telefono);
            ListaClientes.Add(clientes);
            Console.WriteLine("¡Cliente agregado con éxito! :)");

        }

// --------------------------------- BUSCAR --------------------------
        public static void Buscar(List<Clientes> ListaClientes)
        {
            String cedula;
        
            Console.WriteLine("-------------- BUSCAR CLIENTE ------------");
            Console.WriteLine("Por favor, digite la cédula del cliente para continuar. ");
            cedula = Console.ReadLine();

            var clientes = ListaClientes.Where(c => c.cedula == cedula).FirstOrDefault();
            Console.WriteLine("Cliente consultado con éxito.");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
        }

// --------------------------------- EDITAR --------------------------

        public static void Editar(List<Clientes> ListaClientes)
        {
            String cedula;
            String nombre;
            String direccion;
            String telefono;
            
            Console.WriteLine("-------------- EDITAR CLIENTE ------------");
            Console.WriteLine("Por favor, ingrese la cédula del cliente para continuar. ");
            cedula = Console.ReadLine();

            var clientes = ListaClientes.Where(c => c.cedula == cedula).FirstOrDefault();
            Console.WriteLine("Datos del cliente que se editarán: ");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
           
            Console.WriteLine("Por favor, ingrese el nuevo nombre del cliente: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese la nueva dirección del cliente: ");
            direccion = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese el nuevo teléfono del cliente:");
            telefono = Console.ReadLine();

            clientes.nombre = nombre;
            clientes.direccion = direccion;
            clientes.telefono = telefono;
            
            Console.WriteLine("Cliente editado con éxito. Estos son los nuevos datos: ");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
           
        }

// --------------------------------- ELIMINAR --------------------------

        public static void Eliminar(List<Clientes> ListaClientes)
        {
            String cedula;
            Console.WriteLine("-------------- ELIMINAR CLIENTE ------------");
            Console.WriteLine("Por favor, digite la cédula del cliente para continuar");

            cedula = Console.ReadLine();

            var clientes = ListaClientes.Where(c => c.cedula == cedula).FirstOrDefault();
            Console.WriteLine("Datos que se borraron: ");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
            ListaClientes.Remove(clientes);
            Console.WriteLine("Cliente borrado exitosamente :)");
        }
    }
}