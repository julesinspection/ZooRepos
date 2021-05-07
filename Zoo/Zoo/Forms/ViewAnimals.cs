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
    public partial class ViewAnimals : Form {
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Potomstvo". При необходимости она может быть перемещена или удалена.
            this.potomstvoTableAdapter.Fill(this.zooDataSet.Potomstvo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.RabotaSJivotnim". При необходимости она может быть перемещена или удалена.
            this.rabotaSJivotnimTableAdapter.Fill(this.zooDataSet.RabotaSJivotnim);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.KartochkaBolezney". При необходимости она может быть перемещена или удалена.
            this.kartochkaBolezneyTableAdapter.Fill(this.zooDataSet.KartochkaBolezney);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Jivotnoe". При необходимости она может быть перемещена или удалена.
            this.jivotnoeTableAdapter.Fill(this.zooDataSet.Jivotnoe);

        }
    }
}
