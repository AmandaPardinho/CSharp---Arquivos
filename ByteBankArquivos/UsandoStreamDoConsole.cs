using System;
using System.IO;
using System.Text;
using ByteBankArquivos;

namespace ByteBankArquivos
{
    partial class Program
    {
        static void UsarStreamEntrada()
        {
            /* OpenStandardInput =>
             * permite ler o que o usuário digitou no console
             */
            using (var fluxoEntrada = Console.OpenStandardInput())
            using(var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024]; //1kb

                while (true)
                {
                    var bytesLidos = fluxoEntrada.Read(buffer, 0, 1024);

                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();
                
                    Console.WriteLine($"bytes lidos no console: {bytesLidos}");
                }
            }
        }
    }
}