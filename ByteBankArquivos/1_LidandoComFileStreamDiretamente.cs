using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoArquivo = "contas.txt";

        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var numeroBytesLidos = -1;

            /* public override int Read(byte[] array, int offset, int count);
             * byte[] array => buffer
             * ** armazena os bytes lidos pelo método
             * ** pode ser reutilizado para guardar informações temporárias
             * ** 1024 => tamanho de um kbyte
             * int offset => delimita o índice em que o método vai começar a preencher o array
             * int count => informa o número de posições a serem preenchidas
             * o método Read devolve o número total de bytes lidos do buffer, podendo ser menor que o número de bytes solicitado se o número de bytes não estiver disponível no momento, ou for igual a zero se o final do fluxo for atingido 
             */

            var buffer = new byte[1024];
            //var tempo = new Stream(fluxoArquivo);

            while (numeroBytesLidos != 0)
            {
                numeroBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos: {numeroBytesLidos}");
                EscreverBuffer(buffer, numeroBytesLidos);
            }

            fluxoArquivo.Close();
            Console.ReadKey();
        }
    }

    private static object ContaCorrente(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        /*foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }*/
    }
}