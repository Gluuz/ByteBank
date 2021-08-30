using System;
using Byte_Bank.Funcionarios;
namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            Funcionario Bruno = new Funcionario(2000, "468548545");
            Bruno.Nome = "Bruno";
            Bruno.AumentaSalario();
            Console.WriteLine(Bruno.Salario);
            
            
            Funcionario Roberta = new Diretor(5000, "471568765");
            Roberta.AumentaSalario();
            Console.WriteLine(Roberta.Salario);
            Console.ReadLine();
        }
    }
}
