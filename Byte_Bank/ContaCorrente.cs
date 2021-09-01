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

    public ContaCorrente(int agencia, int numero)
    {
        if(agencia <= 0)
        {
            throw new ArgumentException("O argumento Agencia deve ser maior que 0");
        }
        if(numero <= 0)
        {
            throw new ArgumentException("O argumento Numero deve ser maior que 0");
        }

        Agencia = agencia;
        Numero = numero;

        TotalDeContasCriadas++;
    }
    public bool Sacar(double valor)
    {
        if(this._saldo <= valor){
            return false;
        }
        else
        {
            this._saldo -= valor;
            return true;
        }
    
    }
    public void Depositar(double valor)
    {
        this._saldo += valor;
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this._saldo < valor)
        {
            return false;
        }
        else
        {
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}