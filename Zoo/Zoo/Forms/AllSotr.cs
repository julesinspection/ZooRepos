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
    public partial class AllSotr : Form
    {
        public AllSotr()
        {
            InitializeComponent();
        }

        private void sotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void ViewSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.zooDataSet.Sotrudnik);

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
                
            }
            if (radioButton1.Checked)
                sotrudnikDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                sotrudnikDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
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
                    sotrudnikBindingSource.Filter = "NomerSotr = " + textBox1.Text;
                    break;
                case 1:
                    sotrudnikBindingSource.Filter = "FIO Like '" + textBox1.Text + "%'";
                    break;
                case 2:
                    sotrudnikBindingSource.Filter = "Doljnost Like '" + textBox1.Text + "%'";
                    break;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            sotrudnikBindingSource.Filter = " ";
        }

    }
}
