using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookApplication
{
    public partial class Carts : MetroFramework.Controls.MetroUserControl
    {
        public string id;
        public Carts()
        {
            InitializeComponent();
            metroLabel1.Text = id;
        }

        public override string ToString()
        {
            return metroTile1.Text;
        }
    }
}
