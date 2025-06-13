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
    
    public void AddMovimento() => QuantityOfMoviments++;
    public abstract bool[,] MovimentosPossiveis();

    public bool ExisteMovimentos()
    {
        bool[,] mat = MovimentosPossiveis();
        for (int row = 0; row < Tab.Line; row++)
        {
            for (int column = 0; column < Tab.Colum; column++)
            {
                if (mat[row, column])
                    return true;
            }
        }
        
        return false;
    }

    public bool DestinoValido(Posicao pos)
    {
        bool[,] mat = MovimentosPossiveis();
        if (mat[pos.Line, pos.Colum])
            return true;
        return false;
    }
}