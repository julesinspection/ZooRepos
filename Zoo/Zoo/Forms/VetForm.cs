using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo.Forms
{
    public partial class VetForm : Form
    {
        public VetForm()
        {
            InitializeComponent();
        }

        private void животныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAnimals f = new ViewAnimals();
            f.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
