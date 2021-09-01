using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class SuperAhorro
    {

        //public static int NumCuenta;
        //public static double Balance;
        //public static double Deposito;
        //public static double Retiro;

        private static List<Variables> VarList = new List<Variables>();
        Variables Var = new Variables();
        int Num;

        public void SAhorro()
        {
            Console.WriteLine("Accediste a una cuenta Super Ahorro");

        }

        public void Apertura()
        {
            Random r = new Random();
            Var.SNumCuenta = r.Next(1000000, 100000000);

            Console.WriteLine("Su numero de cuenta es {0}", Var.SNumCuenta);
            Console.WriteLine("Indroduzca su monto de apertura, Su monto de apertura debe ser mayor a 500RD$!:");
            Var.SBalance = double.Parse(Console.ReadLine());

            VarList.Add(Var);
        }

        public void Depositos()
        {
            Console.WriteLine("Indroduzca el numero de cuenta al cual le desea depositar: ");
            Num = int.Parse(Console.ReadLine());

            if (Var.SNumCuenta == Num)
            {
                Console.WriteLine("Indroduzca la cantidad de dinero que desea depositar: ");
                Var.SDeposito = double.Parse(Console.ReadLine());
                double Resultado = Var.SBalance + Var.SDeposito;
                Var.SBalance = Resultado;
                Console.WriteLine("Deposito exitoso!");
                Console.WriteLine("Su balance es: " + Resultado);
            }
            else
            {
                Console.WriteLine("Este numero de cuenta no existe");
            }
            VarList.Add(Var);

        }

        public void Retiros()
        {
            Console.WriteLine("Indroduzca el numero de cuenta al cual le desea Retirar: ");
            Num = int.Parse(Console.ReadLine());

            if (Var.SNumCuenta == Num)
            {
                Console.WriteLine("Indroduzca la cantidad de dinero que desea Retirar: ");
                Var.SRetiro = double.Parse(Console.ReadLine());
                //Console.WriteLine("Su balance es: " + (Balance = (Balance - Retiro)));
                ValidarRetiros();

            }
            else
            {
                Console.WriteLine("Este numero de cuenta no existe");
            }


        }

        public void Consulta()
        {
            Console.WriteLine("Indroduzca el numero de cuenta al cual Consultar: ");
            Num = int.Parse(Console.ReadLine());

            foreach(Variables Var in VarList)
            {
                if (Var.SNumCuenta == Num)
                {
                    Console.WriteLine("Su balance es de {0}RD$ ", Var.SBalance);

                }
                else
                {
                    Console.WriteLine("Este numero de cuenta no existe");
                }
            }

           

        }

        public void ValidarRetiros()
        {
            //Console.WriteLine("Introduzca el monto que desea retirar: ");
            //Retiro = double.Parse(Console.ReadLine());

            double Calculo = Var.SBalance * 0.40;

            if(Var.SRetiro <= Calculo)
            {
                Console.WriteLine("Retiro Exitoso!!!");
                Console.WriteLine("Su balance es: " + (Var.SBalance = (Var.SBalance - Var.SRetiro)));

                //VarList.Add(Var);
            }
            else
            {
                Console.WriteLine("Retiro Fallido!!!");
                Console.WriteLine("Esta retirando mas del 40% de su balance actual");
            }
        }
    }
}
