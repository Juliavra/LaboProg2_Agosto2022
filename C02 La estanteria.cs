using System;
using Biblioteca;

namespace ejercicio_C02
{
        class Program
    {
        public static void Main()
        {
            
            Producto Pro1 = new Producto("uopapa", "123", 666);
        //    Pro1._codigoDeBarras="2266577";
        //    Pro1._marca="Halo";
         //   Pro1._precio=999;             
   
            Console.WriteLine(Producto.MostrarProducto(Pro1));
        }
    }
}
