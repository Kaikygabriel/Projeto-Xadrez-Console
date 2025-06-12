using System.Reflection.Metadata.Ecma335;
using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public class Rei : Peca
{
    public Rei(){}
    public Rei(EColor color,Tabuleiro tab): base(color,tab){}

    public override string ToString()
        => "R";

    private bool PodeMover(Posicao pos)
    {
        var p = Tab.GetPeca(pos);
        if (p is null || p.Color != this.Color)
            return true;
        return false;
    }
    public override bool[,] MovimentosPossiveis()
    {
        bool[,] boolMatriz = new bool[Tab.Line, Tab.Colum];
        var pecas = Tab.GetPecas();
        Posicao pos = new Posicao(0,0);
        //acima
        pos.DefinirValor(PosicaoPeca.Line - 1,PosicaoPeca.Colum);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        //abaixo
        pos.DefinirValor(PosicaoPeca.Line + 1,PosicaoPeca.Colum);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        //esquerda
        pos.DefinirValor(PosicaoPeca.Line ,PosicaoPeca.Colum - 1);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        //direita
        pos.DefinirValor(PosicaoPeca.Line ,PosicaoPeca.Colum + 1);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        
        //nordeste
        pos.DefinirValor(PosicaoPeca.Line -1,PosicaoPeca.Colum + 1);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        //sudeste
        pos.DefinirValor(PosicaoPeca.Line +1,PosicaoPeca.Colum + 1);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        //sudoeste
        pos.DefinirValor(PosicaoPeca.Line +1,PosicaoPeca.Colum - 1);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;
        //noroeste
        pos.DefinirValor(PosicaoPeca.Line -1,PosicaoPeca.Colum - 1);
        if (Tab.PosicaoValida(pos) && PodeMover(pos))
            boolMatriz[pos.Line, pos.Colum] = true;

        return boolMatriz;
    }
}