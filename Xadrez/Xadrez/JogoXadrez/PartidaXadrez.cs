using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;

namespace Xadrez.JogoXadrez;

public partial class PartidaXadrez
{
    public Tabuleiro Tabuleiro { get; private set; }
    private int _turno;
    private EColor _jogadorAtual;
    public bool Terminada { get;private set; }
    
    public PartidaXadrez()
    {
        Tabuleiro = new Tabuleiro(8, 8);
        _jogadorAtual = EColor.Branca;
        _turno = 1;
        ColocarPecas();
        Terminada = false;
    }

    public void ExcutarMovimento(Posicao origem, Posicao destino)
    {
        Peca p = Tabuleiro.RemovePeca(origem);
        p.AddMovimento();
        Peca PecaCapturada = Tabuleiro.RemovePeca(destino);
        Tabuleiro.AddPeca(p,destino);
    }

    private void ColocarPecas()
    {
        Tabuleiro.AddPeca(new Rei(EColor.Branca,Tabuleiro),new PosicaoXadrez('e',1).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Branca,Tabuleiro),new PosicaoXadrez('d',1).ToPosicao());
        Tabuleiro.AddPeca(new Bispo(EColor.Branca,Tabuleiro),new PosicaoXadrez('f',1).ToPosicao());


        Tabuleiro.AddPeca(new Rei(EColor.Preta,Tabuleiro),new PosicaoXadrez('e',8).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Preta,Tabuleiro),new PosicaoXadrez('d',8).ToPosicao());
        Tabuleiro.AddPeca(new Bispo(EColor.Preta,Tabuleiro),new PosicaoXadrez('f',8).ToPosicao());
    }
}
    

