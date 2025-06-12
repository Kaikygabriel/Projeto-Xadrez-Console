using Xadrez.tabuleiro;

namespace Xadrez.View;

public partial class TelaTabuleiro
{
    public static void GetTabuleiro(Tabuleiro tab, bool[,] mat)
    {
        Peca[,] pecas = tab.GetPecas();
        for (int i = 0; i < tab.Line; i++)
        {
            Console.Write($"{8-i} ");
            for (int j = 0; j < tab.Colum; j++)
            {
                if (mat[i, j] == true)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                
                ImprimirPeca(pecas[i, j]);
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine();
        }

        Console.WriteLine("  A B C D E F G H");
    }

}