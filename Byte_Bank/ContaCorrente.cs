using Byte_Bank;
using System;

public class ContaCorrente
{
    public Cliente Titular {get; set;}

    public static int TotalDeContasCriadas {get; private set;}
    public int Agencia {get;}
 
    public int Numero {get;}
    private double _saldo = 100;

    
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set{
            if(value <= 0)
            {
                return;
            }
            else{
                _saldo = value;
            }
        }   
    }

    public ContaCorrente(int numeroAgencia, int numeroConta)
    {
        if(numeroAgencia <= 0)
        {
            throw new ArgumentException("O argumento Agencia deve ser maior que 0", nameof(numeroAgencia));
        }
        if(numeroConta <= 0)
        {
            throw new ArgumentException("O argumento Numero deve ser maior que 0", nameof(numeroConta));
        }

        Agencia = numeroAgencia;
        Numero = numeroConta;

        TotalDeContasCriadas++;
    }
    public void Sacar(double valor)
    {
        if(valor < 0)
        {
            throw new ArgumentException("Valor inválido para o Saque", nameof(valor));
        }
        
        if(this._saldo <= valor){
            throw new SaldoInsuficienteException(Saldo, valor);
        }
        this._saldo -= valor;
        
    }
    public void Depositar(double valor)
    {
        this._saldo += valor;
    }
    public void Transferir(double valor, ContaCorrente contaDestino)
    {
        if(valor < 0)
        {
            throw new ArgumentException("Valor inválido para a Transferencia", nameof(valor));
        }
        Sacar(valor);
        contaDestino.Depositar(valor);
            
        }
    }