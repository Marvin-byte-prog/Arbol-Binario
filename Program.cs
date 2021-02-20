using Arbol.clases.ArbolBinario;
using System;
using System.Collections;

namespace Arbol
{
    class Program
    {
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquiedo());
                preorden(r.subarbolDerecho());
            }
            
        }
        public static void inorden(Nodo r)
        {
            if (r != null)
            {
                inorden(r.subarbolIzquiedo());
                r.visitar();
                inorden(r.subarbolDerecho());
            }

        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquiedo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }

        }

        static void Main(string[] args)
        {
            try
            {
                ArbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();

                a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.nuevoArbol(null, "Fabricio", null);
                a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a); //apilar
                a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
                a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a);//apilar

                a1 = (Nodo)pila.Pop();
                a2 = (Nodo)pila.Pop();

                a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
                arbol = new ArbolBinario(a);

                Console.WriteLine("preorden");
                preorden(a);
            }
            catch(Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
        }
    }
}
