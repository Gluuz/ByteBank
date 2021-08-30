using System;
using Byte_Bank.Funcionarios;
namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            Funcionario Bruno = new Funcionario("468548545");
            Bruno.Nome = "Bruno";
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            
            
            Funcionario Roberta = new Diretor("471568765");
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.ReadLine();
        }
    }
}
