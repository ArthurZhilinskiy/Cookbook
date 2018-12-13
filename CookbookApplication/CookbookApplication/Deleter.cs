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
        public string image_path;
        public MainApplicationForm mainApplicationForm;
        public Deleter(string name_recipe, string image_path, MainApplicationForm mainApplicationForm)
        {
            InitializeComponent();
            this.name_recipe = name_recipe;
            this.image_path = image_path;
            this.mainApplicationForm = mainApplicationForm;
        }
    }
}
