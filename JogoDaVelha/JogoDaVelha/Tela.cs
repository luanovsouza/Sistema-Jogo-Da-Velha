namespace JogoDaVelha;
using Tabuleiro;

public class Tela //Criando a classe para poder mostrar o tabuleiro na tela
{
    public static void ImpirmirTabuleiro(Tabuleiro tab) // Criando o método para isto
    {
        for (int i = 0; i < tab.Linhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < tab.Colunas; j++)
            {
                
                if (tab.GetPeca(i,j) == null)
                {
                    Console.Write("- ");
                }
                else
                {
                    //Chamando a função que muda a cor da peça
                    ImpirmirPeca(tab.GetPeca(i, j));
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.Write("  a b c d e f g h");
    }

    public static void ImpirmirPeca(Peca peca)
    {
        if (peca.Cor == Cor.Branca)
        {
            //Se não for preta vai ficar do mesmo jeito
            Console.Write(peca);
        }
        else
        {
            //Mudando a cor caso a peça for preta
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write(peca);
            Console.ForegroundColor = aux;
        }
    }
}