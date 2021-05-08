using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Pilas.Encoding
{
    class Tildes
    {
        public string quitarTildes(String palabra){
            string texto= Regex.Replace(palabra.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9]+","");
            return texto;
        }
    }
}