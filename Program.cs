ContaCorrente conta1 = new ContaCorrente();
conta1.NumeroConta = 124131;
conta1.Saldo = 5000;

ContaPoupança conta2 = new ContaPoupança();
conta2.NumeroConta = 7187;
conta2.Saldo = 2500;


Transacao primeiraCorrente = new Transacao("Depositar", 500, conta1);
primeiraCorrente.ExibirDetalhes();
// Transacao segundaCorrente = new Transacao("Saque", 500, conta1);

// Transacao primeiraPoupanca = new Transacao("Sacar", 2000, conta2);
// Transacao segundaPoupanca = new Transacao("Depositar", 1, conta2);
// Transacao terceiraPoupanca = new Transacao("Sacar", 501, conta2);



