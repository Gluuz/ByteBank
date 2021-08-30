using Byte_Bank.SistemaInterno;

namespace Byte_Bank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
         public GerenteDeConta(double salario, string cpf) : base(4000, cpf)
       {

       }
        public override void AumentaSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
