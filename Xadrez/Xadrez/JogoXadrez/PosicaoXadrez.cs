using Xadrez.tabuleiro;

namespace Xadrez.JogoXadrez;

public class PosicaoXadrez
{
    public PosicaoXadrez(){}

    public PosicaoXadrez(char coluna, int linha)
    {
        Coluna = coluna;
        Linha = linha;
    }

    public char Coluna { get;private set; }
    public int Linha { get;private set; }

    public override string ToString()
        => $"{Coluna}{Linha}";

    public Posicao ToPosicao()
    {
        return new Posicao(8-Linha ,Coluna - 'a');
    }
}