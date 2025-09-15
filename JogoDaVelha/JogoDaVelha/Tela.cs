namespace JogoDaVelha;
using Tabuleiro;

public class Tela //Criando a classe para poder mostrar o tabuleiro na tela
{
    public static void ImpirmirTabuleiro(Tabuleiro tab) // Criando o método para isto
    {
        for (int i = 0; i < tab.Linhas; i++)
        {
            for (int j = 0; j < tab.Colunas; j++)
            {
                if (tab.GetPeca(i,j) == null)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write($"{tab.GetPeca(i,j)} ");
                }
            }
            Console.WriteLine();
        }
    }
}