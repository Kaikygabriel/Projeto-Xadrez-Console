using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.tabuleiro;

public class Peca
{
    public Peca(){}

    public Peca( EColor color, Posicao posicaoPeca, Tabuleiro tab)
    {
        QuantityOfMoviments = 0;
        Color = color;
        PosicaoPeca = posicaoPeca;
        Tab = tab;
    }

    public int QuantityOfMoviments { get;private protected set; }
    public EColor Color { get;private protected set; }
    public Posicao PosicaoPeca { get; set; } 
    public Tabuleiro Tab { get; private protected set; }
}