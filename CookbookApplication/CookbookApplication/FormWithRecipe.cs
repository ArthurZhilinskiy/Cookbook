using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookApplication
{
    public partial class FormWithRecipe : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\CookBook.mdf;Integrated Security = True; Connect Timeout = 30";
        MainApplicationForm mainForm;

        public FormWithRecipe(MainApplicationForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        

        private void metroTile4_Click(object sender, EventArgs e)
        {
            rtbIngedients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            rtbSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroButton1.Visible = true;
            metroTextBox1.Visible = true;
            metroTextBox1.Text = this.Text;

            rtbIngedients.ReadOnly = false;
            rtbSteps.ReadOnly = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UpdateDataBase();
            mainForm.flowLayoutPanel1.Controls.Clear();
            mainForm.getRecipes();
            this.Close();
        }

        private void UpdateDataBase()
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

            SqlCommand command = new SqlCommand("UPDATE Recipes SET name_recipe = N'" + metroTextBox1.Text + "' WHERE name_recipe = N'" + this.Text+"'", connection);
            command.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("UPDATE Descryption SET name = N'" + metroTextBox1.Text + "', steps = N'"+rtbSteps.Text+"', ingredients = N'"+rtbIngedients.Text+ "' WHERE name = N'" + this.Text + "'", connection);
            command1.ExecuteNonQuery();

            connection.Close();
        }
    }
}
