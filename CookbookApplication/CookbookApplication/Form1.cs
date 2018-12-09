using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CookbookApplication
{
    public partial class MainApplicationForm : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\CookBook.mdf;Integrated Security = True; Connect Timeout = 30";
        public MainApplicationForm()
        {
            InitializeComponent();
        }

        private void MainApplicationForm_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void MainApplicationForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            //Carts cart = new Carts();
            ////загружаем картинку в контрол
            //cart.metroTile1.TileImage = Image.FromFile(getImage()); 
            //cart.metroTile1.Click += new System.EventHandler(cart_Click);
            //flowLayoutPanel1.Controls.Add(cart);
        }

        //метод получает путь к картинк из БД
        private string getImage()
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //try
            //{
            //    connection.Open();
            //    MessageBox.Show("OK");
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //    connection.Close();
            //}
            
            //SqlCommand command = new SqlCommand("SELECT ", connection);
            //SqlDataReader reader = command.ExecuteReader();

            string a = "";
            return a;
        }

        private void cart_Click(object sender, EventArgs e)
        {
            FormWithRecipe formWithRecipe = new FormWithRecipe();
            string temp = sender.ToString();
            formWithRecipe.Text = temp.Substring(41);
            formWithRecipe.Show();
        }
    }
}
