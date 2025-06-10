using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public class Rei : Peca
{
    public Rei(){}
    public Rei(EColor color,Tabuleiro tab): base(color,tab){}

    public override string ToString()
        => "R";
}