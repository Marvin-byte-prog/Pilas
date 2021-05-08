namespace Pilas.ListaEnlazada
{
    class IterarLista
    {
        Nodo temp;
        public IterarLista(Lista lista)
        {
            temp = lista.cabeza();
        }
        public Nodo next()
        {
            Nodo a;
            a = temp;
            while (temp != null)
            {
                temp = temp.getSiguiente();
            }
            return a;
        }
    }
}