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


        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void button2_Click(object sender, EventArgs e)
        {
            AllAnimals form = new AllAnimals();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditAnimals form = new EditAnimals();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAnimals form = new ViewAnimals();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPotomstvo form = new EditPotomstvo();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditBolezni form = new EditBolezni();
            form.Show();
        }
    }
}
