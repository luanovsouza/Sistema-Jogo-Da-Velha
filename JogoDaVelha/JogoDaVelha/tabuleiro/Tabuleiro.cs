namespace Tabuleiro;

public class Tabuleiro
{
    public int Linhas { get; set; }
    public int Colunas { get; set; }
    private Peca[,] Pecas { get; set; }

    public Tabuleiro(int linha, int coluna)
    {
        Linhas = linha;
        Colunas = coluna;
        Pecas = new Peca[linha, coluna];
    }

    public Peca GetPeca(int linha, int coluna)
    {
        return Pecas[linha, coluna];
    }

    private Peca Peca(Posicao pos)
    {
        return Pecas[pos.Linha, pos.Coluna];
    }


    public bool ExistePeca(Posicao pos)
    {
        ValidarPosicao(pos);
        return Peca(pos) != null;
    }
    
    public void ColocarPeca(Peca peca, Posicao posicao)
    {
        if (ExistePeca(posicao))
        {
            throw new TabuleiroExceptions("Ja existe uma peça onde deseja colocar!");
        }
        Pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.Posicao = posicao;
    }

    public bool PosicaoValida(Posicao pos)
    {
        if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
        {
            return false;
        }
        return true;
    }

    public void ValidarPosicao(Posicao pos)
    {
        if (!PosicaoValida(pos))
        {
            throw new TabuleiroExceptions("Posição Invalida!");
        }
    }
}