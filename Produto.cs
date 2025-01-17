public class Livro
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string Autor {get; set;}
    public string Genero {get; set;}

    public Livro(string nome, double preco, int estoque, string autor, string genero)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        Autor = Autor;
        Genero = Genero;
    }
}