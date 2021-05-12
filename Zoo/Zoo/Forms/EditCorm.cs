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
    public partial class EditCorm : Form {
        public EditCorm()
        {
            InitializeComponent();
        }

        private void kormBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool f = true;
            try {
                int check1 = Convert.ToInt32(cenaTextBox.Text);
            }
            catch (FormatException) {
                MessageBox.Show("Вы ввели символ! Пожалуйста, введите цифрy");
                f = false;
            }
            finally {
                if (f == true) {
                    MessageBox.Show("Данные о корме сохранены");
                    this.Validate();
                    this.kormBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.zooDataSet);
                }
            }

        }

        private void EditCorm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Korm". При необходимости она может быть перемещена или удалена.
            this.kormTableAdapter.Fill(this.zooDataSet.Korm);

        }
    }
}
