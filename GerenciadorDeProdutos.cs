public class GerenciadorLivros
{
    private Livro[] livros = new Livro[0];

    public void Adicionar(Livro novo)
    {
        
        Livro[] listaNova = new Livro[this.livros.Length + 1];
        for (int i = 0; i < this.livros.Length; i++)
        {
            listaNova[i] = this.livros[i];
        }
        listaNova[livros.Length] = novo;

        this.livros = listaNova;
    }

    public void Exibir()
    {
        int qtd = 0;
        foreach (Livro item in this.livros)
        {
            Console.WriteLine($"{++qtd}. {item.Nome} (R$ {item.Preco}) - Estoque: {item.Estoque}");
        }
    }

    public void Remover(int posicao)
    {
        if (posicao < 1 || posicao > this.livros.Length)
        {
            Console.WriteLine("Posição inválida!");
            return;
        }
        Livro[] listaNova = new Livro[this.livros.Length - 1];
        int index = 0;

        for (int i = 0; i < this.livros.Length; i++)
        {
            if (i != posicao - 1)
            {
                listaNova[index++] = this.livros[i];
            }
        }

        this.livros = listaNova;
        Console.WriteLine("Livro removido com sucesso!");
    }

    public void EstoqueEntrada(int posicao, int qtd)
    {
        if (posicao < 1 || posicao > this.livros.Length)
        {
            Console.WriteLine("Posição inválida!");
            return;
        }
        Livro livro = this.livros[posicao-1];
        livro.Estoque += qtd;
        Console.WriteLine($"{qtd} unidades de {livro.Nome} adicionadas ao estoque.");
    }

    public void EstoqueSaida(int posicao, int qtd)
    {
        if (posicao < 1 || posicao > this.livros.Length)
        {
            Console.WriteLine("Posição inválida!");
            return;
        }

        Livro livro = this.livros[posicao - 1];

        if (livro.Estoque >= qtd)
        {
            livro.Estoque -= qtd;
            Console.WriteLine($"{qtd} unidades de {livro.Nome} retiradas do estoque.");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente!");
        }
    }
    


}