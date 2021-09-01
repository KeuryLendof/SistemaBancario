using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Prestamos
    {
        //int NumPrestamo;
        //double Monto;
        //int Tasa;
        //double Pago;

        private static List<Variables> VarList = new List<Variables>();
        Variables Var = new Variables();
        int opc;

        public void Solicitud()
        {
            Random r = new Random();
            Var.NumPrestamo = r.Next(1000000, 100000000);

            Console.WriteLine("Su numero de prestamo es {0}", Var.NumPrestamo);
            Console.WriteLine("Ingrese el monto de su prestamo:");
            Var.Monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa de su prestamo:");
            Var.Tasa = int.Parse(Console.ReadLine());

            VarList.Add(Var);

        }
        public void PagarPrestamo()
        {
            Console.WriteLine("Indroduzca el numero de su prestamo: ");
            opc = int.Parse(Console.ReadLine());

            foreach (Variables Var in VarList)
            {
                if (Var.NumPrestamo == opc)
                {
                    Console.WriteLine("Indroduzca la cantidad que le desea abonar a su prestamo");
                    Var.Pago = double.Parse(Console.ReadLine());
                    double Resultado = (Var.Monto - Var.Pago);
                    Var.Monto = Resultado;
                    Console.WriteLine($"Asu prestamo le quedan {Resultado} para ser completado");
                }
                else
                {
                    Console.WriteLine("Este numero de cuenta no existe");
                }
            }
            
        }
    }
}
