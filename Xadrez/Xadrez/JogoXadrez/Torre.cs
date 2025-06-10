using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public class Torre : Peca
{
    public Torre(){}
    public Torre(EColor color,Tabuleiro tab): base(color,tab){}

    public override string ToString()
        => "T";
}