namespace Byte_Bank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
         public Desenvolvedor(double salario, string cpf) : base(3500, cpf)
       {

       }
        public override void AumentaSalario()
        {
            Salario *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.80;
        }
    }
}