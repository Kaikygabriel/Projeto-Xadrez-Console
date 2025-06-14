using System.Runtime.CompilerServices;
using Xadrez.Controler;
using Xadrez.JogoXadrez;
using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.tabuleiro.Exception;
using Xadrez.View;

namespace Xadrez;

public class Program
{
    static void Main()
    {
        var partida = new PartidaXadrez();
        while (!partida.Terminada)
        {
            try
            {
                Console.Clear();
                TelaTabuleiro.GetTabuleiro(partida.Tabuleiro);
                Console.WriteLine("");
                Console.WriteLine("Turno  " + partida.Turno);
                Console.WriteLine("Aguardando a jogada da " + partida.JogadaAtual);

                Console.WriteLine("Origem");
                Posicao origem = FunctionJogador.LerPosicaoXadrez().ToPosicao();
                partida.PosicaoValidaOuPecaValida(origem);

                Console.Clear();
                bool[,] posicaoPossiveis = partida.Tabuleiro.GetPeca(origem).MovimentosPossiveis();
                TelaTabuleiro.GetTabuleiro(partida.Tabuleiro, posicaoPossiveis);
                Console.WriteLine("Destino");
                Posicao destino = FunctionJogador.LerPosicaoXadrez().ToPosicao();
                partida.DestinoValido(origem,destino);
                
                partida.RealizaMovimento(origem, destino);
                TelaTabuleiro.GetTabuleiro(partida.Tabuleiro);
            }
            catch (DominioException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error inesperado");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}


