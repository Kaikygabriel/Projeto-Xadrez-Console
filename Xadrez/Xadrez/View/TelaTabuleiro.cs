using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.View;

public partial class TelaTabuleiro
{
    public static void GetTabuleiro(Tabuleiro tab)
    {
        Peca[,] pecas = tab.GetPecas();
        for (int i = 0; i < tab.Line; i++)
        {
            Console.Write($"{8-i} ");
            for (int j = 0; j < tab.Colum; j++)
            {
                ImprimirPeca(pecas[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine("  A B C D E F G H");
    }

    static void ImprimirPeca(Peca peca)
    {
        if (peca is null)
            Console.Write("- ");
        else
        {
            if (peca.Color == EColor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{peca} ");
                Console.ForegroundColor = aux;
            }
            else
                Console.Write($"{peca} ");
        }
    }
}