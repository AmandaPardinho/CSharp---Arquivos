using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankArquivos
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas2.csv";

            using(var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoArquivo))
            {
                escritor.Write("456, 65465, 456.0, Pedro");
            }
        }

        static void TestaEscrita()
        {
            var caminhoNovoArquivo = "teste.txt";

            using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoArquivo))
            {
                for(var i = 0; i < 1000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); //Despeja o buffer para o Stream
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                    Console.ReadLine();
                }
            }
        }
    }
}
