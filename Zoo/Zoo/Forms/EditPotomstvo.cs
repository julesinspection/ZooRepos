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
    public partial class EditPotomstvo : Form {
        public EditPotomstvo()
        {
            InitializeComponent();
        }

        private void potomstvoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.potomstvoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);
            MessageBox.Show("Данные о потомстве сохранены");

        }

        private void EditPotomstvo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Jivotnoe". При необходимости она может быть перемещена или удалена.
            this.jivotnoeTableAdapter.Fill(this.zooDataSet.Jivotnoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Potomstvo". При необходимости она может быть перемещена или удалена.
            this.potomstvoTableAdapter.Fill(this.zooDataSet.Potomstvo);

        }
    }
}
