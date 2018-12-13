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
using System.IO;

namespace CookbookApplication
{
    public partial class Carts : MetroFramework.Controls.MetroUserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\CookBook.mdf;Integrated Security = True; Connect Timeout = 30";

        public Carts(string name_recipe, string image_path, MainApplicationForm mainApplicationForm)
        {
            InitializeComponent();
            
            Deleter del = new Deleter(name_recipe, image_path, mainApplicationForm);
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
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("DELETE FROM Descryption WHERE name = N'" + name + "'", connection);
                    command1.ExecuteNonQuery();

                    this.metroTile1.TileImage.Dispose();
                    //удаляем картинку из папки
                    if (File.Exists(del.image_path))
                    {
                        File.Delete(del.image_path);
                    }
                    del.mainApplicationForm.flowLayoutPanel1.Controls.Clear();
                    del.mainApplicationForm.getRecipes();
                }

                connection.Close();
                
            }
        }

    }
}
