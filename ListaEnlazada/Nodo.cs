namespace Pilas.ListaEnlazada
{
    class Nodo
    {
        private Nodo siguiente;
        private object dato;

        public Nodo(object x)
        {
            dato = x;
            siguiente = null;
        }

        public Nodo(Nodo nodo, object x)
        {
            siguiente = nodo;
            dato = x;
        }

        public object getDato()
        {
            return dato;
        }

        public Nodo getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(Nodo dato)
        {
            siguiente = dato;
        }
    }
}