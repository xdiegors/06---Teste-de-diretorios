using System;
using System.IO;

namespace _06___Manipulacao_de_diretorios
{
    class FileHelper
    {
        public void ListarPastas(string caminho)
        {
            var arrayResultado = Directory.GetDirectories(caminho, "*");

            foreach (string resultado in arrayResultado)
            {
                Console.WriteLine(resultado);
            }
        }
        public void ListarArquivos(string caminho)
        {
            //Directory.GetFiles(caminho);
            var arrayResultado = Directory.GetFiles(caminho, "*");

            foreach (string resultado in arrayResultado)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}