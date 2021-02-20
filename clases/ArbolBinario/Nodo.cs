using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol.clases.ArbolBinario
{
    class Nodo
    {
        protected object dato;
        protected Nodo izquierda;
        protected Nodo derecha;

        public Nodo(Nodo ramaIzqda, object valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;
        }

        public Nodo(Nodo ramaIzquierda, object valor, Nodo ramaDerecha)
        {
            dato = valor;
            izquierda = ramaIzquierda;
            derecha = ramaDerecha;
        }

        public void visitar()
        {
            Console.WriteLine(dato + "<->");
        }

        public object valorNodo()
        {
            return dato;
        }

        public Nodo subarbolDerecho()
        {
            return derecha;
        }

        public Nodo subarbolIzquiedo()
        {
            return izquierda;
        }

        public void nuevoValor(object nv)
        {
            dato = nv;
        }
        public void ramaIzda(Nodo n)
        {
            izquierda = n;
        }
        public void ramaDcho(Nodo n)
        {
            izquierda = n;
        }
    }
}
