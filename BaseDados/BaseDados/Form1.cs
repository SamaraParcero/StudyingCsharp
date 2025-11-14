using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados+ "; Password = '1234'";
            SqlCeEngine db = new SqlCeEngine(strConnection);

            if(!File.Exists(baseDados) )
            {
                db.CreateDatabase();
            }
            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            //conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();

                labelResultado.Text = "Conectado Sql Server CE";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar SQL Server CE \n"+ ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion

            #region SQLite
            /*
            string baseDados = Application.StartupPath + @"\DB\DBSQLite.db";
            string strConnection = @"DataSource = " + baseDados + "; Version = 3";
            
            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
            }

            SQLiteConnection conexao = new SQLiteConnection(strConnection);

            try
            {
                conexao.Open();

                labelResultado.Text = "Conectado ao SQLite";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar SQLite \n" + ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            /*string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;";
            MySqlConnection conexao = new MySqlConnection(strConnection);
 
            try
            {
                conexao.Open();

                labelResultado.Text = "Conectado ao MySQL";

                //Criar banco 
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";

                comando.ExecuteNonQuery();
                labelResultado.Text = "Base de dados criada com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar MySQL \n" + ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/

            #endregion

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            #region SqlServerCe
            /*
             string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
             string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";
             SqlCeConnection conexao = new SqlCeConnection(strConnection);
             try
             {
                 conexao.Open();

                 SqlCeCommand comando = new SqlCeCommand();
                 comando.Connection = conexao;
                 comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                 comando.ExecuteNonQuery();
                 labelResultado.Text = "Tabela Criada ";
             }
             catch (Exception ex)
             {
                 labelResultado.Text = ex.Message;
             }
             finally
             {
                 conexao.Close();
             }*/
            #endregion

            #region SQLite
            /*
            //Para SQLite
            string baseDados = Application.StartupPath + @"\DB\DBSQLite.db";
            string strConnection = @"DataSource = " + baseDados + "; Version = 3";
            SQLiteConnection conexao = new SQLiteConnection(strConnection);
            try
            {
                conexao.Open();
                //Para SQL Ce
                //SqlCeCommand comando = new SqlCeCommand();
                //Para SQLite
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;   
                comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Tabela Criada ";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region MySql
            string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;database=curso_db";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();
               
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Tabela Criada MySQL ";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQLServerCe
            /*
            string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";
            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                comando.CommandText = "INSERT INTO pessoas VALUES("
                    + id+", '"+
                    nome+ "', '" +
                    email+"' )";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registro inserido";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*
            string baseDados = Application.StartupPath + @"\DB\DBSQLite.db";
            string strConnection = @"DataSource = " + baseDados + "; Version = 3";
            SQLiteConnection conexao = new SQLiteConnection(strConnection);
            try
            {
                conexao.Open();
                //Para SQL Ce
                //SqlCeCommand comando = new SqlCeCommand();
                //Para SQLite
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                comando.CommandText = "INSERT INTO pessoas VALUES("
                    + id + ", '" +
                    nome + "', '" +
                    email + "' )";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registros inseridos";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            
            string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;database=curso_db";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                comando.CommandText = "INSERT INTO pessoas VALUES("
                    + id + ", '" +
                    nome + "', '" +
                    email + "' )";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registros Encontrados";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            lista.Rows.Clear();
            #region SQLServerCe
            /*
            string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";
            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            try
            {
                string query = "SELECT * FROM PESSOAS";

                if(txtNome.Text != "")
                {
                    query = "SELECT * FROM PESSOAS WHERE nome LIKE '" + txtNome.Text+ "'";
                }

                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, conexao);
                conexao.Open();

                //Enche os dados na tabela
                adaptador.Fill(dados);
                foreach(DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }

               
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();    
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*
            string baseDados = Application.StartupPath + @"\DB\DBSQLite.db";
            string strConnection = @"DataSource = " + baseDados + "; Version = 3";
            SQLiteConnection conexao = new SQLiteConnection(strConnection);
            try
            {
                string query = "SELECT * FROM PESSOAS";

                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM PESSOAS WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConnection);
                conexao.Open();

                //Enche os dados na tabela
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            
            string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;database=curso_db";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                string query = "SELECT * FROM PESSOAS";

                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM PESSOAS WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);
                conexao.Open();

                //Enche os dados na tabela
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SQLServerCe
            /*
            string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";
            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                
                comando.CommandText = "DELETE FROM pessoas WHERE id = '"+ id+"'";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registro Excluido";
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*
            string baseDados = Application.StartupPath + @"\DB\DBSQLite.db";
            string strConnection = @"DataSource = " + baseDados + "; Version = 3";
            SQLiteConnection conexao = new SQLiteConnection(strConnection);
            try
            {
                conexao.Open();
                //Para SQL Ce
                //SqlCeCommand comando = new SqlCeCommand();
                //Para SQLite
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registro Excluido";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            
            string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;database=curso_db";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registros inseridos";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region SQLServerCe
            /*
            string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";
            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

                comando.CommandText = query;
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registro Alterado";
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region SQLite
            /*
            string baseDados = Application.StartupPath + @"\DB\DBSQLite.db";
            string strConnection = @"DataSource = " + baseDados + "; Version = 3";
            SQLiteConnection conexao = new SQLiteConnection(strConnection);
            try
            {
                conexao.Open();
                //Para SQL Ce
                //SqlCeCommand comando = new SqlCeCommand();
                //Para SQLite
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registro Alterado";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }*/
            #endregion

            #region MySQL
            
            string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;database=curso_db";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                labelResultado.Text = "Registros inseridos";
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
