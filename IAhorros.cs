using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    interface IAhorros
    {
        void Apertura();
        void Depositos();
        void Retiros();
        void Consulta();
    }
}
