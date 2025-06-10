using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public class Bispo : Peca
{
    public Bispo(){}
    public Bispo(EColor color,Tabuleiro tab): base(color,tab){}

    public override string ToString()
        => "B";
}