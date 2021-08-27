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

            ContaCorrente ContaJoão = new ContaCorrente(666, 48548);
            ContaJoão.Titular= João;
            
            
           
            
            
            Console.WriteLine(ContaJoão.Numero);
            
            Console.ReadLine();
        }
    }
}
