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
            EscritaBinaria();
            LeituraBinaria();

            Console.WriteLine("Aplicação Finalizada");

            Console.ReadKey();
        }
    }
}