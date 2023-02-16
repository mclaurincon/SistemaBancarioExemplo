using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancarioExemplo.SistemaBancario
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string? NomeConta { get; set; }
        public Titular? Titular { get; set; }

        public decimal SaldoConta { get; set; }

        public decimal VerSaldo()
        {
            return SaldoConta;
        }

        public void Depositar(decimal valor)
        {
            SaldoConta += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= SaldoConta)
                SaldoConta -= valor;
            else
                Console.WriteLine("Saldo Insuficiente");
        }
    }
}
