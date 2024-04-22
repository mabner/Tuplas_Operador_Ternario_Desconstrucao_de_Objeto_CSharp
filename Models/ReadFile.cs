using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_Operador_Ternario_Desconstrucao_de_Objeto_CSharp.Models
{
    public class ReadFile
    {
        public (bool Success, string[] Lines, int LineCount) ReadTxt(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return(true, lines, lines.Count());
            }
            catch (System.Exception)
            {
                
                return (false, new string[0], 0);
            }
        }
    }
}