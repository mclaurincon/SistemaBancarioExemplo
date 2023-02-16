
using SistemaBancarioExemplo.SistemaBancario;

namespace SistemaBancarioExemplo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta teste";
            conta.Agencia = 0001;
            conta.NumeroConta = 1000;
            conta.SaldoConta= 1000;

            conta.Titular = new Titular()
            {
                CPF = "998877661212",
                RG = "9912345",
                Endereco = "Rua 01",
                Nome = "Jesus"
            };

           Console.WriteLine($"O saldo em conta é: {conta.VerSaldo()}");

            conta.Depositar(200);


            Console.WriteLine($"O saldo em conta é: {conta.VerSaldo()}");

            conta.Sacar(50);


            Console.WriteLine($"O saldo em conta é: {conta.VerSaldo()}");

            conta.Sacar(3000);

            Console.WriteLine($"O saldo em conta é: {conta.VerSaldo()}");


        }
    }
}