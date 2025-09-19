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
        //Verificando se existe uma peça, se existir nao podoe colocar uma peça no mesmo lugar que a outra
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

    public Peca RetirarPeca(Posicao posicao)
    {
        if (Peca(posicao) == null)
        {
            return null;
        }

        var aux = Peca(posicao);
        aux.Posicao = null;
        Pecas[posicao.Linha, posicao.Coluna] = null;
        return aux;
    }

    public bool PosicaoValida(Posicao pos)
    {
        //Verificando se a posição é valida, ou seja, se for igual a zero ou for maior que a linha ou a coluna
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