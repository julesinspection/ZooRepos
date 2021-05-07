using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo.Forms {
    public partial class EditAnimals : Form {
        public EditAnimals()
        {
            InitializeComponent();
        }

        private void jivotnoeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jivotnoeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);
            MessageBox.Show("Данные о животном сохранены");
        }

        private void EditAnimals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Korm". При необходимости она может быть перемещена или удалена.
            this.kormTableAdapter.Fill(this.zooDataSet.Korm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Jivotnoe". При необходимости она может быть перемещена или удалена.
            this.jivotnoeTableAdapter.Fill(this.zooDataSet.Jivotnoe);

        }
    }
}
