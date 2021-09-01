using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Menus
    {
        int opc;
        public void MenuPrincipal()
        {
            do
            {
                Console.WriteLine("Seleccione al apartado de su necesida: ");
                Console.WriteLine("[1] Cuentas de Ahorro");
                Console.WriteLine("[2] Prestamos");
                Console.WriteLine("[3] Tarjetas de Credito");
                Console.WriteLine("[4] Certificados Financieros ");
                Console.WriteLine("[5] Salir");

                opc = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        MenuAdapter();
                        break;
                    case 2:
                        MenuPrestamo();
                        break;
                    case 3:
                        MenuTarjetas();
                        break;
                    case 4:
                        MenuCertificado();
                        break;
                }
            } while (opc != 5);
            
        }



        public void MenuAdapter()
        {
            IAhorros ahorro;

            
            Console.WriteLine("Seleccione el tipo de cuenta que desea crear: ");
            Console.WriteLine("[1]Cuenta de Ahorro");
            Console.WriteLine("[2]Cuenta Super Ahorro: ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                ahorro = new CuentasDeAhorro();
            }
            else
            {
                ahorro = new Adapter();
            }

            do
            {
                Console.WriteLine("Que desea hacer :");
                Console.WriteLine("[1] Realizar una Apertura");
                Console.WriteLine("[2] Realizar un Deposito");
                Console.WriteLine("[3] Realizar un Retiro");
                Console.WriteLine("[4] Realizar una Consulta");
                Console.WriteLine("[5] Salir");

                opc = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        ahorro.Apertura();
                        break;
                    case 2:
                        ahorro.Depositos();
                        break;
                    case 3:
                        ahorro.Retiros();
                        break;
                    case 4:
                        ahorro.Consulta();
                        break;
                }
            } while (opc != 5);


        }

        public void MenuPrestamo()
        {
            Prestamos prestamos = new Prestamos();

            do
            {
                Console.WriteLine("Seleccione la opcion deseada: ");
                Console.WriteLine("[1] Solicitar Prestamo");
                Console.WriteLine("[2] Pagar Prestamo");
                Console.WriteLine("[3] Salir");

                opc = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        prestamos.Solicitud();
                        break;
                    case 2:
                        prestamos.PagarPrestamo();
                        break;
                }
            } while (opc != 3);
            
           
        }

        public void MenuTarjetas()
        {
            TarjetasDeCredito tarjetas = new TarjetasDeCredito();

            do
            {
                Console.WriteLine("Seleccione la opcion deseada: ");
                Console.WriteLine("[1] Expedicion");
                Console.WriteLine("[2] Consumos");
                Console.WriteLine("[3] Pagos");
                Console.WriteLine("[4] Salir");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        tarjetas.Expedicion();
                        break;
                    case 2:
                        tarjetas.Consumos();
                        break;
                    case 3:
                        tarjetas.Pagos();
                        break;
                }
            } while (opc != 4);
        }

        public void MenuCertificado()
        {
            CertificadosFinancieros certificados = new CertificadosFinancieros();

            do
            {
                Console.WriteLine("Seleccione la opcion deseada: ");
                Console.WriteLine("[1] Apertura");
                Console.WriteLine("[2] Consultas");
                Console.WriteLine("[3] Salir");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        certificados.Apertura();
                        break;
                    case 2:
                        certificados.ConsultaDeInteres();
                        break;
                }
            } while (opc != 3);
        }

        public void MenuFachada()
        {
            Fachada fachada = new Fachada();

            do
            {
                Console.WriteLine("Seleccione la opcion deseada: ");
                Console.WriteLine("[1] Consultar Cuenta");
                Console.WriteLine("[2] Pagar Prestamo");
                Console.WriteLine("[3] Certificado");
                Console.WriteLine("[4] Salir");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        fachada.OperacionesCuentasAhorro();
                        break;
                    case 2:
                        fachada.OperacionesPrestamos();
                        break;
                    case 3:
                        fachada.OperacionesCertificados();
                        break;
                }
            } while (opc != 4);
        }
    }
}
