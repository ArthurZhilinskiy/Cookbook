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
    public partial class Deleter : UserControl
    {
        public string name_recipe;
        public Deleter(string name_recipe)
        {
            InitializeComponent();
            this.name_recipe = name_recipe;
        }
    }
}
