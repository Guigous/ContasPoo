using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPoo
{
    class ContaJuridica : Conta
    {
            //Declarações das variáveis e uso do encapsulamento
            public double EmprestimoLimite { get; set; }
            
            //Criação do construtor com parâmetros utilizando o da Classe Conta
            public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite)
            : base(numero, titular, saldo)
            {
                EmprestimoLimite = emprestimoLimite;
            }
            public void Emprestimo(double saldoTotal)
            {
                if (saldoTotal <= EmprestimoLimite)
                {
                    Saldo += saldoTotal;
                }
            }
        }
}
