using System;
using Byte_Bank.Funcionarios;
namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            Funcionario Bruno = new Funcionario();
            Bruno.Nome = "Bruno";
            Bruno.CPF = "600.590.432-02";
            Bruno.Salario = 600;
            
            Console.WriteLine(Bruno.Nome);
            Console.WriteLine(Bruno.CPF);
            Console.WriteLine(Bruno.Salario);
            
            Console.ReadLine();
        }
    }
}
