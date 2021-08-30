using Byte_Bank.SistemaInterno;

namespace Byte_Bank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha {get; set;}
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}