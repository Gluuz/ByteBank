namespace Byte_Bank.Funcionarios
{
    public class Diretor : Funcionario
    {
       public Diretor(double salario, string cpf) : base(5000, cpf)
       {

       }
        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}