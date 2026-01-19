using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getsloja
{
    public class loja
    {
        public string Nome { get; set; }
        public string Morada { get; set; }

        public loja(string nome, string morada)
        {
            Nome = nome;
            Morada = morada;
        }
        public string MostrarDados()
        {
            return "Nome:" + Nome + "\nMorada:" + Morada;
        }
    }
}
