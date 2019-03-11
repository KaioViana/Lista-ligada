using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNaUnha
{
    public class Aluno
    {

        public Aluno()
        {
        }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n" +
                "Idade: " + Idade + "\n" +
                "Sexo: " + Sexo + "\n";
        }
    }
}
