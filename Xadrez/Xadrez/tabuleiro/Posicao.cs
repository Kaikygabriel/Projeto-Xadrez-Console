namespace Xadrez.tabuleiro;

public class Posicao
{
    public Posicao(){}

    public Posicao(int line, int colum)
    {
        Line = line;
        Colum = colum;
    }

    public int Line { get; set; }
    public int Colum { get; set; }
    
    public override string ToString()
        => $"{Line} , {Colum}";
}