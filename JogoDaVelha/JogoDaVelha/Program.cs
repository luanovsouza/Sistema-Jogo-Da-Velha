using Xadrez;

namespace JogoDaVelha;
using Tabuleiro;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var partidaXadrex = new PartidaXadrez();
            
            Tela.ImpirmirTabuleiro(partidaXadrex.Tab);
        }
        catch (TabuleiroExceptions e)
        {
            Console.Write("Um erro ocorreu! ");
            Console.Write(e.Message);
        }
        
    }
}