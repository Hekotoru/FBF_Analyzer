using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBF_Proyect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings para nombre de entra y de  salida
            string inputname, output;

            System.Console.Write("INSTRUCCIONES: \n\nConectores y negación:\n"+
            "  v  = disyunción “ó”\n"+
            "  ^  = conjunción “y”\n"+
            " ->  = condicional “si entonces”\n"+
            " <-> = bicondicional “si entonces si”\n"+ 
            "  ~  = Negacion \n\n"+
            "Se aceptan cualquier nombre de varible sin importar el numero de caracteres.\n"+
            "Para la agrupacion de propociones atomicas se usa el parentesis ().\n"+
            "El archvio a evaluar debe de estar en el escritorio, el nuevo archivo de\n"+
            "salida, se ubicara en el escritorio. Las propociones deben de estar\n"+
            "separadas por lineas nuevas.");

            System.Console.Write("\n\nNombre del archivo de entrada: ");

            inputname = Console.ReadLine();
            
            System.Console.Write("Nombre del archivo de salida: ");

            output = Console.ReadLine();

            //intancia de la clase manejadora del analizador de FBF
            //contructor con los datos de entrada
            Analyzer_FBF.ANALYZERFBF analyzerFBF = new Analyzer_FBF.ANALYZERFBF(inputname, output);

            //medinte el analisis Crea el nuevo archvio con los resultados usando las otras clases
            analyzerFBF.AnalyzerProcess();


            System.Console.ReadKey();

        }
    }
}
