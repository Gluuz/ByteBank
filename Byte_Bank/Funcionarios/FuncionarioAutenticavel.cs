using Byte_Bank.SistemaInterno;

namespace Byte_Bank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha{get; set;}
        
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}