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
                conta.Saldo = 150;
                conta.Sacar(200);
            }
            catch (SaldoInsuficienteException e)
            {
                
                Console.WriteLine(e.Message);  
            }
            
            Console.ReadLine();
            
            
        }
    }
}
