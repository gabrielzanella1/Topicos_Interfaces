// ./Transacao.cs

public class Transacao : IContaBancaria{
    public string Tipo{get;set;}
    public decimal Valor {get;set;}

    public void ExebirDetalhes(){
        return "";
    }
}