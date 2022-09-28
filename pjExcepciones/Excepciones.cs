using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjExcepciones
{
    internal class Excepciones
    {
        public static void main(string[] args)
        {
            double precio, total;
            int cantidad;

            Console.WriteLine("Cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digita el precio: ");
            precio = Convert.ToDouble(Console.ReadLine());

            total = cantidad * precio;
        }
    }
}
