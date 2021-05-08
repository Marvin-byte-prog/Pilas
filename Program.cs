
using System;
using Pilas.Clases;
using Pilas.Encoding;
using Pilas.expMatematica;
using Pilas.ListaEnlazada;

namespace Pilas
{
    class Program
    {
        #region Ejemplo en clase
        static void ejemploPilaLineal()
        {
            PilaLineal pila;
            int x;
            int CLAVE = -1;
            Console.WriteLine("Ingrese numeros y para terminar -1");
            try
            {
                pila = new PilaLineal();
                do
                {

                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pila.insertar(x);
                    }

                } while (x != CLAVE);
                Console.WriteLine("estos son los elementos de la pila");

                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"Elemento: {x}");
                }



            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }
        }
        static void palindromo()
        {
            Tildes text = new Tildes();
            PilaLineal pilachar;
            bool esPalindromo;
            String palabra, palabra1;

            try
            {
                pilachar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para verificar si es palindromo");
                palabra = Console.ReadLine();

                palabra1 = text.quitarTildes(palabra);
                //elimina los espacios en blanco de la cadena
                //creamos la pilac con los datos char
                for (int i = 0; i < palabra1.Length; i++)
                {
                    char c;
                    c = palabra1[i++];
                    pilachar.insertar(c);
                }

                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilachar.pilaVacia(); j++)
                {
                    Char c;
                    c = (Char)pilachar.quitarChar();
                    esPalindromo = (palabra1[j++] == c);
                }
                pilachar.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {palabra} es palindromo");
                }
                else
                {
                    Console.WriteLine($"La palabra {palabra} no es palindromo");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        static void EjemploPilaLista()
        {
            PilaLista pl = new PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            // int pau;
            // pau = 0;
        }
        #endregion

        #region tarea
        static void pilaListaEnlazada()
        {

            Lista lista = new Lista();
            lista.apilar("a");
            lista.apilar("n");
            lista.apilar("i");
            lista.apilar("a");
            lista.apilar("Carlos");
            lista.apilar("Nancy");
            lista.apilar(132);
            lista.apilar(4324);

            Console.WriteLine("Datos apilados");
            lista.mostrarDatos();

            Console.WriteLine("\nSe desapilan 2 datos");
            lista.Desapilar();
            lista.Desapilar();
            lista.mostrarDatos();


        }
        static void listPalindromo()
        {

            Lista lista;
            Tildes text = new Tildes();
            bool palindromo;
            string palabra;

            try
            {
                lista = new Lista();
                string nPalabra;
                Console.WriteLine("Ingresa una palabra para verificar si es palindromo: ");
                palabra = Console.ReadLine().ToLower();

                //se formatea la palabra sin tildes y sin espacios
                nPalabra = text.quitarTildes(palabra);
                //Se crea la lista con caracteres
                for (int i = 0; i < nPalabra.Length; i++)
                {
                    Char c;
                    c = nPalabra[i++];
                    lista.apilar(c);
                }
                //comprueba si es palindromo
                palindromo = true;
                for (int j = 0; palindromo && !lista.Vacio(); j++)
                {
                    Nodo c;
                    c = (Nodo)lista.Desapilar();
                    palindromo = (nPalabra[j++].Equals(c.getDato()));
                }

                if (palindromo)
                {
                    Console.WriteLine($"{palabra} es palindromo");
                }
                else
                {
                    Console.WriteLine($"{palabra} no es palindromo");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
        static void PalinList()
        {
            Lista lista1 = new Lista();
            Lista lista2 = new Lista();
            Nodo dato1;
            Nodo dato2;
            string pal = "";
            bool palindromo;
            string palabra;

            Console.WriteLine("Ingrese la palabra por letra. 0 para terminar");
            do
            {
                palabra = Console.ReadLine();

                if (!palabra.Equals("0"))
                {
                    pal += palabra;
                    lista1.apilar(palabra);
                    lista2.Final(palabra);
                }

            } while (palabra != "0");

            palindromo = true;
            for (int i = 0; palindromo && (!lista1.Vacio() && !lista2.Vacio()); i++)
            {
                dato1 = (Nodo)lista1.Desapilar();
                dato2 = (Nodo)lista2.Desapilar();
                palindromo = dato1.getDato().Equals(dato2.getDato());

            }

            Console.Clear();
            if (palindromo)
            {
                Console.WriteLine($"{pal} Es palindromo");
            }
            else
            {
                Console.WriteLine($"{pal} No es palindromo");
            }

        }
        static void listaInversa()
        {
            PilaLista invertido = new PilaLista();
            Lista datos = new Lista();
            Random numeros = new Random();
            for (int i = 1; i <= 10; i++)
            {
                datos.Final(numeros.Next(1, 21));
            }
            datos.mostrarDatos();

            IterarLista listaInversa = new IterarLista(datos);
            Nodo a;
            a = listaInversa.next();
            while (a != null)
            {
                invertido.insertar(a.getDato());
                a = a.getSiguiente();
            }
            invertido.mostrarDatos();
        }
        static void ExpresionMate()
        {
            Expresion expresion = new Expresion();
            string prueba = Console.ReadLine();
            Console.WriteLine(expresion.conviertePostfija(prueba));
        }
        #endregion
        static void Main(string[] args)
        {

            //ejemploPilaLineal();
            // palindromo();


            // pilaListaEnlazada();
            // listPalindromo();
            // PalinList();
            // listaInversa();
            ExpresionMate();

        }
    }
}
