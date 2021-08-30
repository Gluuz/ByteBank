using Byte_Bank.Funcionarios;
using System;
namespace Byte_Bank.SistemaInterno
{
    public interface IAutenticavel
    {
      bool Autenticar(string senha);   
    }
        
}