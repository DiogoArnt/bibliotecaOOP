
public class Usuario
{
    public string Nome {get; set;}
    public string NumeroIdentificador {get; set;}
    public string Endereco {get; set;}
    public string Contato {get; set;}
    private List<Livro> HistoricoEmprestimos = new List<Livro>();

    public Usuario(string nome, string numeroIdentificador, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificador = numeroIdentificador;
        Endereco = endereco;
        Contato = contato;
    }
    public void ExibirInformacoes(string numeroIdentificador)
    {
        Console.WriteLine($"Nome: {Nome} \n Identificador: {NumeroIdentificador} \n Endereço: {Endereco} \n Contato: {Contato}");
    }
    public void AdicionarAoHistorico(Livro livro)
    {
        HistoricoEmprestimos.Add(livro);
        Console.WriteLine();
    }
}