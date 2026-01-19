using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestVeiculo
{
    public class Propriatario
    {
        public string Nome { get; set; }

        public string N_carta_conducao { get; set; }

        public int N_identificacao_fiscal { get; set; }

        public Propriatario(string nome,string n_carta_conducao,int n_identificacao_fiscal) 
        { 
            Nome = nome;
            N_carta_conducao = n_carta_conducao;
            N_identificacao_fiscal = n_identificacao_fiscal;
        }

        public virtual string MostrarDados()
            {
                return $"Nome:{Nome}\n NºCarta Condução: {N_carta_conducao}\n Nif: {N_identificacao_fiscal}";
            }
        
    }
}
