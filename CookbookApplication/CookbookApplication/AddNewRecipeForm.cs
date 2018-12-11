using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CookbookApplication
{
    public partial class AddNewRecipeForm : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\CookBook.mdf;Integrated Security = True; Connect Timeout = 30";

        string imageName;
        string path;
        MainApplicationForm form;
        public AddNewRecipeForm(MainApplicationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "jpeg files (*.jpg)|*.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opfd.FileName);
                path = opfd.FileName;
                imageName = Path.GetFileName(opfd.FileName);
            }
        }

        void CopyFile(string from, string to)
        {
            FileInfo fn = new FileInfo(from);
            fn.CopyTo(to, true);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //Копирование картинки в папку DishImages
            string copyTo = Application.StartupPath + @"\DishImages\" + imageName;
            
            
            try
            {
                CopyFile(path, copyTo);
            }
            catch
            {
                
            }
            //Добавление записей в БД

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

            string folderPlusFileName = @"DishImages\" + imageName;

            SqlCommand command = new SqlCommand("INSERT INTO Recipes(name_recipe, image_recipe) VALUES (N'"+rtbName.Text+"', N'"+ folderPlusFileName + "')", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            reader.Close();
            SqlCommand command1 = new SqlCommand("SELECT Id FROM Recipes WHERE name_recipe = N'"+rtbName.Text+"'", connection);
            SqlDataReader reader1 = command1.ExecuteReader();

            string id_recipe = "";
            while (reader1.Read())
            {
                id_recipe = reader1[0].ToString();
            }
            reader1.Close();
            SqlCommand command2 = new SqlCommand("INSERT INTO Descryption(id_recipe, name, ingredients, steps) VALUES (N'" + id_recipe + "', N'" + rtbName.Text + "', N'"+ rtbIngredients.Text +"', N'"+ rtbSteps.Text +"')", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            reader2.Close();
            connection.Close();
            copyTo = "";
            UpdateForm(form);
            this.Close();
        }

        private void UpdateForm(MainApplicationForm form)
        {
            form.flowLayoutPanel1.Controls.Clear();

            form.getRecipes();

        }
    }
}
