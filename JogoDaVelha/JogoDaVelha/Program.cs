using Xadrez;

namespace JogoDaVelha;
using Tabuleiro;

public class Program
{
    static void Main(string[] args)
    {
        var tab = new Tabuleiro(8, 8);
        
        tab.ColocarPeca(new Torre(Cor.Preta, tab),new Posicao(0, 0));
        tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(1, 3));
        tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(2, 5));
        
        Tela.ImpirmirTabuleiro(tab);
    }
}