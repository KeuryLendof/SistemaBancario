using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Fachada
    {
        private CuentasDeAhorro DeAhorro;
        private SuperAhorro DeSuperAhorro;
        private Prestamos presta;
        private CertificadosFinancieros certificados;


        public void OperacionesCuentasAhorro()
        {
            DeAhorro = new CuentasDeAhorro();
            DeSuperAhorro = new SuperAhorro();

            Console.WriteLine("Seleccione su tipo de cuenta : ");
            Console.WriteLine("[1]Cuenta de Ahorro");
            Console.WriteLine("[2]Cuenta Super Ahorro: ");

            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                DeAhorro.Consulta();
            }
            else
            {
                DeSuperAhorro.Consulta();
            }
        }

        public void OperacionesPrestamos()
        {
            presta = new Prestamos();

            presta.PagarPrestamo();
        }

        public void OperacionesCertificados()
        {
            certificados = new CertificadosFinancieros();

            certificados.ConsultaDeInteres();
            
        }
    }
}
