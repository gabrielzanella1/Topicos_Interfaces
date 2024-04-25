// ./Transacao.cs

public class Transacao
{
    public string Tipo { get; set; }
    public decimal Valor { get; set; }

    public Transacao(string Tipo, decimal Valor, IContaBancaria conta)
    {
        if (Tipo == "Sacar")
        {
            conta.Sacar(Valor);
        }
        else if (Tipo == "Depositar")
        {
            conta.Depositar(Valor);
        }
    }
}