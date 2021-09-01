using System;
using Byte_Bank.Funcionarios;
using Byte_Bank.SistemaInterno;
namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(15, 200);
                ContaCorrente conta2 = new ContaCorrente(15, 741);
                conta2.Transferir(-10, conta);
                conta.Saldo = 150;
                conta.Sacar(200);
            }
            catch (ArgumentException e)
            {
                
                Console.WriteLine(e.Message);  
            }
            
            Console.ReadLine();
            
            
        }
    }
}
