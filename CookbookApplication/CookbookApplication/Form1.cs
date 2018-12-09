using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookApplication
{
    public partial class MainApplicationForm : MetroFramework.Forms.MetroForm
    {
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
            Carts cart = new Carts();
            cart.metroTile1.Click += new System.EventHandler(cart_Click);
            flowLayoutPanel1.Controls.Add(cart);
        }

        private void cart_Click(object sender, EventArgs e)
        {
            FormWithRecipe formWithRecipe = new FormWithRecipe();
            string temp = sender.ToString();
            formWithRecipe.Text = temp.Substring(41);
            formWithRecipe.metroLabel1.Focus();
            formWithRecipe.Show();
        }
    }
}
