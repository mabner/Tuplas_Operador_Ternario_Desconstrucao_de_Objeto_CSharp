using Tuplas_Operador_Ternario_Desconstrucao_de_Objeto_CSharp.Models;

ReadFile file = new ReadFile();

var(success, _, lineCount) = file.ReadTxt("Files/SPEDFiscal.txt");

if(success)
{
    Console.WriteLine($"Line count:{lineCount}");
    // foreach(var line in fileLines)
    // {
    //     Console.WriteLine(line);
    // }
}
else
{
    Console.WriteLine("Cannot read the file");
}
