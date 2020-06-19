using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvideoWindowsForms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        //Выход из окна
        private void button1_Click(object sender, EventArgs e)
        {
            string Login = tbUser_Login.Text;
            string Password = tbUser_Password.Text;

            var qwertyLOGPASSotr = $"SELECT ID_Employee FROM dbo.Employee WHERE Employee_Login = '{Login}' AND Employee_Password = '{Password}'";
            var ProverkaSotr = new Table_Class(qwertyLOGPASSotr);

            var qwertyLOGPASKlient = $"SELECT * FROM dbo.Klient WHERE Klient_Login = '{Login}' AND Klient_Password = '{Password}'";
            //SELECT ID_Klient FROM dbo.Klient WHERE Klient_Login = '{Login}' AND Klient_Password = '{Password}'
            var ProverkaKlient = new Table_Class(qwertyLOGPASKlient);



            if (ProverkaSotr.table.Rows.Count != 0)
            {
                //Program.Dostup = Convert.ToInt32(Proverka.table.Rows[0][0].ToString());
                Program.IDSotr = Convert.ToInt32(ProverkaSotr.table.Rows[0][0].ToString());
                new MainForm().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
            else if (ProverkaKlient.table.Rows.Count != 0)
            {
                Program.IDKlient = Convert.ToInt32(ProverkaKlient.table.Rows[0][0].ToString());
                Program.modelKlient = new ModelKlient(
                    Convert.ToInt32(ProverkaKlient.table.Rows[0][0]),
                    Convert.ToString(ProverkaKlient.table.Rows[0][1]),
                    Convert.ToString(ProverkaKlient.table.Rows[0][2]),
                    Convert.ToString(ProverkaKlient.table.Rows[0][3]),
                    Convert.ToString(ProverkaKlient.table.Rows[0][4]),
                    Convert.ToString(ProverkaKlient.table.Rows[0][5]),
                    Convert.ToBoolean(ProverkaKlient.table.Rows[0][6])
                    );

                new Personal_Profile_Klient().Show();
                //new Goods_Klient_Check().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
            else
            {
                MessageBox.Show("Не правильно введен логин или пароль!", "Мвидео", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            Registration_Form registration = new Registration_Form();
            registration.ShowDialog();
        }


    }
}
