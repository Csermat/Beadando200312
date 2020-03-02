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
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a database",
                Filter = "Database (*.mdb)|*.mdb",
                Title = "Select database path"
            };



            InitializeComponent();
            btnTest.Click += new EventHandler(btnTest_Click);
            Controls.Add(btnTest);
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

        private void TestInit(string filePath)
        {
            
            string connectionString;
            string sql;
            OleDbConnection cnn;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+filePath+";Persist Security Info=False;";
            cnn = new OleDbConnection(connectionString);
            cnn.Open();
            OleDbCommand cmd = cnn.CreateCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT TOP 1 artist FROM Albums;"; //Artist
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbArtist.Items.Add(dr[0]);
            }
            dr.Close();

            cmd.CommandText = "SELECT TOP 1 title FROM Albums;"; //Albums
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbAlbum.Items.Add(dr[0]);
            }
            dr.Close();

            var CommandTextStr = "SELECT TOP 1 title,length FROM Tracks;"; //Tracks
            var dataAdapter = new OleDbDataAdapter(CommandTextStr, connectionString);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvTrack.ReadOnly = true;
            dgvTrack.DataSource = ds.Tables[0];
            

            cmd.CommandText = "SELECT TOP 1 url FROM Tracks;"; //URL
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbURL.Text="https://youtu.be/"+dr.GetString(0);
            }
            dr.Close();

            cmd.CommandText = "SELECT TOP 1 id FROM Albums;"; //PictureBox
            dr = cmd.ExecuteReader();
            var picturename="";
            while (dr.Read())
            {
                picturename = dr.GetString(0);
            }
            pbAlbum.Image = (Image)Beadandó200212.Properties.Resources.ResourceManager.GetObject(picturename);
            dr.Close();

            cnn.Close();
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    //MessageBox.Show(filePath);
                    TestInit(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
