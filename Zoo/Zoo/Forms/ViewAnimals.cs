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
    public partial class ViewAnimals : Form
    {
        public ViewAnimals()
        {
            InitializeComponent();
        }

        private void jivotnoeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jivotnoeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void ViewAnimals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Jivotnoe". При необходимости она может быть перемещена или удалена.
            this.jivotnoeTableAdapter.Fill(this.zooDataSet.Jivotnoe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn7;
                    break;
            }
            if (radioButton1.Checked)
                jivotnoeDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                jivotnoeDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    jivotnoeBindingSource.Filter = "NomerJiv = " + textBox1.Text;
                    break;
                case 1:
                    jivotnoeBindingSource.Filter = "KlichkaJiv Like '" + textBox1.Text + "%'";
                    break;
                case 2:
                    jivotnoeBindingSource.Filter = "NomerValera =" + textBox1.Text;
                    break;
                case 3:
                    jivotnoeBindingSource.Filter = "VidJivotnogo Like '" + textBox1.Text + "%'";
                    break;
            }
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            jivotnoeBindingSource.Filter = " ";
        }
    }
}
