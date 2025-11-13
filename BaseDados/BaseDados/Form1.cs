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
            /*string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf";
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
            }*/
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
            string strConnection = "Server=localhost;Port=3306;Uid=root;Pwd=;";
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
            }

            #endregion

        }
    }
}
