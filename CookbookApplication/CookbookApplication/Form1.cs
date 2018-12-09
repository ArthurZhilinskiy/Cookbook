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
    }
}
