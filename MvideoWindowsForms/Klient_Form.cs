using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvideoWindowsForms
{
    public partial class Klient_Form : Form
    {
        private Int32 ID_Klient = -1;
        public Klient_Form()
        {
            InitializeComponent();
        }

        private void Klient_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            //CbFill();
        }

        private void DgFill()
        {

            string sqlstr = "SELECT [ID_Klient] , " +
                "[First_Name_Klient] as Фамилия, " +
                "[Name_Klient] as Имя, " +
                "[Middle_Name_Klient] as Отчество, " +
                "[Klient_Login] as Логин, " +
                "[Klient_Password] as Пароль, " +
                "[Klient_Logical_Delete] as Удаление " +
                "FROM [dbo].[Klient]";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxFirstName.Text);
            arrayList.Add(textBoxName.Text);
            arrayList.Add(textBoxMiddleName.Text);
            arrayList.Add(textBoxLogin.Text);
            arrayList.Add(textBoxPassword.Text);
            new Procedure_Class().procedure_Execution("Klient_insert", arrayList);
            DgFill();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (ID_Klient == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Klient);
            arrayList.Add(textBoxFirstName.Text);
            arrayList.Add(textBoxName.Text);
            arrayList.Add(textBoxMiddleName.Text);
            arrayList.Add(textBoxLogin.Text);
            arrayList.Add(textBoxPassword.Text);
            new Procedure_Class().procedure_Execution("Goods_update", arrayList);
            DgFill();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();

            ArrayList Logical_delete_Klient = new ArrayList();
            Program.intID = dataGridView1.CurrentCell.RowIndex.ToString();
            Logical_delete_Klient.Add(Program.intID);
            Logical_delete_Klient.Add(textBoxDelete.Text);
            procedure.procedure_Execution("Logical_delete_Klient", Logical_delete_Klient);
            DgFill();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.White)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DgFill();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Close();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Klient = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxDelete.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();

            lbl.Size = new Size(400, 20);

            lbl.Location = new Point(241, 344);

            lbl.Text = "Эта форма нужна для отображения клиентов";

            this.Controls.Add(lbl);
        }
    }
}
