// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices.Marshalling;
using estudo_sozinho.models;

class Program
{
  static void Main(string[] args)
  {
    List<Autor> autores = new List<Autor>();
    List<Livro> livros = new List<Livro>();

    bool continuar = true;

    while (continuar)
    {
      Console.WriteLine("\n --- MENU BIBLIOTECA --- ");
      Console.WriteLine("\n1. Cadastrar Autores");
      Console.WriteLine("2. Cadastrar Livros");
      Console.WriteLine("3. Listar Autores");
      Console.WriteLine("4. Listar Livros");
      Console.WriteLine("5. Sair");
      Console.WriteLine("\n --- Escolha uma opção! ---");

      string opcao = Console.ReadLine();

      switch (opcao)
      {
        case "1":
          Console.WriteLine("\n:D === Digite o nome do autor ou 0 para cancelar: ===");
          string nomeAutor = Console.ReadLine();
          if (nomeAutor == "0")
          {
            Console.WriteLine("\n:| == Cadastro de autor cancelado === ");
            break;
          }
          if (string.IsNullOrWhiteSpace(nomeAutor))
          {
            Console.WriteLine("\n:( --- Nome do autor não pode ser vazio !!! --- ");
          }
          else
          {
            autores.Add(new Autor(nomeAutor));
            Console.WriteLine("\n:) +++ Autor cadastrado com sucesso! +++ ");
          }

          break;

        case "2":
          if (autores.Count == 0)
          {
            Console.WriteLine("\n:( --- Cadastre um autor antes de cadastrar um livro !!! --- ");
            break;
          }

          Console.WriteLine("\n=== Digite o titulo do livro ou 0 para cancelar: === ");
          string titulolivro = Console.ReadLine();

          if (titulolivro == "0")
          {
            Console.WriteLine("\n:| === Cadastro de livro cancelado. === ");
            break;
          }

          if (string.IsNullOrWhiteSpace(titulolivro))
          {
            Console.WriteLine("\n:( --- Nome do livro não pode ser vazio! !!! --- ");
            break;
          }

          Console.WriteLine("\n --- Selecione o autor pelo número: --- ");
          for (int i = 0; i < autores.Count; i++)
          {
            Console.WriteLine($"{i + 1}. {autores[i].Nome}");
          }

          int escolhaAutor = int.Parse(Console.ReadLine());
          if (escolhaAutor < 1 || escolhaAutor > autores.Count)
          {
            Console.WriteLine("\n:( --- Autor inválido. !!! --- ");
            break;
          }

          Autor autorSelecionado = autores[escolhaAutor - 1];
          livros.Add(new Livro(titulolivro, autorSelecionado));
          Console.WriteLine("\n:) +++ Livro cadastrado com sucesso! +++ ");
          break;

        case "3":
          if (autores.Count == 0)
          {
            Console.WriteLine("\n:( --- Nenhum autor cadastrado !!! --- ");
          }
          else
          {
            Console.WriteLine("\n*** Autores Cadastrados ***");
            foreach (var autor in autores)
            {
              Console.WriteLine($"\n ID: {autor.Id} - Nome: {autor.Nome}");
            }
          }
          break;

        case "4":
          if (livros.Count == 0)
          {
            Console.WriteLine("\n:( --- Nenhum livro cadastrado !!! --- ");
          }
          else
          {
            Console.WriteLine("\n*** Livros Cadastrados ***");
            foreach (var livro in livros)
            {
              Console.WriteLine($"\nID: {livro.Id} - Título: {livro.Titulo} - Autor: {livro.Autor.Nome}");
            }
          }
          break;

        case "5":
          continuar = false;
          Console.WriteLine("\n--- Encerrando o sistema... --- ");
          break;

        default:
          Console.WriteLine("\n:0 --- Opção inválida. Tente novamente !!! --- ");
          break;
      }

    }

  }
}
