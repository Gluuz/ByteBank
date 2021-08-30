using System;
using Byte_Bank.Funcionarios;
namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            Funcionario Bruno = new Auxiliar(2000, "468548545");
            Bruno.Nome = "Bruno";
            Bruno.AumentaSalario();
            Console.WriteLine(Bruno.Salario);
            
            
            Funcionario Roberta = new GerenteDeConta(4000, "471568765");
            Roberta.AumentaSalario();
            Console.WriteLine(Roberta.Salario);

            Funcionario Mauricio = new Designer(3000, "4568135186");
            Mauricio.AumentaSalario();
            Console.WriteLine(Mauricio.Salario);

            Funcionario Paulo = new Diretor(5000, "65445132874");
            Paulo.AumentaSalario();
            Console.WriteLine(Paulo.Salario);

            Console.ReadLine();
        }
    }
}
