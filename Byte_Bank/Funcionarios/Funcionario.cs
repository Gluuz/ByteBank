namespace Byte_Bank.Funcionarios
{
    public abstract class Funcionario
    {
     
        public static int TotalDeFuncionarios {get; private set;}
       
         public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Salario = salario;
            CPF = cpf;
        }
        public string Nome { get; set; }
        public string CPF { get; private set; }


        public double Salario { get; protected set; }

        public abstract void  AumentaSalario();
       
        public abstract double GetBonificacao();
        
    }
}