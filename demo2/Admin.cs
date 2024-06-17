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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            DB dB = new DB();
            DataTable dataTable = dB.GetZakaz();
            int y = 0;  
            foreach (DataRow row in dataTable.Rows)
            {
                Panel element = new Panel();
                element.Location = new Point(18, y);
                element.Size = new Size(607, 78);
                element.BackColor = Color.AliceBlue;

                //Label title_phone = new Label();
                //title_phone.Location = new Point(168, 18);
                //title_phone.Text = row["phone"].ToString();
                //title_phone.Font = new Font("Segoe UI", 20);

                Label type_polom = new Label();
                type_polom.Location = new Point(486, 16);
                type_polom.Text = "Тип поломки";
                type_polom.Font = new Font("Segoe UI", 9);

                Label type = new Label();
                type.Location = new Point(463, 31);
                type.Text = row["typee"].ToString();
                type.Font = new Font("Segoe UI", 12);

                Label nomer_cli = new Label();
                nomer_cli.Location = new Point(25, 13);
                nomer_cli.Text = "Номер клиента";
                nomer_cli.Font = new Font("Segoe UI", 9);

                Label nomer = new Label();
                nomer.Location = new Point(14, 28);
                nomer.Text = row["user_tel"].ToString();
                nomer.Font = new Font("Segoe UI", 14);

                //element.Controls.Add(title_phone);
                element.Controls.Add(type_polom);
                element.Controls.Add(type);
                element.Controls.Add(nomer_cli);
                element.Controls.Add(nomer);
                pnl_spisok.Controls.Add(element);

                y += 150;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
