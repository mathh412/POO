// See https://aka.ms/new-console-template for more information
using sistama_bancario;

Person eu = new Person();
Banco banco = new Banco();
banco.CriarConta(eu);
eu.Dinheiro = 1000;
eu.Depositar(100, banco);
Console.WriteLine(eu.Dinheiro);
Console.WriteLine(banco.GetSaldo(eu));
eu.Sacar(50, banco);
Console.WriteLine(eu.Dinheiro);
Console.WriteLine(banco.GetSaldo(eu));

