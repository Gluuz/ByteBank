namespace Byte_Bank.Funcionarios
{
    public class Designer : Funcionario
    {
         public Designer(double salario, string cpf) : base(3000, cpf)
       {

       }
        public override void AumentaSalario()
        {
            Salario *= 1.11;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}