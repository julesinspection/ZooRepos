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

        public static int countTries = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            AData log = new AData();
            log.login = textBox1.Text;
            log.password = textBox2.Text;
            switch(log.CheckAData())
            {
                case "director":
                    DirectorForm f1 = new DirectorForm();
                    countTries = 0;
                    f1.Show();                   
                    break;
                case "sotr":
                    SotrForm f2 = new SotrForm();
                    countTries = 0;
                    f2.Show();
                    break;
                case "vet":
                    VetForm f3 = new VetForm();
                    countTries = 0;
                    f3.Show();
                    break;
                case "none":
                    countTries++;
                    MessageBox.Show("Неверный логин или пароль, осталось попыток: " + (3 - countTries));
                    if (countTries == 3) {
                        Application.Exit();
                    }
                    break;
            }
        }
    }
}
