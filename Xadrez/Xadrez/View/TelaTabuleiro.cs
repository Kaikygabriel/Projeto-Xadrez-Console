using Xadrez.tabuleiro;

namespace Xadrez.View;

public class TelaTabuleiro
{
    public static void GetTabuleiro(Tabuleiro tab)
    {
        Peca[,] pecas = tab.GetPecas();
        for (int i = 0; i < tab.Line; i++)
        {
            for (int j = 0; j < tab.Colum; j++)
            {
                if(pecas[i,j] is null)
                    Console.Write("- ");
                else
                    Console.Write($"{pecas[i,j]} ");
            }

            Console.WriteLine();
        }
    }
}