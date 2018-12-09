﻿using System;
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
            getRecipes();
        }

        //метод получает путь к картинк из БД
        private void getRecipes()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT image_recipe, name_recipe FROM Recipes", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Carts cart = new Carts();
                //загружаем картинку в контрол
                cart.metroTile1.TileImage = Image.FromFile(Application.StartupPath+@"\"+reader[0].ToString());
                cart.metroTile1.Text = reader[1].ToString();
                cart.metroTile1.Click += new System.EventHandler(cart_Click);
                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
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
