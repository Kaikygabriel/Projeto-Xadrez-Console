using Xadrez.JogoXadrez;
using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.View;

var tabuleiro = new Tabuleiro(8,8);
var torre1 = new Torre(EColor.Branca,tabuleiro);
var rei1 = new Rei(EColor.Branca,tabuleiro);

tabuleiro.AddPeca(torre1,new Posicao(0,0));
tabuleiro.AddPeca(rei1,new Posicao(1,3));

TelaTabuleiro.GetTabuleiro(tabuleiro);