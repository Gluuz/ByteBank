using Byte_Bank;

public class ContaCorrente
{
    public Cliente titular;
    public int agencia;
    public int numero;
    private double saldo = 100;

    
    public void DefinirSaldo(double valor)
    {
        if(valor <= 0){
            return;
        }
        else
        {
            this.saldo = valor;
        }
    }
    public double ObterSaldo()
    {
        return saldo;
    }
    
    public bool Sacar(double valor)
    {
        if(this.saldo <= valor){
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    
    }
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}