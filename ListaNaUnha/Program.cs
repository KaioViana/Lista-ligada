using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNaUnha
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaLigada lista = new ListaLigada();

            lista.Listar();// Mostra que a lista começa vazia

            // Inserir no começo da lista
            Aluno aluno1 = new Aluno { Nome = "Rafael", Idade = 18, Sexo = 'M' };
            Console.WriteLine("Inserindo aluno no começo da lista.");
            lista.InserirC(aluno1);// insere objeto no começo da lista
            Console.WriteLine("Listando:");
            lista.Listar();// lista objetos

            // Inserir no final da lista
            Aluno aluno2 = new Aluno { Nome = "Jonas", Idade = 17, Sexo = 'M' };
            Console.WriteLine("Inserindo aluno no fim da lista.");
            lista.InserirF(aluno2);// insere objeto no final da lista
            Console.WriteLine("Listando:");
            lista.Listar();// lista objetos

            // Iserir no começo da lista novamente
            Aluno aluno3 = new Aluno{ Nome = "Carla", Idade = 16, Sexo = 'F' };
            Console.WriteLine("Inserindo aluno no começo da lista.");
            lista.InserirC(aluno3); // insere objeto no começo da lista
            Console.WriteLine("Listando:");
            lista.Listar();// lista objetos

            // Remove começo
            Console.WriteLine("Removendo começo:");
            lista.RemoverC();// remove começo
            Console.WriteLine("Listando:");
            lista.Listar();// lista objetos

            // Remove final
            Console.WriteLine("Removendo final:");
            lista.RemoverF();// remove final
            Console.WriteLine("Listando:");
            lista.Listar();// lista objetos

            // Mostra a quantidade de elementos na lista
            Console.WriteLine("Total de elementos: " + lista.TotalElementos);
        }
    }
}
