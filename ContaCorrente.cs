// ./ContaCorrente.cs

public class ContaCorrente : IContaBancaria
{
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }

    public void getNumeroConta()
    {
        Console.WriteLine(NumeroConta);
        return;
    }
    public void Depositar(decimal Valor)
    {
        Saldo += Valor;
        Console.WriteLine("Deposito no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
        Console.WriteLine("Deposito feito na Conta Corrente.");
        Console.WriteLine("O saldo resultante é: " + Saldo);
    }

    public void Sacar(decimal Valor)
    {
        if (Valor <= Saldo)
        {
            Saldo -= Valor;
            Console.WriteLine("Saque no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
            Console.WriteLine("Saque feito na Conta Corrente.");
            Console.WriteLine("O saldo resultante é: " + Saldo);

            return;
        }
        else
        {
            Console.WriteLine("Negado, seu Saldo é: " + Saldo);
            return;
        }
    }
}