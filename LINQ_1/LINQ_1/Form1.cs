using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;

        public Form1()
        {
            InitializeComponent();
            #region Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Samara");
            lista_nomes.Add("pedro");
            lista_nomes.Add("Wilson");
            lista_nomes.Add("Lilian");
            lista_nomes.Add("Maria");
            lista_nomes.Add("Lucia");

            #endregion

            #region Numeros
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(8);
            lista_numeros.Add(25);
            lista_numeros.Add(88);
            lista_numeros.Add(33);
            #endregion

            #region Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Camisa", 50.2);
            lista_produtos.Add("Vassoura", 40.50);
            lista_produtos.Add("Console", 3000);
            lista_produtos.Add("Microfone", 200.25);
            lista_produtos.Add("Livro", 72.99);
            lista_produtos.Add("Bolsa", 359.99);

            #endregion

            #region Estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de janeiro", "Brasil");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Espirito Santo", "Brasil");
            lista_estados.Add("Amazonas", "Brasil");
            lista_estados.Add("Paraná", "Brasil");
            lista_estados.Add("Toledo", "Espanha");
            lista_estados.Add("Michegan", "Eua");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            /*
            //Metodo comum
            foreach (int num in lista_numeros)
            {
                if (num % 2 == 0)
                {
                    lista.Items.Add(num);
                }
            }*/
            //Consultas LINQ

            //Obter fonte de dados
            //Criar a consulta
            //Executar a consulta

            //From
            //where
            //select
            //PAra cada numero em lista_numeros pegue os que retornnarem resto 0
            //Obter fonte
            /*
            IEnumerable<int> res =from num in lista_numeros where num % 2 == 0 select num; // -> Tipo Enumerable

            foreach(int n in res)
            {
                lista.Items.Add(n);
            }*/

            //Consulta
            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes 
                                       where nome.StartsWith(txt)
                                       select nome;

            lista.Items.AddRange(res2.ToArray());

            /*
            foreach(string n in res2)
            {
                lista.Items.Add(n);
            }*/





        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Operador de filtragem, a clausula where
            string txt = txtConsulta.Text.ToLower();
            var res = from nome in lista_nomes 
                      where nome.ToLower().Contains(txt)// Condição que os nomes passem para serem selecionados
                      select nome;

            foreach(var item in res)
            {
                lista.Items.Add(item);
            }
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            //Operador de ordenação
            lista.Items.Clear();
            string txt = txtConsulta.Text;

            //ordena do menor para maior
            var res = from num in lista_numeros orderby num where num <= 50 select num;

            //ordena do maior para o menor
            var res2 = from num in lista_numeros orderby num descending select num;

            //Com o dicionário
            var res3 = from produto in lista_produtos orderby produto.Key select produto;

            /*
            foreach (var n in res2)
            {
                lista.Items.Add(n);
            }*/

            foreach (KeyValuePair<string, double> item in res3)
            {
                lista.Items.Add(item.Key + " R$ " + item.Value);
            }


        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            //Operadores de argumentos
            lista.Items.Clear();
            txtConsulta.Text = "";
            var res = from estado in lista_estados
                      group estado by estado.Value;

            foreach (var grupo in res)
            {
                //Grupos de países
                lista.Items.Add(grupo.Key);
                //Percorrer estados
                foreach( var estado in grupo)
                {
                    lista.Items.Add(" " + estado.Key);
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {/*
            int cont1 = lista_nomes.Count;
            //Nomes começando com letra S -> Count na consulta Linq
            int cont2 = (from nomes in lista_nomes where nomes.StartsWith("S") select nomes).Count();
            lista.Items.Add(cont1 + " nomes.");
            lista.Items.Add(cont2 + " nomes começando com letra S.");

            double media1 = lista_numeros.Average();
            lista.Items.Add(media1 + " média dos valores na lista de números");

            //Média na consulta linq
            var res1 = from num in lista_numeros where num < 50 select num;
            double media2 = res1.Average();
            lista.Items.Add(media2 + "  média dos menores que 50");

            int soma1 = lista_numeros.Sum();
            lista.Items.Add(soma1+ "  soma dos valores");

            //Soma na consulta linq
            var res2 = from num in lista_numeros where num < 50 select num;
            int soma2 = res2.Sum();
            lista.Items.Add(soma2 + "  soma dos valores menores que 50");
            */

            //Também a plicáveis a consulta
            lista.Items.Add(lista_numeros.Min() + " valor mínimo em lista de números");
            lista.Items.Add(lista_numeros.Max() + " valor máximo em lista de números");

            //Também a plicáveis a consulta-> Contagem na lista 
            long contagem = lista_numeros.LongCount();

            //O aggregate decide qual valor retornar
            string maiorNome = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) => {
                if (maior.ToString().Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
            });

            lista.Items.Add(maiorNome + " é o maior nome da lista");

            


        }

        private void btnElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Primeiro da lista -> Também aplicavel em consulta
            int primeiro = lista_numeros.FirstOrDefault();//-> Para que se a lista estiver vazia não der erro
            lista.Items.Add(primeiro);

            //Ultimo da lista -> Também aplicavel em consulta
            int ultimo = lista_numeros.LastOrDefault();//-> Retorna 0 se estiver vazia 
            lista.Items.Add(ultimo);

            //Retorna elemento na posição 3
            int elemento = lista_numeros.ElementAtOrDefault(3);//-> Retorna 0 se estiver vazia 
            lista.Items.Add(elemento);

            var consulta = from num in lista_numeros where num > 1000 select num;
            int n = consulta.FirstOrDefault();
            lista.Items.Add(n);


        }

        private void btnLinqLambda_Click(object sender, EventArgs e)
        {
            //Métodos Lambdas que facilitam as consultas LINQ
            //Comum - Select
           // var cons1 = from nome in lista_nomes select nome;
            //lista.Items.AddRange(cons1.ToArray());

            //Lambda - Select
            var cons1 = lista_nomes.Select(nome => nome);
            //lista.Items.AddRange(cons1.ToArray());

            //Comum - Where
            //var cons2 = from nome in lista_nomes where nome.StartsWith("S") select nome;

            //Lambda - Where
            var cons2 = lista_nomes.Where(nome => nome.StartsWith("S"));
            lista.Items.AddRange(cons2.ToArray());

            //Comum - OrderBy
            //var cons3 = from nome in lista_nomes orderby nome select nome;

            //Lambda - OrderBy
            var cons3 = lista_nomes.OrderBy(nome => nome);
            //Descending
            var cons4 = lista_nomes.OrderByDescending(nome => nome);
            lista.Items.AddRange(cons3.ToArray());

            //Comum - GroupBy
            var cons5 = from estado in lista_estados group estado by estado.Value;

            //Lambda - GroupBy
            var cons6 = lista_estados.GroupBy(estado => estado.Value);
            foreach (var grupo in cons6)
            {
                lista.Items.Add(grupo.Key);
                foreach(var estado in grupo)
                {
                    lista.Items.Add(" " + estado.Key);
                }
            }
        }
    }
}
