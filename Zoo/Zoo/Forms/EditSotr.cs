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
    public partial class EditSotr : Form {
        public EditSotr()
        {
            InitializeComponent();
        }

        private void sotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);
            MessageBox.Show("Данные о сотруднике сохранены");

        }

        private void EditSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.RabotaSJivotnim". При необходимости она может быть перемещена или удалена.
            this.rabotaSJivotnimTableAdapter.Fill(this.zooDataSet.RabotaSJivotnim);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.zooDataSet.Sotrudnik);

        }
    }
}
