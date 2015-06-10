using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBF_Proyect.Tokenizer
{
 
    /// <summary>
    /// Clase que se encarga de obtener los tokens que interenza para analizador TBT
    /// </summary>
    class Tokenizer
    {
        Lexico Analizer;
   
        /// <summary>
        /// devuelve un string con los caracteres a evaluar:
        /// "c"(Conectores)
        /// "v"(Variable)
        /// "~"(Negacion)
        /// </summary>
        /// <param name="Sentencia">String a evaluar</param>
        /// <returns>Un string nuevo con la sintaxis de: pcp </returns>
        public string AnalyzeTokens(string Sentencia)
        {
            string cadena="";
            Analizer = new Lexico();

            //inicia el analizador lexico
            Analizer.Inicia();
            //Manda la sencia par aser analizada
            Analizer.Analiza(Sentencia);

            for (int i = 0; i < Analizer.Token.Count(); i++)
            {
                cadena += Analizer.Token[i];
            }


            return cadena; 
        }
    }
}
