namespace Byte_Bank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
         public Auxiliar(double salario, string cpf) : base(2000, cpf)
       {

       }
        public override void AumentaSalario()
        {
            Salario *= 1.10;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}