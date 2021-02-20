using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol.clases.ArbolBinario
{
    class ArbolBinario
    {
        protected Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }
        public ArbolBinario(Nodo VarlorRaiz)
        {
            raiz = VarlorRaiz;
        }
        public Nodo raizArbol()
        {
            return raiz;
        }
        bool esVacio()
        {
            return raiz == null;
        }

        public static Nodo nuevoArbol(Nodo ramaIzqda, object dato, Nodo ramaDercha)
        {
            return new Nodo(ramaIzqda, dato, ramaDercha);
        }
    }
}
