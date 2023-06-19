class Program
{
    static void Main(string[] args)
    {
        var enderecoArquivo = "contas.txt";
        var numeroBytesLidos = -1;
        var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open);

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

        while(numeroBytesLidos != 0)
        {
            numeroBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);

            EscreverBuffer(buffer);

        }

        Console.ReadKey();
    }

    private static object ContaCorrente(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }
}