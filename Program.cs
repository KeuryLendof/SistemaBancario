using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Menus menu = new Menus();

            Console.WriteLine("********----------SISTEMA BANCARIO----------*************");

            Console.WriteLine("Desea entrar a la");
            Console.WriteLine("[1] Web");
            Console.WriteLine("[2] App Movil");
            int opc = int.Parse(Console.ReadLine());

            if(opc == 1)
            {
                menu.MenuPrincipal();
            }
            if(opc == 2)
            {
                menu.MenuFachada();
            }
            
            

            Main(args);

        }
    }
}
