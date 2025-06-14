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
    private HashSet<Peca> _pecaJogo;
    private HashSet<Peca> _pecaCapturadas;
    
    public PartidaXadrez()
    {
        Tabuleiro = new Tabuleiro(8, 8);
        JogadaAtual = EColor.Branca;
        Turno = 1;
        ColocarPecas();
        Terminada = false;
        _pecaCapturadas = new HashSet<Peca>();
        _pecaJogo = new HashSet<Peca>();
    }

    public void ColocarNovaPeca(char column, int line, Peca peca)
    {
        Tabuleiro.AddPeca(peca,new PosicaoXadrez(column,line).ToPosicao());
    }

    public HashSet<Peca> pecasCapturadas(EColor cor)
    {
        HashSet<Peca> pecas = _pecaCapturadas.Where(x => x.Color == cor).ToHashSet();
        return  pecas;
    }
    public HashSet<Peca> pecasEmJogo(EColor cor)
    {
        HashSet<Peca> pecas = _pecaJogo.Where(x => x.Color == cor).ToHashSet(); 
        pecas.ExceptWith(pecasCapturadas(cor));
        return pecas;
    }
    private void ColocarPecas()
    {
        //peças brancas
       ColocarNovaPeca('e',1,new Rei(EColor.Branca,Tabuleiro));
       ColocarNovaPeca('a',1,new Torre(EColor.Branca,Tabuleiro));
       ColocarNovaPeca('h',1,new Torre(EColor.Branca,Tabuleiro));
       ColocarNovaPeca('c',1,new Bispo(EColor.Branca,Tabuleiro));
       ColocarNovaPeca('f',1,new Bispo(EColor.Branca,Tabuleiro));
       
       //peças pretas
       ColocarNovaPeca('e',8,new Rei(EColor.Preta,Tabuleiro));
       ColocarNovaPeca('a',8,new Torre(EColor.Preta,Tabuleiro));
       ColocarNovaPeca('h',8,new Torre(EColor.Preta,Tabuleiro));
       ColocarNovaPeca('c',8,new Bispo(EColor.Preta,Tabuleiro));
       ColocarNovaPeca('f',8,new Bispo(EColor.Preta,Tabuleiro));
    }
}
    

