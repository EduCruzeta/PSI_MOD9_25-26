using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getsloja
{
    public class Produto
    {
        public string Nome {  get; set; }
        public double Preco { get; set; }
        public int Stock { get; set; }

        public Produto(string nome, double preco, int stock)
        {
            Nome = nome;
            Preco = preco;
            Stock = stock; 
        }
        public double CalcularValorTotalStock()
        {
            return Stock * Preco;
        }
        public double AplicarDesconto(double percentagem)
        {
            return Preco * (1 - percentagem / 100);
        }
        public string MostrarDados() 
        {
            return $"Nome:{Nome}\nPreço:{Preco}\nQuantidade:{Stock}\nValor total em stock:{CalcularValorTotalStock():F2}";
        }


    }
}
