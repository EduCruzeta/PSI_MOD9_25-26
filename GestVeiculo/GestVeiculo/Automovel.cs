using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestVeiculo
{
    public class Automovel : Veiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string TipoCombustivel { get; set; }

        public double CapacidadeDeposito { get; set; }

        public double ConsumoMedio { get; set; }

        public Automovel(
            string matricula,
            int ano,
            Propriatario propriatario,
            string marca,
            string modelo,
            string tipoCombustivel,
            double capacidaddeDeposito,
            double consumoMedio) : base(matricula, ano, propriatario)
        {
            Marca = marca;
            Modelo = modelo;
            TipoCombustivel = tipoCombustivel;
            CapacidadeDeposito = capacidaddeDeposito;
            ConsumoMedio = consumoMedio;
        }

        // Método para calcular a autonomia

        public double CalcularAutonomia()
        {
            return (CapacidadeDeposito / ConsumoMedio) * 100;
        }

        public double CalcularCustoDeposito()
        {
            double precoPorLitro = 0;

            if (TipoCombustivel == "gasoluna 98")
            {
                precoPorLitro = 1.954;
            }
            else if (TipoCombustivel == "gasóleo" || TipoCombustivel == "gasoleo")
            {
                precoPorLitro = 1.704;
            }
            else if (TipoCombustivel == "gpl")
            {
                precoPorLitro = 0.924;
            }
            else
            {
                Console.WriteLine("Tipo de combustível inváludo!");
            }

            return CapacidadeDeposito * precoPorLitro;
        }

        public override string MostrarDados()
        {
            return base.MostrarDados() + $"\nMarca: {Marca}\nModelo: {Modelo}\n Combustível: {TipoCombustivel}\nCapacidade Deposíto: {CapacidadeDeposito}L\nConsumo médio: {ConsumoMedio} L/100km";

        }
    }
}
