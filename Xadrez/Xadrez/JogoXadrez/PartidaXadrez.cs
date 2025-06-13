using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.tabuleiro.Exception;

namespace Xadrez.JogoXadrez;

public partial class PartidaXadrez
{
    public Tabuleiro Tabuleiro { get; private set; }
    public int Turno { get; private set; }
    public EColor JogadaAtual { get; private set; }
    public bool Terminada { get;private set; }
    
    public PartidaXadrez()
    {
        Tabuleiro = new Tabuleiro(8, 8);
        JogadaAtual = EColor.Branca;
        Turno = 1;
        ColocarPecas();
        Terminada = false;
    }
    
    
    private void ColocarPecas()
    {
        Tabuleiro.AddPeca(new Rei(EColor.Branca,Tabuleiro),new PosicaoXadrez('e',1).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Branca,Tabuleiro),new PosicaoXadrez('d',1).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Branca,Tabuleiro),new PosicaoXadrez('d',2).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Branca,Tabuleiro),new PosicaoXadrez('e',2).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Branca,Tabuleiro),new PosicaoXadrez('f',2).ToPosicao());
        Tabuleiro.AddPeca(new Bispo(EColor.Branca,Tabuleiro),new PosicaoXadrez('f',1).ToPosicao());


        Tabuleiro.AddPeca(new Rei(EColor.Preta,Tabuleiro),new PosicaoXadrez('e',8).ToPosicao());
        Tabuleiro.AddPeca(new Torre(EColor.Preta,Tabuleiro),new PosicaoXadrez('d',8).ToPosicao());
        Tabuleiro.AddPeca(new Bispo(EColor.Preta,Tabuleiro),new PosicaoXadrez('f',8).ToPosicao());
    }
}
    

