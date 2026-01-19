using Ex_1_mod_9;

Aluno a1 = new Aluno("Antonio", 18);
Aluno a2 = new Aluno("Miguel", 21);
Aluno a3 = new Aluno("Joao", 19);

Console.WriteLine("{0}", (a1.GetIdade() + a2.GetIdade() + a3.GetIdade()) / 3);

Console.Read();