using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNaUnha
{
    class ListaLigada
    {
        private Node primeiro;
        private Node ultimo;

        // Insere no começo
        public void InserirC(object elemento)
        {
            Node novo = new Node { Elemento = elemento, Proximo = this.primeiro };// cria um novo Node
            this.primeiro = novo;// aponta o primeiro para ele
            if (IsVazio())// se a lista estiver vazia o último também aponta para o primeiro
                this.ultimo = this.primeiro;
            TotalElementos++;// incrementa a quantidade de elementos
        }
        // Insere no final
        public void InserirF(object elemento)
        {
            if (IsVazio())// se a lista estiver vazia, chama inserirC()
                InserirC(elemento);
            else
            {
                Node novo = new Node { Elemento = elemento };// se não, cria um novo Node
                this.ultimo.Proximo = novo;// aponta o próximo do último para ele
                this.ultimo = novo;// e o último para o novo Node
                TotalElementos++;// incrementa a quantidade de elementos
            }
        }
        // Remove no começo
        public void RemoverC()
        {
            this.primeiro = this.primeiro.Proximo;
            TotalElementos--;
            if (IsVazio())
                this.ultimo = null;
        }

        // Remove no final
        public void RemoverF()
        {
            if(TotalElementos == 1)
            {
                RemoverC();
            }
            else
            {
                Node tmp = this.primeiro;
                for (int i = 1; i <= TotalElementos; i++)
                {
                    if (i == TotalElementos - 1)
                    {
                        this.ultimo = tmp;
                        this.ultimo.Proximo = null;
                        TotalElementos--;
                        break;
                    }
                    tmp = tmp.Proximo;
                }
            }
        }
        // Lista os elementos
        public void Listar()
        {
           if(IsVazio())
                Console.WriteLine("LISTA VAZIA !\n");
            else
            {
                Node tmp = this.primeiro;
                while (tmp != null)
                {
                    Console.WriteLine(tmp.Elemento.ToString());
                    tmp = tmp.Proximo;
                }
            }
        }
        // Verifica se a lista está vazia
        public bool IsVazio()
        {
            return TotalElementos == 0;
        }
        // Propriedades TotalDeElementos
        public int TotalElementos{get; private set;}
    }
}
