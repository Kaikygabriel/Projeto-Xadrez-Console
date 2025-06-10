using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.tabuleiro;

public abstract class Peca
{
    public Peca(){}

    public Peca( EColor color, Tabuleiro tab)
    {
        QuantityOfMoviments = 0;
        Color = color;
        PosicaoPeca = null;
        Tab = tab;
    }

    public int QuantityOfMoviments { get;private protected set; }
    public EColor Color { get;private protected set; }
    public Posicao PosicaoPeca { get; set; } 
    public Tabuleiro Tab { get; private protected set; }
}