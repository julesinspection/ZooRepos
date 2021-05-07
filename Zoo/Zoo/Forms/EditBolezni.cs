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
    public partial class EditBolezni : Form {
        public EditBolezni()
        {
            InitializeComponent();
        }

        private void kartochkaBolezneyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kartochkaBolezneyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);
            MessageBox.Show("Данные о болезни сохранены");
        }

        private void EditBolezni_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Jivotnoe". При необходимости она может быть перемещена или удалена.
            this.jivotnoeTableAdapter.Fill(this.zooDataSet.Jivotnoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.KartochkaBolezney". При необходимости она может быть перемещена или удалена.
            this.kartochkaBolezneyTableAdapter.Fill(this.zooDataSet.KartochkaBolezney);

        }
    }
}
