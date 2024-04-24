// ./ContaPoupança.cs

public class ContaPoupança : IContaBancaria{
    public int NumeroConta {get;set;}
    public decimal Saldo {get;set;}

    public void Depoistar(decimal Valor){
        Console.WriteLine("Deposito feito na Conta Poupança.");
    }

    public void Sacar(decimal Valor) {
        Console.WriteLine("Saque feito na Conta Poupança.");
    }
}