using System;

namespace EXSC_
{
    interface IPagamento
    {
        void Pagar();
    }

    class Ex89
    {
        public void ProcessarPagamento(IPagamento pagamento)
        {
            pagamento.Pagar();
        }
    }
}