using System;
using Byte_Bank.Funcionarios;
using Byte_Bank.SistemaInterno;
namespace Byte_Bank
{
  class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.ReadLine();
            
            
        }

        private static void UsarSistema()
        {
            Sistema sistemaInterno = new Sistema();
            Diretor roberta = new Diretor(5000, "4");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha= "321";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "321");
            sistemaInterno.Logar(parceiro, "123");
            sistemaInterno.Logar(parceiro, "321");
            

            
        }
    }
}
