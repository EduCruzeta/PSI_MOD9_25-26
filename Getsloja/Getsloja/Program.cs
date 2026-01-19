using Getsloja;


loja loja1 = new loja("decatlhon", "biseu");
Produto Produtos1 = new Produto("Bola de tenis", 5.99, 40);

Console.WriteLine("==Dados Loja==");
Console.WriteLine(loja1.MostrarDados());
Console.WriteLine("==Dados Stock==");
Console.WriteLine(Produtos1.MostrarDados());
Console.WriteLine($"Valor com desconto:{Produtos1.AplicarDesconto(10):F2}"); //Desconto de 10%