using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort_rasch
{
    public partial class FormforReg : Form
    {
        public FormforReg()
        {
            InitializeComponent();
        }

        private void zaregestrirovatsa_Click(object sender, EventArgs e)
        {

                DBManager dBManager = new DBManager("\"C:\\Users\\фвьшт\\OneDrive\\Рабочий стол\\Курсач\\сортиров\\users.db\"");

            if (string.IsNullOrEmpty(reglogin.Text) || string.IsNullOrEmpty(regpas.Text))
            {
                MessageBox.Show("Логин и пароль должны быть заполнены");
            }
            else
            if (dBManager.AddUser(reglogin.Text, regpas.Text) == true)
            {
                if (regpas.Text == regpas1.Text)
                {
                    MessageBox.Show("Успешно :)");
                }
            }
            else
            {
                MessageBox.Show("Ошибочка :(");
            }
        }

        private void regpas_TextChanged(object sender, EventArgs e)
        {

        }

        private void reglogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void regpas1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
