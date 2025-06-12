using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public class Torre : Peca
{
    public Torre(){}
    public Torre(EColor color,Tabuleiro tab): base(color,tab){}

    public override string ToString()
        => "T";

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
        
        //acima
        pos.DefinirValor(PosicaoPeca.Line - 1, PosicaoPeca.Colum);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Line -= 1;
        }
        
        //abaixo
        pos.DefinirValor(PosicaoPeca.Line + 1, PosicaoPeca.Colum);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Line += 1;
        }
        
        //esquerda
        pos.DefinirValor(PosicaoPeca.Line , PosicaoPeca.Colum -1);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Colum -= 1;
        }
        
        //direita
        pos.DefinirValor(PosicaoPeca.Line , PosicaoPeca.Colum +1);
        while (Tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Line, pos.Colum] = true;
            if (Tab.GetPeca(pos) != null && Tab.GetPeca(pos).Color != Color)
                break;
            pos.Colum += 1;
        }
        return mat;
    }
}