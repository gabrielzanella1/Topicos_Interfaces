// ./Transacao.cs

public class Transacao
{
    public string Tipo { get; set; }
    public decimal Valor { get; set; }

    public IContaBancaria conta;

    public Transacao(string Tipo, decimal Valor, IContaBancaria conta)
    {
        this.conta = conta;
        if (Tipo == "Sacar")
        {
            conta.Sacar(Valor);
        }
        else if (Tipo == "Depositar")
        {
            conta.Depositar(Valor);
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("----> Tipo de operação: " + Tipo + " efetuado na conta " + conta.getNumeroConta);
        Console.WriteLine("----> Saque no valor de " + Valor + " reais efetuado na conta " + conta.getNumeroConta);
    }
}