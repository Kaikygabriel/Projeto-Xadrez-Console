using Xadrez.JogoXadrez;
using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.View;

PosicaoXadrez ps = new PosicaoXadrez('c',1);
Console.WriteLine(ps);
var ps2 = ps.ToPosicao();
Console.WriteLine(ps2);