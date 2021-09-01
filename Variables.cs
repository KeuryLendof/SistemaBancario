using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Variables
    {
        //Cuenta de ahorro
        public int NumCuenta { get; set; }
        public double Balance { get; set; }
        public double Deposito { get; set; }
        public double Retiro { get; set; }


        //Cuenta super ahorro
        public int SNumCuenta { get; set; }
        public double SBalance { get; set; }
        public double SDeposito { get; set; }
        public double SRetiro { get; set; }


        //Prestamos
        public int NumPrestamo { get; set; }
        public double Monto { get; set; }
        public int Tasa { get; set; }
        public double Pago { get; set; }


        //Tarjeta de credito
        public int NumTarjeta { get; set; }
        public double Limite { get; set; }
        public double PagoTgt { get; set; }
        public double Consumo { get; set; }


        //Certificado
        public double NumCertificado { get; set; }
        public double MontoCert { get; set; }
        public double Tiempo { get; set; }
        public double Operacion { get; set; }

    }
}
