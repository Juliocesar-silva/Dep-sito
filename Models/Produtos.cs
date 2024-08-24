using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Depósito.Models
{
    public class Produtos
    {
        public Produtos(string nome,double valor,int quantidade){
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }
        private string _nomeproduto;
        private double _valorproduto;
        private int _quantidadeproduto;

        public string Nome {
             get => _nomeproduto;
             set{
                if(value == ""){
                    throw new ArgumentException("O nome do produto não pode ser vazio!");
                }
                _nomeproduto = value;
             }
        }
        public int Quantidade {
             get => _quantidadeproduto;
             set{
                if(value <= 0){
                    throw new ArgumentException("A quantidade não pode ser nula ou zerada!");
                }
                _quantidadeproduto = value;
             }
        }
        public double Valor {
             get => _valorproduto;
             set{
                if(value < 0){
                    throw new ArgumentException("O valor não pode ser negativo!");
                }
                _valorproduto = value;
             } 
        }
    
    }
}