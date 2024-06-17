using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

























        private void Registr_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_registr_Click(object sender, EventArgs e)
        {
            try
            {
                DB dB = new DB();
                dB.SetUser(txt_name.Text, txt_tel.Text, txt_pass.Text);
                MessageBox.Show("Вы успешно зарегистрировались!");


                Avtoriz avtoriz = new Avtoriz();
                this.Hide();
                avtoriz.Show();


            }

            catch
            {
                MessageBox.Show("Введите корректные данные! Возможно такой пользователь уже существует.");
            }


        }

        private void Registr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
