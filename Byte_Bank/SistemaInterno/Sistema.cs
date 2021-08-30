using System;
namespace Byte_Bank.SistemaInterno
{
    public class Sistema
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            
            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else{
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }    
    }
}