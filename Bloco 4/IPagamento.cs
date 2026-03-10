using System;

namespace bloco4
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