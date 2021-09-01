using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class CuentasDeAhorro : IAhorros
    {

        //public static int NumCuenta;
        //public static double Balance;
        //public static double Deposito;
        //public static double Retiro;

        private static List<Variables> VarList = new List<Variables>();
        Variables Var = new Variables();

        int Num;

        public void Apertura()
        {
            Random r = new Random();
            Var.NumCuenta = r.Next(1000000, 100000000);
            
            Console.WriteLine("Su numero de cuenta es {0}", Var.NumCuenta);
            Console.WriteLine("Indroduzca su monto de apertura, Su monto de apertura debe ser mayor a 500RD$!:");
            Var.Balance = double.Parse(Console.ReadLine());

            VarList.Add(Var);
        }
        public void Depositos()
        {
            Console.WriteLine("Indroduzca el numero de cuenta al cual le desea depositar: ");
            Num = int.Parse(Console.ReadLine());

            foreach(Variables Var in VarList)
            {
                if (Var.NumCuenta == Num)
                {
                    Console.WriteLine("Indroduzca la cantidad de dinero que desea depositar: ");
                    Var.Deposito = double.Parse(Console.ReadLine());
                    double Resultado = Var.Balance + Var.Deposito;
                    Var.Balance = Resultado;
                    Console.WriteLine("Deposito exitoso");
                    Console.WriteLine("Su nuevo balance es: " + Resultado);
                }
                else
                {
                    Console.WriteLine("Este numero de cuenta no existe");
                }
            }
            
        }
        public void Retiros()
        {
            Console.WriteLine("Indroduzca el numero de cuenta al cual le desea Retirar: ");
            Num = int.Parse(Console.ReadLine());

            if (Var.NumCuenta == Num)
            {
                Console.WriteLine("Indroduzca la cantidad de dinero que desea Retirar: ");
                Var.Retiro = double.Parse(Console.ReadLine());
                Console.WriteLine("Su balance es: " + (Var.Balance = (Var.Balance - Var.Retiro)));

            }
            else
            {
                Console.WriteLine("Este numero de cuenta no existe");
            }
            VarList.Add(Var);
        }
        public void Consulta()
        {
            Console.WriteLine("Indroduzca el numero de cuenta al cual Consultar: ");
            Num = int.Parse(Console.ReadLine());

            foreach(Variables Var in VarList)
            {
                if (Var.NumCuenta == Num)
                {
                    Console.WriteLine("Su balance es de {0}RD$ ", Var.Balance);

                }
                else
                {
                    Console.WriteLine("Este numero de cuenta no existe");
                }
            }
            VarList.Add(Var);


        }
    }

}