using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_mod_9
{
    public class Aluno
    {
        string nome;
        int idade;

        public Aluno(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public int GetIdade() 
        { 
            return this.idade; 
        }
    }
}
