using System;
using System.Text;
using Pilas.Clases;

namespace Pilas.expMatematica
{
    class Expresion
    {
        
        enum Tipo
        {
            invalido,
            operador,
            operando
        }

        public string conviertePostfija(string expresion)
        {

            StringBuilder salida = new StringBuilder();
            PilaLista lista = new PilaLista();
            string token = string.Empty;
            Tipo tipo = Tipo.invalido;
            for (int i = 0; i < expresion.Length; i++)
            {
                token = expresion[i].ToString();

                tipo = GetTipo(token);

                if (tipo == Tipo.operando)
                {
                    salida.Append(token);
                }
                else                
                {
                    ApilarOperador(salida,lista,token);
                }
            }
            VaciarOperandos(salida, lista);
            return salida.ToString();
        }
        public byte prioridad(string operador)
        {
            switch (operador)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 3;
            }
        }
        private void VaciarOperandos(StringBuilder salida, PilaLista operadores)
        {
            salida.Append(" ");

            while (operadores.lista().Count > 0)
            {
                string sop = (string)operadores.quitar();

                if (sop == "(")
                    throw new Exception("Error falta parentesis de cierre )");

                salida.Append(sop + " ");
            }
        }
        private void ApilarOperador(StringBuilder salida, PilaLista operadores, string token)
            {
                salida.Append(" ");
                if (operadores.lista().Count > 0) DesapilaOperando(token, operadores, salida);
                operadores.insertar(token);
            }
        public void DesapilaOperando(string operador, PilaLista lista, StringBuilder salida)
        {

            int dato = prioridad(operador);
            string op = (string)lista.quitar();
            int dato2 = prioridad(op);
            while (dato <= dato2)
            {
                salida.Append(op + " ");
                if (lista.lista().Count== 0)
                {
                    break;
                }
                op = (string)lista.quitar();
                dato2 = prioridad(op);
            }

            if (dato > dato2)
            {
                lista.insertar(op);
            }

        }

        private Tipo GetTipo(string token)
        {
            if (char.IsDigit(token[0]))
            {
                return Tipo.operando;
            }
            switch (token)
            {
                case "+":
                case "-":
                case "/":
                case "*":
                    return Tipo.operador;
                default:
                    return Tipo.invalido;
            }
        }
    }
}