using System;
namespace Pilas.ListaEnlazada
{
    class Lista
    {
        protected Nodo tope;

        public Lista()
        {
            tope = null;
        }

        public Nodo cabeza()
        {
            return tope;
        }
        public void apilar(object pila)
        {
            Nodo nuevo = new Nodo(pila);
            if (Vacio())
            {
                tope = nuevo;
            }
            else
            {
                Nodo aux = tope;
                tope = nuevo;
                tope.setSiguiente(aux);

            }
        }
        public void Final(object pila)
        {
            Nodo nuevo = new Nodo(pila);
            if (Vacio())
            {
                tope = nuevo;

            }
            else
            {
                Nodo puntero = tope;
                while (puntero.getSiguiente() != null)
                {
                    puntero = puntero.getSiguiente();
                }
                nuevo.setSiguiente(puntero.getSiguiente());
                puntero.setSiguiente(nuevo);
                puntero = null;
            }
        }

        public Object Desapilar()
        {
            Nodo aux;
            if (Vacio())
            {
                throw new Exception("Pila vacia");
            }
            aux = tope;
            tope = tope.getSiguiente();
            return aux;
        }

        //retorna true si la pila esta vacia
        public bool Vacio()
        {
            return tope == null;
        }

        public void mostrarDatos()
        {
            Nodo nodo = tope;
            while (nodo != null)
            {
                Console.WriteLine(nodo.getDato() + "--->");
                nodo = nodo.getSiguiente();
            }
        }
    }
}