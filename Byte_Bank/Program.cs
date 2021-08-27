using System;

namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            Cliente João = new Cliente();
            João.Nome= "João";
            João.Profissao= "Desenvolvedor";
            João.CPF= "6666666666";

            ContaCorrente ContaJoão = new ContaCorrente();
            ContaJoão.Titular= João;
            ContaJoão.numero= 666;
            ContaJoão.agencia= 0100;
            ContaJoão.Saldo = -120;

            
            
            Console.WriteLine(ContaJoão.Saldo);
            
            Console.ReadLine();
        }
    }
}
