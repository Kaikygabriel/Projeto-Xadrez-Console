using Xadrez.JogoXadrez;

namespace Xadrez.Controler;

public class FunctionJogador
{
    public static PosicaoXadrez LerPosicaoXadrez()
    {
        string ss = Console.ReadLine();
        if (ss.Length < 1)
            throw new Exception("Error,digite uma posição valida");
        char colum = ss[0];
        var line = int.Parse(ss[1] + String.Empty);
        return new PosicaoXadrez(colum, line);
    }
}