using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_veiculos
{
    internal class Motor
    {
        public string Marca { get; set; }

        public int Potencia { get; set; }

        public string Combustivel { get; set; }


        public Motor(string marca, int potencia,string combustivel)
        {
            Marca = marca;
            Potencia = potencia;
            Combustivel = combustivel;
        }

        public string MostrarDados() 
        { 
            return $"Marca:{Marca} Potencia:{Potencia} Combustivel: {Combustivel}";
        }
        
        
    }
}
