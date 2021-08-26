using System;

namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoJoao = new ContaCorrente();
            ContaCorrente ContaDaJoana = new ContaCorrente();

            ContaDoJoao.titular= "João";
            ContaDoJoao.agencia= 100;
            ContaDoJoao.numero= 666;
            ContaDoJoao.saldo= 100;
            
            ContaDaJoana.titular = "Joana";
            ContaDaJoana.agencia= 100;
            ContaDaJoana.numero = 777;
            ContaDaJoana.saldo = 250;

            Console.WriteLine("Saldo João:" + ContaDoJoao.saldo);
            Console.WriteLine("Saldo Joana:" + ContaDaJoana.saldo);

            ContaDaJoana.Transferir(100, ContaDoJoao);

            Console.WriteLine("Saldo João:" + ContaDoJoao.saldo);
            Console.WriteLine("Saldo Joana:" + ContaDaJoana.saldo);
            
            Console.ReadLine();
        }
    }
}
