using System;

namespace _06___Manipulacao_de_diretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHelper helper = new FileHelper();
            helper.ListarPastas("c:\\dev");
            helper.ListarArquivos("c:\\dev");
        }
    }
}
