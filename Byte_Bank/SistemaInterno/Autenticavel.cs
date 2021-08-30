using Byte_Bank.Funcionarios;
using System;
namespace Byte_Bank.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha {get; set;}
        public Autenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}