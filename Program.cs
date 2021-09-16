using System;

namespace DIO.Musica
{
    class Program
    {
        static MusicaRepositorio repositorio = new MusicaRepositorio();
        static void Main(string[] args)
        {
          
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                case "1":
                    ListarMusica();
                    break;
                case "2":
                    InserirMusica();
                    break;
                case "3":
                    AtualizarMusica();
                    break;
                case "4":
                   ExcluirMusica();
                    break;
                case "5":
                    VisualizarMusica();
                    break;
                case "C":
                    Console.Clear();
                    break;

                default:
                throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpcaoUsuario();
        }
        Console.WriteLine("Obrigada por utilizar nossos servicos");
        Console.ReadLine();
        }

        private static void ExcluirMusica()
        {
            Console.Write("Digite o id da musica: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceMusica)
        }

        private static VisualizarMusica()
        {
            Console.Write("Digite o id da musica: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceMusica);

            Console.WriteLine(musica);
        }
            private static void AtualizarMusica()
            {
                Console.WriteLine("Digite o id da musica");
                int indiceMusica = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Genero)));
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o genero entre as opcoes acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo da musica: ");
                string entradaTitulo = int.Parse(Console.ReadLine());

                Console.Write("Digite o ano em que foi lancada: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome da banda: ");
                string entradaBanda = int.Parse(Console.ReadLine());
            
            }
            private static void ListarMusica()
            {
                Console.WriteLine("Listar Musicas");

                var lista = repositorio.Lista();

                if (lista.Count -- 0)
                {
                    Console.WriteLine("Nenhuma musica cadastrada.")
                    return;
                }
                foreach (var musica in lista)
                {
                    var excluido = musica.retornaExcluido();

                    Console.WriteLine ("#ID {0}: - {1} - {2}", musica.retornaId(), musica.retornaTitulo(), (excluido ? "Excluido" : ""));
                    
                }
    
            }

            private static void InserirMusica()
            {
                Console.WriteLine("Inserir nova musica");

                foreach (int i in Enum.GetValues(typeog(Genero)));
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o genero entre as opcoes acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo da musica: ");
                string entradaTitulo = int.Parse(Console.ReadLine());

                Console.Write("Digite o ano em que foi lancada: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome da banda: ");
                string entradaBanda = int.Parse(Console.ReadLine());

                Musica atualizaMusica = new Musica(id: indiceMusica,
                                                genero: (Genero)entradaGenero,
                                                titulo: entradaTitulo,
                                                ano: entradaAno,
                                                banda: entradaBanda);

                repositorio.Insere(novaMusica);                                
                }


        private static string ObterOpcaoUsuario()
         { 
             Console.WriteLine();
             Console.WriteLine("DIO Musicas a seu dispor!");
             Console.WriteLine("Informe a opção desejada: ")ç

             Console.WriteLine("1- Lista Musicas");
             Console.WriteLine("2- Inserir nova musica");
             Console.WriteLine("3- Atualizar musica");
             Console.WriteLine("4- Excluir musica");
             Console.WriteLine("5- Visualizar musica");
             Console.WriteLine("C- Limpar tela");
             Console.WriteLine("X- Sair ");
             Console.WriteLine();

             string opcaoUsuario = Console.ReadLine().ToUpper();
             Console.WriteLine()
             return opcaoUsuario

    

         }
    
    }

}
