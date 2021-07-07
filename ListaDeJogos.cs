using System.Collections.Generic;

namespace ControleDeJogos
{
    public class ListaDeJogos
    {
        private List<Jogo> jogos;
        public List<Jogo> Jogos
        {
            get
            {
                return jogos;
            }
        }
        public ListaDeJogos()
        {
            jogos = new List<Jogo>();
        }
        public bool Inserir(Jogo jogo)
        {
            bool resultado = true;
            try
            {
                Jogo jogo1 = jogos.Find(x => x.Id == jogo.Id);
                if (jogo1 == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (System.Exception)
            {

                resultado = false;
            }
            return resultado;
        }
        public List<Jogo> Localizar(string nome)
        {
            List<Jogo> list = jogos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return list;
        }
        public List<Jogo> ListarPorGenero(TipoGenero genero)
        {
            List<Jogo> list = jogos.FindAll(x => x.Genero.Equals(genero));
            return list;
        }
        public List<Jogo> ListarPorConsole(TipoConsole console)
        {
            List<Jogo> list = jogos.FindAll(x => x.Console.Equals(console));
            return list;
        }
        public bool Alterar(Jogo jogo)
        {
            bool resultado = false;
            Jogo jogo1 = jogos.Find(x => x.Id.Equals(jogo.Id));
            if (jogo1 != null)
            {
                jogo1.Nome = jogo.Nome;
                jogo1.Descricao = jogo.Descricao;
                jogo1.Genero = jogo.Genero;
                jogo1.Console = jogo.Console;

                resultado = true;
            }
            return resultado;
        }
        public bool Excluir(int id)
        {
            bool resultado = false;
            Jogo jogo = jogos.Find(x => x.Id == id);
            if (jogo != null)
            {
                resultado = jogos.Remove(jogo);
            }
            return resultado;
        }
    }
}
