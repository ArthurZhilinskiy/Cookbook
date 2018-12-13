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

        private void AddData()
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

            SqlCommand command_proverka = new SqlCommand("SELECT id FROM Recipes WHERE name_recipe = N'"+rtbName.Text+"'", connection);
            SqlDataReader reader_proverka = command_proverka.ExecuteReader();
            int count = 0;
            while (reader_proverka.Read())
            {
                count++;
            }
            reader_proverka.Close();
            if (count == 0)
            {
                string folderPlusFileName = @"DishImages\" + imageName;

                SqlCommand command = new SqlCommand("INSERT INTO Recipes(name_recipe, image_recipe) VALUES (N'" + rtbName.Text + "', N'" + folderPlusFileName + "')", connection);
                command.ExecuteNonQuery();
                SqlCommand command1 = new SqlCommand("SELECT Id FROM Recipes WHERE name_recipe = N'" + rtbName.Text + "'", connection);
                SqlDataReader reader1 = command1.ExecuteReader();

                string id_recipe = "";
                while (reader1.Read())
                {
                    id_recipe = reader1[0].ToString();
                }
                reader1.Close();
                SqlCommand command2 = new SqlCommand("INSERT INTO Descryption(id_recipe, name, ingredients, steps) VALUES (N'" + id_recipe + "', N'" + rtbName.Text + "', N'" + rtbIngredients.Text + "', N'" + rtbSteps.Text + "')", connection);
                command2.ExecuteNonQuery();
                connection.Close();
                copyTo = "";
                UpdateForm(form);
                this.Close();
            }
            connection.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (rtbName.Text != String.Empty && !String.IsNullOrWhiteSpace(rtbName.Text))
                {
                    if (rtbIngredients.Text != String.Empty && !String.IsNullOrWhiteSpace(rtbIngredients.Text))
                    {
                        if (rtbSteps.Text != String.Empty && !String.IsNullOrWhiteSpace(rtbSteps.Text))
                        {
                            AddData();
                        }
                        else
                        {
                            MessageBox.Show("Заполните поле [Как готовить]!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните поле [Ингредиенты]!");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поле [Название]!");
                }

            }
            else
            {
                MessageBox.Show("Выберите изображение!");
            }

        }

        private void UpdateForm(MainApplicationForm form)
        {
            form.flowLayoutPanel1.Controls.Clear();

            form.getRecipes();

        }
    }
}
