using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class CertificadosFinancieros
    {
        //double NumCertificado;
        //double MontoCert;
        //double Tiempo;
        //double Operacion;

        private static List<Variables> VarList = new List<Variables>();
        Variables Var = new Variables();

        public void Apertura()
        {
            Random r = new Random();
            Var.NumCertificado = r.Next(1000000, 100000000);

            Console.WriteLine("La numeracion de su certificado es {0}", Var.NumCertificado);

            Console.WriteLine("Ingrese el monto:");
            Var.MontoCert = double.Parse(Console.ReadLine());
            Console.WriteLine("Escoja el tiempo : [1]Un año [2]Dos años [3]Tres años [4]Cuatro años");
            Var.Tiempo = double.Parse(Console.ReadLine());

            VarList.Add(Var);

            if (Var.Tiempo == 1)
            {
                Console.WriteLine("Su tasa de interes sera de 8.00%");
                Var.Operacion = Var.MontoCert * 1.08;
                Var.MontoCert = Var.Operacion;
            }
            if (Var.Tiempo == 2)
            {
                Console.WriteLine("Su tasa de interes sera de 9.00%");
                Var.Operacion = Var.MontoCert * 1.09;
                Var.MontoCert = Var.Operacion;
            }
            if (Var.Tiempo == 3)
            {
                Console.WriteLine("Su tasa de interes sera de 11.00%");
                Var.Operacion = Var.MontoCert * 1.11;
                Var.MontoCert = Var.Operacion;
            }
            if (Var.Tiempo == 4)
            {
                Console.WriteLine("Su tasa de interes sera de 13.00%");
                Var.Operacion = Var.MontoCert * 1.13;
                Var.MontoCert = Var.Operacion;

            }
        }
        public void ConsultaDeInteres()
        {
            Console.WriteLine("Indroduzca el numero de su certificado: ");
            int opc = int.Parse(Console.ReadLine());

            foreach (Variables Var in VarList)
            {
                if (Var.NumCertificado == opc)
                {
                    Console.WriteLine("Su monto mas interes es de: " + Var.MontoCert);
                }
            }
           
            
            
            
        }
    }
}
