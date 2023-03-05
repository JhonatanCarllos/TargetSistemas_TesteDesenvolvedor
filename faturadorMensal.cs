internal class Program
{
    private static void Main(string[] args)
    {
        //Questão 3
        Console.Clear();
        Console.WriteLine("Faturamento Mensal\nRelatório:\n");
        double menor = 22174.1664;
        double maior = 0;
        int datam = 0;
        int dataM = 0;
        double valor = 0;
        double p = 0;
        var faturamento = new double[31] { 0, 22174.1664, 24537.6698, 26139.6134, 0, 0, 26742.6612, 0, 42889.2258, 46251.174, 11191.4722, 0, 0, 3847.4823, 373.7838, 2659.7563, 48924.2448, 18419.2614, 0, 0, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 13327.1025, 0, 0, 25681.8318, 1718.1221, 13220.495, 8414.61 };
        for (var dia = 0; dia < faturamento.Length; dia++)
        {
            p = faturamento[dia];
            valor = valor + p;
            //Console.WriteLine(faturamento[dia]);
            if (faturamento[dia] < menor && faturamento[dia] != 0)
            {
                menor = faturamento[dia];
                datam = dia;
            }
            else if (faturamento[dia] > maior && faturamento[dia] != 0)
            {
                maior = faturamento[dia];
                dataM = dia;
            }
        }
        double media = valor / 21;
        int diaMelhores = 0;
        //Console.WriteLine(media);
        for (var dia = 0; dia < faturamento.Length; dia++)
        {
            if (faturamento[dia] > media)
            {
                diaMelhores++;
            }
        }
        Console.WriteLine($"O menor valor do faturamento foi {menor} no dia {datam} do mês\n");
        Console.WriteLine($"O maior valor do faturamento foi {maior} no dia {dataM} do mês\n");
        Console.WriteLine($"Total de dias que o valor diario foi superior a média mensal foram:\n{diaMelhores} dias\nMédia Mensal = {media} ");
    }
}
