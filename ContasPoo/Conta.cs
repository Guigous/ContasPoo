using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPoo
{
    class Conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Utilização do protected para alteração de valores entre classes
        public double Saldo { get; protected set; }
        //Criação do construtor padrão e construtor com parâmetros
       
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular.ToString(); 
            Saldo = saldo;
        }
        //Método Saque
        virtual public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //Método Deposito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;

        }
        
        }
    }

