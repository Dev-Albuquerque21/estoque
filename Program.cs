namespace pti;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorLivros ger = new GerenciadorLivros();
        MostrarMenu(ger);
    }
    static void MostrarMenu(GerenciadorLivros ger)
    {
      while(true)
      {
        Console.Clear();
        Console.WriteLine("==========Menu==========");
        Console.WriteLine("[1]Novo");
        Console.WriteLine("[2]Listar Produtos");
        Console.WriteLine("[3]Remover Produtos");
        Console.WriteLine("[4]Entrada de estoque");
        Console.WriteLine("[5]Saída de estoque");
        Console.WriteLine("[0]Saír");
        Console.WriteLine("========================");
        Console.WriteLine("Escolha uma opção:");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                AdicionarProduto(ger);
                break;
            case 2:
                ger.Exibir();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                break;
            case 3:
                RemoverProduto(ger);
                break;
            case 4:
                EntradaEstoque(ger);
                break;
            case 5:
                SaidaEstoque(ger);
                break;
            case 0:
                Console.WriteLine("Saindo do programa...");
                return;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
      }    
    }
    static void AdicionarProduto(GerenciadorLivros ger)
    {
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o autor:");
        string autor = Console.ReadLine();
        Console.Write("Informe o gênero:");
        string genero = Console.ReadLine();
        Console.Write("Digite a quantidade no estoque: ");
        int estoque = Convert.ToInt32(Console.ReadLine());

        Livro livro = new Livro(nome, preco, estoque, autor, genero);
        ger.Adicionar(livro);
        Console.WriteLine("Produto adicionado com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    static void RemoverProduto(GerenciadorLivros ger)
    {
        Console.Write("Digite o número do produto a ser removido: ");
        int posicao = Convert.ToInt32(Console.ReadLine());

        ger.Remover(posicao);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    static void EntradaEstoque(GerenciadorLivros ger)
    {
        Console.Write("Digite o número do produto para entrada de estoque: ");
        int posicao = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quantidade a ser adicionada: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        ger.EstoqueEntrada(posicao, quantidade);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    static void SaidaEstoque(GerenciadorLivros ger)
    {
        Console.Write("Digite o número do produto para saída de estoque: ");
        int posicao = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quantidade a ser retirada: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        ger.EstoqueSaida(posicao, quantidade);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}
