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
}