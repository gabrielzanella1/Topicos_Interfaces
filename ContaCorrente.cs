// ./ContaCorrente.cs

public class ContaCorrente : IContaBancaria{
    public int NumeroConta {get;set;}
    public decimal Saldo {get;set;}

    public void Depositar(decimal Valor){
        Console.WriteLine("Deposito feito na Conta Corrente.");
    }

    public void Sacar(decimal Valor){   
        Console.WriteLine("Saque feito na Conta Corrente.");
    }
}