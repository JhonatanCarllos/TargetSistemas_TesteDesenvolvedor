internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Faturamento Mensal\n");
        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double Outros = 19849.53;
        double total = SP + RJ + MG + ES + Outros;
        SP = (100 * SP) / total;
        RJ = (100 * RJ) / total;
        MG = (100 * MG) / total;
        ES = (100 * ES) / total;
        Outros = (100 * Outros) / total;
        Console.WriteLine($"Valor total do faturamento é R$ {total}\n");
        Console.WriteLine($"Porcentagem das regiões\n\nSão Paulo(SP) {Math.Round(SP, 2)}%\nRio de Janeiro(RJ) {Math.Round(RJ, 2)}%\nMinas Gerais(MG) {Math.Round(MG, 2)}%\nEspírito Santo(ES) {Math.Round(ES, 2)}%\nOutros {Math.Round(Outros, 2)}%");
    }
}