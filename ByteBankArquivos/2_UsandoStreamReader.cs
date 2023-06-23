using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ByteBankArquivos;

namespace ByteBankArquivos
{
    partial class Program {
        static void UsandoStreamReader()
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

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"Nome do titular: {contaCorrente.Titular.Nome}; Número da conta: {contaCorrente.Numero}; Agência: {contaCorrente.Agencia}; Saldo: {contaCorrente.Saldo};\n";
                    Console.WriteLine(msg);
                }

                Console.ReadKey();
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
    

