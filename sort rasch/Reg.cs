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
    public partial class Reg : Form
    {
        private bool _isAuthenticated = false;
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginforReg.Text;
            if (login.Contains('\'') || login.Contains('-'))
            {
                MessageBox.Show("Не надо дядя!!");
                return;
            }
            DBManager dBManager = new DBManager("\"C:\\Users\\фвьшт\\OneDrive\\Рабочий стол\\Курсач\\сортиров\\users.db\"");
            if (dBManager.CheckUser(loginforReg.Text, pasforReg.Text) == true)
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибочка :(");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormforReg reg_form = new FormforReg();
            reg_form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FormforReg reg_form = new FormforReg();
            reg_form.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
                Application.Exit();
        }

        private void loginforReg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

