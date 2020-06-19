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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            if (Program.Dostup != 1)
            {
                if (Program.Dostup == 2)
                    button6.Enabled = true;
                if (Program.Dostup == 3)
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button5.Enabled = true;
                }
                if (Program.Dostup == 4)
                {
                    button3.Enabled = true;
                    button5.Enabled = true;
                    button7.Enabled = true;
                    button6.Enabled = true;
                }
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                new EmployeeForm().Show();
                Visible = false;
                ShowInTaskbar = false;
                Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                new EducationForm().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            {
                new PositionForm().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            {
                new GoodsForm().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            {
                new TypeGoodsForm().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            {
                new SupplierForm().Show();
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            new Klient_Form().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new Check().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            new Goods_Klient().Show();
            Visible = false;
            ShowInTaskbar = false;
        }
    }
}
