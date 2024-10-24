
public class Biblioteca 
{
    public List<Livro> livros = new List<Livro>();
    public List<Usuario> usuarios  = new List<Usuario>();
    public int QuantidadeEmEstoque { get; set; }

    public void CadastrarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro {livro.Titulo} cadastrado com sucesso.");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        Console.WriteLine($"Usuário {usuario.Nome} cadastrado com sucesso.");
    }
    public void ListarLivros()
    {
        Console.WriteLine("Lista de livros: ");
        foreach (var livro in livros)
        {
            Console.WriteLine($"Titulo: {livro.Titulo} \n Autor: {livro.Autor} \n Quantidade em estoque: {livro.QuantidadeEmEstoque}");
        }
    }
    public void ListarUsuarios()
    {
        Console.WriteLine("Lista de Usuarios: ");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"Nome: {usuario.Nome} \n Numero identificador: {usuario.NumeroIdentificador }");
        }
    }
    public Livro BuscarLivroPorCodigo(string codigoLivro)
    {
       return livros.FirstOrDefault(livro => livro.Codigo == codigoLivro);
    }
    public void Emprestar(string usurario, string NumeroIdentificador)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
        }
    }
    
}