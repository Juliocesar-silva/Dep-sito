using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Depósito.Models
{
    public class Estoque
    {
        public string NomeEstoque { get; set; }
        public List<Produtos> itens{ get; set; }

        public void AdicionarProdutos(Produtos produtos){
            itens.Add(produtos);
        }
        public void RemoverProdutos(Produtos produtos){
            itens.Remove(produtos);
        }
        public void ListarProdutos(){
            foreach(Produtos produto in itens){
                Console.WriteLine($"Nome do produto: {produto.Nome}");
                Console.WriteLine($"Valor do produto: {produto.Valor}");
                Console.WriteLine($"Quantidade do produto: {produto.Quantidade}\n");
            }
        }
         public double produtovalorporitens(Produtos produtos){
            double valortotal = produtos.Quantidade * produtos.Valor;
            return valortotal;
        }
        
    
        
    }
}