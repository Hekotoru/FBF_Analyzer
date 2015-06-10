using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FBF_Proyect.Printer
{
    /// <summary>
    ///  clase encargada de imprimir en un archivo
    /// </summary>
    class Print
    {
        /// <summary>
        /// Imprime en el archivo  a partir de una lista de strings
        /// </summary>
        /// <param name="Listring">Lista de strings</param>
        /// <param name="name">Nombre del archivo de salida</param>
        public void PintFile(List<string> Listring, string name)
        {
            
            ///Obtiene la direccion del escritorio del usurio que este ejecutando el programa
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath += "\\" + name + ".txt";

            using (StreamWriter writer =
               new StreamWriter(filePath))
                {
                    for (int i = 0; i < Listring.Count; i++)
                        writer.WriteLine(Listring[i]);
                   
                }

            System.Console.Write("\nEvaluacion completa");
        
        }
    }
}
