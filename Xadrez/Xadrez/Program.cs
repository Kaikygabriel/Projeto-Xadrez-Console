using Xadrez.Controler;
using Xadrez.JogoXadrez;
using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.View;

PartidaXadrez partida = new PartidaXadrez();
while (!partida.Terminada)
{
    Console.Clear();
    TelaTabuleiro.GetTabuleiro(partida.Tabuleiro);
    Console.WriteLine("Origem");
    Posicao origem = FunctionJogador.LerPosicaoXadrez().ToPosicao();
    Console.WriteLine("Destino");
    Posicao destino = FunctionJogador.LerPosicaoXadrez().ToPosicao();
    partida.ExcutarMovimento(origem,destino);
    TelaTabuleiro.GetTabuleiro(partida.Tabuleiro);
}

