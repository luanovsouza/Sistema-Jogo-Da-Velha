namespace Xadrez;
using Tabuleiro;

public class PartidaXadrez
{
    public Tabuleiro? Tab { get; private set; }
    private int _turno;
    private Cor _jogadorAtual;

    public PartidaXadrez()
    {
        Tab = new Tabuleiro(8, 8);
        _turno = 1;
        _jogadorAtual = Cor.Branca;
        ColocarPecas();
    }


    public void ExecutarMovimento(Posicao origem, Posicao destino)
    {
        var p = Tab?.RetirarPeca(origem);
        p.AdicionarQteMovimento();
        
        var pecaCapturada = Tab.RetirarPeca(destino);
        Tab.ColocarPeca(p, destino);
    }


    private void ColocarPecas()
    {
        //Peças brancas
        
        //Torres
        Tab.ColocarPeca(new Torre(Cor.Branca, Tab),new PosicaoXadrez('c', 1).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Branca, Tab),new PosicaoXadrez('c', 2).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Branca, Tab),new PosicaoXadrez('d', 2).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Branca, Tab),new PosicaoXadrez('e', 2).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Branca, Tab),new PosicaoXadrez('e', 1).ToPosicao());
        
        //Rei
        Tab.ColocarPeca(new Rei(Cor.Branca, Tab),new PosicaoXadrez('d', 1).ToPosicao());
        
        //Peças Pretas
        
        
        Tab.ColocarPeca(new Torre(Cor.Preta, Tab),new PosicaoXadrez('c', 8).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Preta, Tab),new PosicaoXadrez('c', 7).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Preta, Tab),new PosicaoXadrez('d', 7).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Preta, Tab),new PosicaoXadrez('e', 7).ToPosicao());
        Tab.ColocarPeca(new Torre(Cor.Preta, Tab),new PosicaoXadrez('e', 8).ToPosicao());
        
        //Rei
        Tab.ColocarPeca(new Rei(Cor.Preta, Tab),new PosicaoXadrez('d', 8).ToPosicao());
    }
}