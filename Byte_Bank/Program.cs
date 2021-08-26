using System;

namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            Cliente João = new Cliente();
            João.nome= "João";
            João.profissao= "Desenvolvedor";
            João.cpf= "6666666666";

            ContaCorrente ContaJoão = new ContaCorrente();
            ContaJoão.titular= João;
            ContaJoão.numero= 666;
            ContaJoão.agencia= 0100;
            ContaJoão.saldo= 6450;

            Console.WriteLine(ContaJoão.titular.nome);
            Console.WriteLine(ContaJoão.numero);
            Console.WriteLine(ContaJoão.agencia);
            Console.WriteLine(ContaJoão.saldo);

            Console.ReadLine();
        }
    }
}
