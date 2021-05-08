using System;


namespace Pilas.Clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] ListaPila;

        public PilaLineal(){
            cima =-1; //condicion de pila vacia
            ListaPila = new object [TAMPILA];
        }

        //operaciones que modifican la pila
        public bool pilaLlena(){
            return cima == TAMPILA -1;
        }
        public void insertar(Object elemento){
            if(pilaLlena()){
                throw new Exception("Desbordamiento de la pila Stack OverFlow");
            }
            //incrementar puntero cima y vamos a insertar el elemento
            cima++;
            ListaPila[cima]=elemento;
        }

        public bool pilaVacia(){
            return cima == -1;
        }

        //retorna un tipo char
        public Object quitarChar(){
            char aux;
            if(pilaVacia()){
                throw new Exception("Pila vacia, no hay datos");
            }
            aux =(char)ListaPila[cima];
            cima--;
            return aux;
        }

        public Object quitar(){
            int aux;
            if(pilaVacia()){
                throw new Exception("La pila esta vacia, no se puede sacar");
            }
            //guarda el elemento
            aux = (int)ListaPila[cima];
            //decrementar el valor de cima y retornar el elemento
            cima--;
            return aux;
        }
        //limpiar la pila
        public void LimpiarPila(){
            cima = -1;
        }

        //operacion de acceso a la cima
        public Object cimaPila(){
            if(pilaVacia()){
                throw new Exception("pila vacia");
            }
            return ListaPila[cima];
        }
    }
}