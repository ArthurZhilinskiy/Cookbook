using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CookbookApplication
{
    public partial class Carts : MetroFramework.Controls.MetroUserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\CookBook.mdf;Integrated Security = True; Connect Timeout = 30";

        public Carts(string name_recipe)
        {
            InitializeComponent();
            Deleter del = new Deleter(name_recipe);
            del.Location = new Point(271, 3);
            del.Size = new Size(25, 25);
            del.Click += new System.EventHandler(del_Click);
            metroTile1.Controls.Add(del);
        }



        private void del_Click(object sender, EventArgs e)
        {
            QueryToDelete query = new QueryToDelete();
            query.ShowDialog();
            if (query.DialogResult == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }


                if (sender is Deleter)
                {
                    Deleter del = sender as Deleter;
                    string name = del.name_recipe;

                    SqlCommand command = new SqlCommand("DELETE FROM Recipes WHERE name_recipe = N'" + name + "'", connection);
                    command.BeginExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("DELETE FROM Descryption WHERE name = N'" + name + "'", connection);
                    SqlDataReader dr = command1.ExecuteReader();
                    
                }

                connection.Close();
            }
        }

    }
}
