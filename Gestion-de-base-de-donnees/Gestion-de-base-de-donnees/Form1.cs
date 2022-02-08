using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_de_base_de_donnees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection log = DBUtils.GetDBCOnnection();
        bool isConnected = false;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (isConnected==true)
            {
                closeSrv();
            }
            else
            {
                openSrv();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreation.Enabled = false;
            btnCreation.Visible = false;
        }

        public void openSrv()
        {
            try
            {
                btnLogin.Text = "connexion en cours...";
                log.Open();
                btnLogin.Text = "Déconnexion";
                btnCreation.Enabled = true;
                btnCreation.Visible = true;
                isConnected = true; 
            }
            catch
            {
                MessageBox.Show("vous n'avez pas réussi a vous connecter");
            }
        }

        public void closeSrv()
        {
            try
            {
                btnLogin.Text = "déconnexion en cours...";
                log.Close();
                btnLogin.Text = "Connexion";
                btnCreation.Enabled = false;
                btnCreation.Visible = false;
                isConnected = false;
            }
            catch
            {
                MessageBox.Show("vous n'avez pas réussi a vous connecter");
            }
        }

        public void createDB(string dbName)
        {
            String query;

            query = "CREATE DATABASE " + dbName;

            MySqlCommand myCommand = new MySqlCommand(query, log);
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void deleteDB(string dbName)
        {
            String query;

            query = "DROP DATABASE " + dbName;

            MySqlCommand myCommand = new MySqlCommand(query, log);
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Deleted Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCreation_Click(object sender, EventArgs e)
        {
            createDB(txtbxDBName.Text);
        }

        private void BtnDeleteDB_Click(object sender, EventArgs e)
        {
            deleteDB(txtbxDBName.Text);
        }
    }
}
