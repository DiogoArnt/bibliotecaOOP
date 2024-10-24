Biblioteca biblioteca = new Biblioteca();

            // Cadastrando alguns livros
Livro livro1 = new Livro("O Senhor dos Anéis", "001", "J.R.R. Tolkien", "978-3-16-148410-0", "Fantasia", 5);
Livro livro2 = new Livro("1984", "002", "George Orwell", "978-0-452-28423-4", "Distopia", 3);

biblioteca.CadastrarLivro(livro1);
biblioteca.CadastrarLivro(livro2);

             // Cadastrando alguns usuários
Usuario usuario1 = new Usuario ("Diogo Caran Arnt", "001", "venancio aires, 1170", "diogoarnt@hotmail.com");
Usuario usuario2 = new Usuario("Ivan Dalpiaz", "002", "Av Paraguasú, 1345", "ivantd10@yahoo.com.br");

biblioteca.CadastrarUsuario(usuario1);
biblioteca.CadastrarUsuario(usuario2);

            // Exibindo lista de livros cadastrados
biblioteca.ListarLivros();

            // Exibindo lista de usuários cadastrado
biblioteca.ListarUsuarios();

            // Emprestando um livro para um usuário
Console.WriteLine("\nEmprestando o livro 'O Senhor dos Anéis' para Diogo");
biblioteca.Emprestar(usuario1.Nome, usuario1.NumeroIdentificador);

Console.WriteLine("\nEmprestando o livro '1984' para Ivan");
biblioteca.Emprestar(usuario2.Nome, usuario2.NumeroIdentificador);