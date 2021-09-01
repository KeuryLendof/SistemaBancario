using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Adapter : IAhorros
    {

        SuperAhorro SpAhorro = new SuperAhorro();

        public void Apertura()
        {
            SpAhorro.SAhorro();
            SpAhorro.Apertura();
        }

        public void Consulta()
        {
            SpAhorro.Consulta();
        }

        public void Depositos()
        {
            SpAhorro.Depositos();
        }

        public void Retiros()
        {
            SpAhorro.Retiros();
        }
    }
}
