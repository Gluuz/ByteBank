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
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu uma excessão do tipo ArgumentException");         
                Console.WriteLine(e.Message);  
            }
            
            Console.ReadLine();
            
            
        }
    }
}
