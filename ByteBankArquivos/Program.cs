using System;
using System.IO;
using System.Text;
using ByteBankArquivos;

namespace ByteBankArquivos
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
            Console.WriteLine();

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"O arquivo contas.txt possui {bytesArquivo.Length} bytes");

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Aplicação Finalizada");

            Console.ReadLine();
        }
    }
}