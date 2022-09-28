using pjEjercicioPruebaN;
using System.Security.Cryptography.X509Certificates;

namespace pjEjercicioPruebaN
{
    public class Recibo
    {

        public static void main(string[] args)
        {
            Empleado empleado;
            empleado = new Empleado();

            Console.WriteLine("Ingrese su nombre");
            Empleado nombre = new Empleado();
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas");
            int hTrabajadas;
            hTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite los años que lleva en la empresa");
           int antiguedad;
            antiguedad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Su total es: " + Empleado.Descuentos());
        }
    }
}
