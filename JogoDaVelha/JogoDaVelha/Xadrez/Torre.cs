using Tabuleiro;

namespace Xadrez;

public class Torre : Peca
{
    public Torre(Cor cor, Tabuleiro.Tabuleiro? tab) : base(cor, tab)
    {
    }

    public override string ToString()
    {
        return "T";
    }
}