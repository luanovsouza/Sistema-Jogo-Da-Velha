using Tabuleiro;

namespace Xadrez;

public class PosicaoXadrez
{
    public char Coluna { get; set; }
    public int Linha { get; set; }

    public PosicaoXadrez(char coluna, int linha)
    {
        Coluna = coluna;
        Linha = linha;
    }


    public Posicao ToPosicao()
    {
        //Fazendo a conversão dos, números da matriz para os, números do Xadrez 
        return new Posicao(8 - Linha, Coluna - 'a');
    }
        
    public override string ToString()
    {
        return $"{Coluna}{Linha}";
    }
}