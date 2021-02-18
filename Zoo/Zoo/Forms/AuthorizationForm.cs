using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoo.Data;

namespace Zoo.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AData log = new AData();
            log.login = textBox1.Text;
            log.password = textBox2.Text;
            switch(log.CheckAData())
            {
                case "director":
                    DirectorForm f1 = new DirectorForm();
                    f1.Show();                   
                    break;
                case "sotr":
                    SotrForm f2 = new SotrForm();
                    f2.Show();
                    break;
                case "dir":
                    VetForm f3 = new VetForm();
                    f3.Show();
                    break;
                case "none":
                    MessageBox.Show("Неверный логин или пароль");
                    break;
            }
        }
    }
}
