using System;
using System.IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoArquivo = "contas.txt";
        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoArquivo);

            /*var linha = leitor.ReadLine();
            Console.WriteLine(linha);
            Console.WriteLine("");*/

            /*var texto = leitor.ReadToEnd();
            Console.WriteLine(texto);*/

            /*var numero = leitor.Read(); // traz o número do primeiro caractere em byte
            Console.WriteLine(numero);*/

            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }


        } 
        Console.ReadKey();        
    }
}