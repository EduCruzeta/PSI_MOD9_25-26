using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_veiculos
{
    internal class Carros
    {
        public string Marca { get; set; }

        public Motor Motor { get; set; }

        public Carros(string marca, Motor motor)
        {
            Marca = marca;
            Motor = motor;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"- Informações do Automovél-");
            Console.WriteLine($"Marca : {Marca}");
            Console.WriteLine($"Motor: ");
            Motor.MostrarDados();
            Console.WriteLine($"Marca:{Motor.Marca} Potencia:{Motor.Potencia} Combustivel: {Motor.Combustivel}");
        }

        public void TrocarMotor(Motor novoMotor)
        {
            Motor = novoMotor;
            Console.WriteLine("Motor Trocado com sucesso!");
        }
    }
}
