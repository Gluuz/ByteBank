namespace Byte_Bank.Funcionarios
{
    public class Funcionario
    {
     
        public static int TotalDeFuncionarios {get; private set;}
       
         public Funcionario(string cpf)
        {
            TotalDeFuncionarios++;
            CPF = cpf;
        }
        public string Nome { get; set; }
        public string CPF { get; private set; }


        public double Salario { get; set; }

        
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}