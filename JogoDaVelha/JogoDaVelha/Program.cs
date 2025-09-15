namespace JogoDaVelha;
using JogoDaVelha;

public class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
        
        Tela.ImpirmirTabuleiro(tab);
    }
}