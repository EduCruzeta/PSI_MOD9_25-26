
using Get_veiculos;

Motor Motor1 = new Motor("patrol", 600, "gasoile");
Carros carro1 = new Carros("Toyota",Motor1);

carro1.MostrarDados();
Motor Motor2 = new Motor("batata", 1700, "terra");
carro1.TrocarMotor(Motor2);
carro1.MostrarDados();

