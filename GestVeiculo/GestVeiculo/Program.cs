using GestVeiculo;

    // Criar proprietário
    Propriatario propriatario = new Propriatario("Maria Santos", "xyz987654", 987654321);

    // Criar veiculo genérico
    Veiculo veiculo = new Veiculo("11-AA-22", 2018, propriatario);
    Console.WriteLine("===DADOS DO VEÍCULO===");
    Console.WriteLine(veiculo.MostrarDados());
    Console.WriteLine();

    // Criar automóvel
    Automovel carro = new Automovel("33-88-44", 2023, propriatario, "Ford", "Focus", "gasóleo", 55, 5.8);

    Console.WriteLine("=== DADOS DO AUTOMÓVEL ===");
    Console.WriteLine(carro.MostrarDados());
    Console.WriteLine();

    double autonomia = carro.CalcularAutonomia();
    double custo = carro.CalcularCustoDeposito();

    Console.WriteLine("== CÁLCULOS ===");
    Console.WriteLine($"Autonomia com deposito cheio: {autonomia:f2} km");
    Console.WriteLine($"Custo para encher o depósito: {custo:f2} euros");

    Console.ReadKey();

  
