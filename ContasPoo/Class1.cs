using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPoo
{

    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca
        (int numero, string titular, double saldo, double taxaJuros)
        : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //Override do metodo Saque
        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}