using Xadrez.JogoXadrez;
using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.View;



var tabu = new Tabuleiro(8,8);
var rei1 = new Rei(EColor.Preta, tabu);
var torre = new Torre(EColor.Branca, tabu);

tabu.AddPeca(rei1,new Posicao(1,2));
tabu.AddPeca(torre,new Posicao(4,1));

TelaTabuleiro.GetTabuleiro(tabu);

