using System;
using System.Collections.Generic;

namespace ControleDeJogos
{
    class Program
    {
        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Controle de Jogos ===");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("[1] Cadastrar um jogo: ");
            Console.WriteLine("[2] Excluir um jogo");
            Console.WriteLine("[3] Alterar um jogo");
            Console.WriteLine("[4] Localizar um jogo por nome");
            Console.WriteLine("[5] Lista os jogos por Genero");
            Console.WriteLine("[6] Lista os jogos por Console");
            Console.WriteLine("[7] Listar todos os jogos");
            Console.WriteLine("[9] Sair");
            Console.Write("Opção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            List<Jogo> list;
            int opcao = 0;
            ListaDeJogos listaDeJogos = new ListaDeJogos();
            Jogo jogo = new Jogo(1, "Ty Runner", "Jogo de Corrida Infinita", TipoGenero.Aventura, TipoConsole.Outro);
            listaDeJogos.Inserir(jogo);
            jogo = new Jogo(2, "Jackpot", "Caça-niquel", TipoGenero.Casual, TipoConsole.Outro);
            listaDeJogos.Inserir(jogo);
            jogo = new Jogo(3, "Faroeste Zumbi", "Jogo de Tiro", TipoGenero.Acao, TipoConsole.PC);
            listaDeJogos.Inserir(jogo);
            while (opcao != 9)
            {
                opcao = ShowMenu();
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Inserir jogo");
                        jogo = new Jogo();
                        Console.Write("Id: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        jogo.Nome = (Console.ReadLine());
                        Console.Write("Descricao: ");
                        jogo.Descricao = (Console.ReadLine());
                        Console.Write("Informe o Genero Acao[0],Aventura[1], Puzzle[2], Estrategia[3], Casual[4], Outro[5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Console PS4[0], PS5[1], Switch[2], Xbox[3], Xbox360[4], XboxOne[5], PC[6], Outro[7]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listaDeJogos.Inserir(jogo))
                        {
                            Console.WriteLine("Jogo inserido!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao inserido!!!!!");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Excluir jogo");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (listaDeJogos.Excluir(id))
                        {
                            Console.WriteLine("Jogo excluido!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao excluido");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Alterar jogo");
                        jogo = new Jogo();
                        Console.Write("Id: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        jogo.Nome = (Console.ReadLine());
                        Console.Write("Descricao: ");
                        jogo.Descricao = (Console.ReadLine());
                        Console.Write("Informe o Genero Acao[0],Aventura[1], Puzzle[2], Estrategia[3], Casual[4], Outro[5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Console PS4[0], PS5[1], Switch[2], Xbox[3], Xbox360[4], XboxOne[5], PC[6], Outro[7]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listaDeJogos.Alterar(jogo))
                        {
                            Console.WriteLine("Jogo alterado!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao alterado!!!!!");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Localizar jogos");
                        Console.Write("Informe o nome do jogo: ");
                        string nomeJogo = Console.ReadLine();
                        list = listaDeJogos.Localizar(nomeJogo);
                        foreach (var j in list)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Listar todos os jogos por genero");
                        Console.Write("Informe o Genero Acao[0],Aventura[1], Puzzle[2], Estrategia[3], Casual[4], Outro[5]: ");
                        TipoGenero genero = (TipoGenero)(Convert.ToInt32(Console.ReadLine()));
                        list = listaDeJogos.ListarPorGenero(genero);
                        foreach (var j in list)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("Listar todos os jogos por console");
                        Console.Write("Informe o Console PS4[0], PS5[1], Switch[2], Xbox[3], Xbox360[4], XboxOne[5], PC[6], Outro[7]: ");
                        TipoConsole console = (TipoConsole)(Convert.ToInt32(Console.ReadLine()));
                        list = listaDeJogos.ListarPorConsole(console);
                        foreach (var j in list)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine("Listar todos os jogos");

                        foreach (var j in listaDeJogos.Jogos)
                        {
                            Console.Write("ID: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
