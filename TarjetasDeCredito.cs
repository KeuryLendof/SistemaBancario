using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class TarjetasDeCredito
    {
        //public static int NumTarjeta;
        //public static double Limite;
        //public static double Pago;
        //public static double Consumo;

        private static List<Variables> VarList = new List<Variables>();
        Variables Var = new Variables();


        public void Expedicion()
        {
            Random r = new Random();
            Var.NumTarjeta = r.Next(1000000, 100000000);

            Console.WriteLine("La numeracion de su tarjeta es {0}", Var.NumTarjeta);

            if(Var.NumTarjeta > 15000000)
            {
                Var.Limite = 50000;
            }
            if (Var.NumTarjeta < 15000000)
            {
                Var.Limite = 20000;
            }
            VarList.Add(Var);
            Console.WriteLine($"El limite de su tarjeta es : {Var.Limite}");

        }
        public void Consumos()
        {
            foreach(Variables Var in VarList)
            {
                Console.WriteLine("Indroduzca la cantidad que le desea Consumir a su Tarjeta");
                Var.Consumo = double.Parse(Console.ReadLine());
                Console.WriteLine($"Ha consumido {Var.Consumo} de su tarjeta");
                double Resultado = (Var.Limite - Var.Consumo);
                Var.Limite = Resultado;
                Console.WriteLine($"Asu Tarjeta le quedan {Resultado} para consumirse completamente");
            }
            
            VarList.Add(Var);
        }
        public void Pagos()
        {
            Console.WriteLine("Indroduzca la cantidad que le desea abonar a su Tarjeta");
            Var.PagoTgt = double.Parse(Console.ReadLine());
            Console.WriteLine($"Usted ha pagado {Var.PagoTgt} a su tarjeta ");
            double Resultado = (Var.PagoTgt + Var.Limite);
            Var.Limite = Resultado;
            Console.WriteLine($"Su tarjeta tiene {Resultado}");

            VarList.Add(Var);
        }
    }
}
