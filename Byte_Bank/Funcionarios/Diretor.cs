namespace Byte_Bank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}