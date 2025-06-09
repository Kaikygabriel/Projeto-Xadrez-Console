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
}