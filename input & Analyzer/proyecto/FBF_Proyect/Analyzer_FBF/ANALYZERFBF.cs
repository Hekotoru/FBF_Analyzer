using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FBF_Proyect.Analyzer_FBF
{
    /// <summary>
    /// Clase responsable de determinar si es  un FBF
    /// </summary>
    class ANALYZERFBF
    {


        //entrada
        string Input;
        //Salida
        string OutPut;

        Printer.Print printer = new Printer.Print();

        //devuelvelos tokens interesados tokens de: conector, variable y negacion en caso de que haya
        Tokenizer.Tokenizer analizerVaribleConector = new Tokenizer.Tokenizer();

        //Para almacenar la lista de proposiciones
        List<string> listPreposition = new List<string>();

        //instacia del objeto que maneja el llamado al archivo InputTXT
        FBF_Project.INFILE infile = new FBF_Project.INFILE();

        //instancia del objeto que maneja la sintaxis de las proposiciones
        Analyzer_Syntax.Analyzer_Syntax Analyzersintax = new Analyzer_Syntax.Analyzer_Syntax();


        /// <summary>
        /// Contructor por defecto con los paremetro de entrada y de salida
        /// </summary>
        /// <param name="inp">nombre de entrada</param>
        /// <param name="outp">Nombre de salida</param>
        public ANALYZERFBF(string inp, string outp)
        {
            Input = inp;
            OutPut = outp;   
        }

        
        public void AnalyzerProcess()
        {
            //Carga del archivo todas las proposiciones en una lista
            listPreposition = infile.LoadFile(Input);
            int x = listPreposition.Count();
           // string ConectorVariable="";

            //elimina el ultimo espacio
            if (listPreposition[x - 1] == "")
            {
                x--;           
            }
            

            //se comprueba si es FBF
            for(int i=0; i<x; i++)
            {
               
                //se asigna una nueva expresion con p->|v|^|<->p , sin los parentesis
                
                if (Analyzersintax.AreParanthesesBalanced((listPreposition[i])))
                {
                    if (Analyzersintax.isFBF(conector(analizerVaribleConector.AnalyzeTokens(listPreposition[i]))))
                    {
                        listPreposition[i] += " ---> Es un FBF";
                    }

                    else
                    {
                        listPreposition[i] += " ---> NO es un FBF";
                    }

                }
                    
               else
                {
                    listPreposition[i] += " ---> Parentesis No balanceados";
                }

            }

            ///Se manda a acrear el archivo nuevo de salida con las expreciones ya evaluadas.
            printer.PintFile(listPreposition, OutPut);

           

        }


        private string conector(string cadena)
        {

            string[] conector = {"^", "v", "->", "<->"};
            string output;

            for (int i = 0; i < conector.Count(); i++)
            {
                 output = cadena.Replace(conector[i], "c");
                 cadena = output;
            }


            return cadena;
        }

        


    }
}
