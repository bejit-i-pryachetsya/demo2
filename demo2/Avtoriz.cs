using System.Data;

namespace demo2
{
    public partial class Avtoriz : Form
    {


        public static class UserInfo
        {
            public static string id { get; set; }
            public static string phone { get; set; }
        }


        public Avtoriz()
        {
            InitializeComponent();

            









        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_pas.Text == String.Empty && txt_log.Text == String.Empty)
            {
                MessageBox.Show("Введите логин и пароль!");
            }
            else
            {
                DB dB = new DB();
                DataTable user =  dB.GetUser(txt_log.Text, txt_pas.Text);
                if (user.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь не наеден!");
                    txt_pas.Clear();
                    txt_log.Clear();
                }
                else
                {

                   
                    UserInfo.phone = Convert.ToString(user.Rows[0][3]);
                    UserInfo.id = Convert.ToString(user.Rows[0][0]);
                    if (Convert.ToInt32(user.Rows[0][1]) == 2)
                    {
                        User user1 = new User();
                        this.Hide();
                        user1.Show(); 

                    }
                    else
                    {
                        Admin admin = new Admin();
                        this.Hide();
                        admin.Show();
                    }
                }
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            this.Hide();
            registr.Show();
        }

        private void Avtoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}