public interface IPesquisavel
{
    List<Livro> PesquisarPorTitulo(string titulo, List<Livro> livros);
    List<Livro> PesquisarPorAutor(string autor, List<Livro> livros);
    List<Livro> PesquisarPorGenero(string genero, List<Livro> livros);
}