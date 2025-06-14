using Xadrez.tabuleiro;
using Xadrez.tabuleiro.EnumColor;
using Xadrez.tabuleiro.Exception;

namespace Xadrez.JogoXadrez;

public partial class PartidaXadrez
{
    public void RealizaMovimento(Posicao origem, Posicao destino)
    {
        ExcutarMovimento(origem,destino);
        MudarPlayer();
        Turno++;
    }

    private void MudarPlayer()
    {
        if (JogadaAtual == EColor.Branca)
            JogadaAtual = EColor.Preta;
        else
            JogadaAtual = EColor.Branca;
    }
    public void ExcutarMovimento(Posicao origem, Posicao destino)
    {
        Peca p = Tabuleiro.RemovePeca(origem);
        p.AddMovimento();
        Peca PecaCapturada = Tabuleiro.RemovePeca(destino);
        Tabuleiro.AddPeca(p,destino);
        if (PecaCapturada != null)
            _pecaCapturadas.Add(PecaCapturada);
    }

    public void PosicaoValidaOuPecaValida(Posicao pos)
    {
        if (!Tabuleiro.ExistePecaNaPosicao(pos))
            throw new DominioException("error, não tem peça na posição escolhida");
        if (!Tabuleiro.GetPeca(pos).ExisteMovimentos())
            throw new DominioException("error,não existe movimentos que a peça possa fazer");
        if(Tabuleiro.GetPeca(pos).Color != JogadaAtual)
            throw new DominioException("error, não é a cor da peça certa");
    }

    public void DestinoValido(Posicao origem,Posicao destino)
    {
        if (!Tabuleiro.ExistePecaNaPosicao(origem))
        {
            if(Tabuleiro.GetPeca(origem).Color == Tabuleiro.GetPeca(destino).Color)
                throw new DominioException("error, esta tentando comer peça da mesma cor");
        }

        if (origem == destino)
            throw new DominioException("error,posição destino não pode ser a mesma que a origem");
        if(!Tabuleiro.GetPeca(origem).DestinoValido(destino))
            throw new DominioException("error, essa peça não pode mover para esta posição");
    }
}