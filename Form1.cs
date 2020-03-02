using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //--SQL

namespace Beadandó200212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
            
            TestInit();
        }

        private void btnAddDisco_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void btnAddURL_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void btnEditSelect_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void Test()
        {
            MessageBox.Show("Soon(TM).","Test");
        }

        private void TestInit()
        {
            pbAlbum.Image = Beadandó200212.Properties.Resources.homv;
            /*
            string connectionString;
            OleDbConnection cnn;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Users\csernakt\Documents\Beadandó.accdb;Persist Security Info=False;";
            cnn = new OleDbConnection(connectionString);
            cnn.Open();
            cnn.Close();
            */
        }
    }
}
