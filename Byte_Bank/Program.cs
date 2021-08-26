using System;

namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoJoao = new ContaCorrente();

            //ContaDoJoao.titular= "João";
            //ContaDoJoao.agencia= 100;
            ContaDoJoao.numero= 666;
            ContaDoJoao.saldo= 100;
            
            Console.WriteLine("Nome: " + ContaDoJoao.titular);
            Console.WriteLine("Agencia:" + ContaDoJoao.agencia);
            Console.WriteLine("Número:" + ContaDoJoao.numero);
            Console.WriteLine("Saldo:" + ContaDoJoao.saldo);

            ContaDoJoao.Sacar(20);
            Console.WriteLine(ContaDoJoao.saldo);

            Console.ReadLine();
        }
    }
}
