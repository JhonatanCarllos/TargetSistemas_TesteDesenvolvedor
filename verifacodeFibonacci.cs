internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine($"Verificador de Fibonacci\n");
            Console.WriteLine($"Menu de opções:\n1 - verificador Fibonacci\n0 - exit");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Console.Clear();
                Console.WriteLine("Informe um valor:");
                float valor = float.Parse(Console.ReadLine());
                int atual = 1;
                int futuro = 0;
                int passado = 0;
                int y = 0;
                int resposta = 0;
                while (y < 100)
                {
                    futuro = passado + atual;
                    passado = atual;
                    atual = futuro;
                    if (valor == atual)
                    {
                        resposta = 1;
                        break;
                    }
                    y++;
                }
                if (resposta == 1)
                    Console.WriteLine($"\nO número {valor} pertence a sequência Fibonacci");
                else
                    Console.WriteLine($"\nO número {valor} não pertence a sequência Fibonacci");
            }
            else
            {
                break;
            }

        }
    }
}
