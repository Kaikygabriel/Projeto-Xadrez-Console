using Xadrez.tabuleiro.Exception;

namespace Xadrez.tabuleiro;

public class Tabuleiro
{
    public Tabuleiro(){}

    public Tabuleiro(int line, int colum)
    {
        Line = line;
        Colum = colum;
        _pecas =new Peca[line, colum];
    }

    public int Line { get; set; }
    public int Colum { get; set; }
    private Peca[,] _pecas;

    public Peca[,] GetPecas()
        => _pecas;

    public Peca GetPeca(Posicao pos)
        => _pecas[pos.Line, pos.Colum];
    public void AddPeca(Peca peca, Posicao posicao)
    {
        if(!PosicaoValida(posicao) || ExistePecaNaPosicao(posicao))
            throw new DominioException("Error, posição no tabuleiro não existe, ou ja tem outra peça");
        _pecas[posicao.Line, posicao.Colum] = peca;
        peca.PosicaoPeca = posicao;
    }

    public Peca RemovePeca(Posicao pos)
    {
        if (!PosicaoValida(pos))
            throw new DominioException("Error, posição não valida para retirar peça");
        if (GetPeca(pos) is null)
            return null;
        var peca = GetPeca(pos);
        _pecas[pos.Line, pos.Colum] = null;
        return peca;
    }
    bool PosicaoValida(Posicao pos)
    {
        if (Line <= pos.Line || Colum <= pos.Colum || pos.Line < 0 || pos.Colum < 0 )
            return false;
        return true;
    }

    bool ExistePecaNaPosicao(Posicao pos)
        => GetPeca(pos) != null;
}


