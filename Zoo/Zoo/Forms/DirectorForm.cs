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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();

        }

        private void jivotnoeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jivotnoeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.zooDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Jivotnoe". При необходимости она может быть перемещена или удалена.
            this.jivotnoeTableAdapter.Fill(this.zooDataSet.Jivotnoe);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void button2_Click(object sender, EventArgs e)
        {
            AllAnimals form = new AllAnimals();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllSotr form = new AllSotr();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditSotr form = new EditSotr();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewSotr form = new ViewSotr();
            form.Show();
        }
    }
}
