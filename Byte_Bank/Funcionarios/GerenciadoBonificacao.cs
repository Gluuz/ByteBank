namespace Byte_Bank.Funcionarios
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;


        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }


        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}