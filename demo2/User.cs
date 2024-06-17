using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static demo2.Avtoriz;


namespace demo2
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_model.Text == String.Empty && box_brand.Text == String.Empty)
            {
                MessageBox.Show("Укажите все данные!");
            }
            else
            {
                DB dB = new DB();
                dB.SetZakaz(UserInfo.id, box_brand.Text + txt_model.Text, "Принято", DateTime.Now.ToString(), txt_dop_info.Text, box_type.Text, UserInfo.phone);
                MessageBox.Show("Заявка подана!");




                txt_dop_info.Clear();
                txt_model.Clear();
            }
               
            
            









        }

























        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
