using Depósito.Models;

Produtos p1 = new Produtos(nome: "Madeira",valor: 195.4, quantidade: 18);
Produtos p2 = new Produtos(nome: "Prego",valor: 135, quantidade: 20);
Produtos p3 = new Produtos(nome: "Ferro",valor: 12.43, quantidade: 50);
Estoque estoque = new Estoque();
estoque.itens = new List<Produtos>();

estoque.AdicionarProdutos(p1);
Console.WriteLine($"Valor total do item {p1.Nome}: {estoque.produtovalorporitens(p1).ToString("C")}");
estoque.AdicionarProdutos(p2);
Console.WriteLine($"Valor total do item {p2.Nome}: {estoque.produtovalorporitens(p2).ToString("C")}\n");
estoque.AdicionarProdutos(p3);
estoque.ListarProdutos();