using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //Array
            string[] nomes = new string[3];
            nomes[0] = "Sas";
            nomes[1] = "Samie";
            nomes[2] = "Sami";

            //Lista
            List<string> nomes2 = new List<string>();
            nomes2.Add("Samara");
            nomes2.Add("Sam");
            
            //Adiciona uma coleção a lista
            nomes2.AddRange(nomes);

            //Remover elementos
            /*if(nomes2.Remove("Sami"))
            {
                MessageBox.Show("Removido!");
            }
            else
            {
                MessageBox.Show("Não foi removido!");
            }

            //Lista contém o item?
            string mensagem = nomes2.Contains("Danny") ? "Contém" : "Não contém!";
            MessageBox.Show(mensagem);*/

            //Contar elementos
            //MessageBox.Show("Número de elementos: " + nomes2.Count);

            //Organiza lista em ordem alfabética
            nomes2.Sort();

            //Saber indice de um elemento
            //MessageBox.Show("Sam está no indice " + nomes2.IndexOf("Sam"));

            //Adicionar elemento num indice específico
            nomes2.Insert(2, "Pedro");

            //Remover item de um indice
            nomes2.RemoveAt(1);

            //Limpa a lista toda
            //nomes2.Clear();

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
     

        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //É uma lista que não aceita repetições
            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Helicoptero", "Avião", "Barco"
            };

            //Para acessar o indice em HashSet
            MessageBox.Show(veiculos.ElementAt(2));

            /*if (veiculos.Add("Cavalo"))
            {
                MessageBox.Show("Item adicionado!");
            } else
            {
                MessageBox.Show("Não adicionado!");
            }

            if (veiculos.Contains("Carro"))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não Contém");
            }*/

            //veiculos.Remove("Barco");
            //int num = veiculos.Count;

            //veiculos.Clear();

            //Retorna primeiro elemento
            //veiculos.First();

            //Retorna último elemento
            //veiculos.Last();

            foreach (string veiculo in veiculos)
            {
                lista.Items.Add(veiculo);
            }
            
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Pedro" },
                {200, "Lilian" },
                {80, "Pedro" }
            };

            //Não pode repetir chave
            alunos.Add(100, "Samara");


            //Remove item
            alunos.Remove(80);


            //Quantidade de elementos
            MessageBox.Show("Quantidade de alunos: " + alunos.Count);

            //Limpa o dictionary
            //alunos.Clear();

            //Mostra primeiro item:
            MessageBox.Show("Primeiro: " + alunos.First().Value);

            KeyValuePair<int, string> primeiro = alunos.First();
            MessageBox.Show("Primeiro: " + primeiro.Value);

            //Mostra o ultimo
            KeyValuePair<int, string> ultimo = alunos.Last();
            MessageBox.Show("Ultimo: " + ultimo.Value);

            //Vê Se contem essa chave
            if (alunos.ContainsKey(80))
            {
                MessageBox.Show("Contém a chave 80");
            }
            else
            {
                MessageBox.Show("Não contém a chave 80");
            }

            //Vê Se contem esse valor
            if (alunos.ContainsValue("Samara"))
            {
                MessageBox.Show("Contém o aluno");
            }
            else
            {
                MessageBox.Show("Não contém o aluno");
            }


            foreach (KeyValuePair<int, string> item in alunos)
                {
                    //Se eu quiser pegar somente a key
                    lista.Items.Add(item.Key);
                    //Se eu quiser pegar somente o valor
                    lista.Items.Add(item.Value);

                    lista.Items.Add(item.Key + " = " + item.Value);
                }



        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Uma dictionary que organiza os items baseado na key
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {27, "Danny" },
                {10, "Gabriel" },
                {17, "Arthir" }
            };

            alunos.Add(14, "Gloria");
            //Apresenta na ordem reversa com o Reverse
            //alunos.Reverse();

            //Remove item da sortedList 
            alunos.Remove(10);

            //Remove baseado no indice conforme a ordem da lista
            alunos.RemoveAt(0);

            //alunos.Count;

            //alunos.ContainsKey(50);

            //alunos.ContainsValue("Danny");

            foreach (KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item.Key + " " + item.Value);  
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>
            {
                {20,"Samara" },
                {300, "Wesley" },
                {123, "Silvana" }
            };

            alunos.Add(5478, "Flavio");
            alunos.Remove(20);
            //alunos.Count;
            //alunos.Clear();
            MessageBox.Show(alunos.ElementAt(0).ToString());

            alunos.ContainsKey(5478);
            alunos.ContainsValue("Flavio");
            foreach(KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Samara",
                "Parcero",
                "Oliveira"
            };

            if (!nomes.Add("Samara"))
            {
                MessageBox.Show("Não pode repetir valor");
            }

            //nomes.Reverse();
            nomes.Remove("Oliveira");
            //MessageBox.Show(nomes.ElementAt(1));
            MessageBox.Show(nomes.First());
            MessageBox.Show(nomes.Last());
            MessageBox.Show(nomes.Count.ToString());
            //nomes.Clear();

            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Queue<string> fila = new Queue<string>();

            //Enfileirar
            fila.Enqueue("Samara");
            fila.Enqueue("Pedro");
            fila.Enqueue("Lilian");

            MessageBox.Show(fila.Count.ToString());

            foreach(string nome in fila)
            {
                lista.Items.Add(nome);
            }

            //Retorna objeto no início da fila sem remover
            MessageBox.Show("Primeiro da fila: "+ fila.Peek());

            //Retira o primeiro objeto da fila
            MessageBox.Show("Remover do início: " + fila.Dequeue());


            //Retorna objeto no início da fila 
            MessageBox.Show("Primeiro da fila: " + fila.First());

            //Retorna objeto no fim da fila 
            MessageBox.Show("Último da fila: " + fila.Last());

            //fila.Clear();

            while (fila.Count > 0)
            {
                //Retira o primeiro objeto da fila
                MessageBox.Show("Remover do início: " + fila.Dequeue());
                MessageBox.Show("Contagem: " + fila.Count.ToString());
                lista.Items.Clear();
                foreach (string nome in fila)
                {
                    lista.Items.Add(nome);
                }
            }

        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Samara");
            pilha.Push("Pedro");
            pilha.Push("Lilian");

            MessageBox.Show(pilha.Count.ToString());

            foreach(string nome in pilha)
            {
                lista.Items.Add(nome);  
            }

            MessageBox.Show("Elemento no topo da pilha: " + pilha.Peek());
            MessageBox.Show(pilha.Count.ToString());

            MessageBox.Show("Remover elemento do topo: " + pilha.Pop());
            MessageBox.Show(pilha.Count.ToString());

            while (pilha.Count > 0)
            {
                //Retira o topo da pilha
                MessageBox.Show("Remover do início: " + pilha.Pop());
                MessageBox.Show("Contagem: " + pilha.Count.ToString());
                lista.Items.Clear();
                foreach (string nome in pilha)
                {
                    lista.Items.Add(nome);
                }
            }

        }
    }
}
