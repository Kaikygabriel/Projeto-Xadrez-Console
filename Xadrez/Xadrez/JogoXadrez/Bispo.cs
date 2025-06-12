using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public class Bispo : Peca
{
    public Bispo(){}
    public Bispo(EColor color,Tabuleiro tab): base(color,tab){}

    public override string ToString()
        => "B";

    private bool PodeMover(Posicao pos)
    {
        var p = Tab.GetPeca(pos);
        if (p is null || p.Color != this.Color)
            return true;
        return false;
    }

 
    public override bool[,] MovimentosPossiveis()
    {
        bool[,] mat = new bool[Tab.Line, Tab.Colum];
        Posicao pos = new Posicao(0,0);
        
        //noroeste
        pos.DefinirValor(PosicaoPeca.Line - 1, PosicaoPeca.Colum -1);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Line -= 1;
            pos.Colum -= 1;

        }
        
        //nordeste
        pos.DefinirValor(PosicaoPeca.Line - 1, PosicaoPeca.Colum + 1);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Line -= 1;
            pos.Colum += 1;
        }
        
        //sudeste
        pos.DefinirValor(PosicaoPeca.Line +1, PosicaoPeca.Colum +1);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Colum += 1;
            pos.Line += 1;
        }
        
        //sudoeste
        pos.DefinirValor(PosicaoPeca.Line +1, PosicaoPeca.Colum -1);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Line += 1;
            pos.Colum-= 1;
        }
        return mat;
    }
}