using Xadrez;

namespace JogoDaVelha;
using Tabuleiro;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var tab = new Tabuleiro(8, 8);
            
            tab.ColocarPeca(new Torre(Cor.Preta, tab),new Posicao(0, 0));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(1, 3));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(2, 5));
            
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 7));
            
            Tela.ImpirmirTabuleiro(tab);

            // var posX = new PosicaoXadrez('c', 7);
            // Console.WriteLine(posX);
            //
            // Console.WriteLine(posX.ToPosicao());
        }
        catch (TabuleiroExceptions e)
        {
            Console.Write("Um erro ocorreu! ");
            Console.Write(e.Message);
        }
        
    }
}