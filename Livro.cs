
public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int quantidadeEmEstoque)
        : base(titulo, codigo)
        {
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }
    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
        QuantidadeEmEstoque = QuantidadeEmEstoque -1;
        Console.WriteLine($"O livro {Titulo} foi emprestado com sucesso para {usuario.Nome}!");
        }else 
        {
            Console.WriteLine($"Não temos o livro {Titulo} em estoque, volte mais tarde e tente novamente");
        }
    }
    public override void Devolver()
    {
        QuantidadeEmEstoque = QuantidadeEmEstoque + 1;
        Console.WriteLine($"O livro {Titulo} foi devolvido com sucesso!");
    }
    public List<Livro> PesquisarPorTitulo(string titulo, List<Livro> livros)
    {
        return livros.Where(livro => livro.Titulo.Contains(titulo)).ToList();
    }
    public List<Livro> PesquisarPorAutor(string autor, List<Livro> livros)
    {
        return livros.Where(livro => livro.Autor.Contains(autor)).ToList();

    }
    public List<Livro> PesquisarPorGenero(string genero, List<Livro> livros)
    {
        return livros.Where(livro => livro.Genero.Contains(genero)).ToList();
    }

}   