using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestVeiculo
{
    public class Veiculo
    {
        public string Matricula {  get; set; }

        public int Ano { get; set; }

        public Propriatario Propriatario { get; set; }

        public Veiculo(string matricula, int ano, Propriatario propriatario)
        {
            Matricula = matricula;
            Ano = ano;
            Propriatario = propriatario;
        }

        public virtual string MostrarDados()
        {
            return $"Matrícula: {Matricula}\n Ano: {Ano}\n- Propriatário -\n{Propriatario.MostrarDados()}";
        }
    }
}
