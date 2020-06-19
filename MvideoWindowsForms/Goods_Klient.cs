using System;
using System.Collections;
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
    public partial class Goods_Klient : Form
    {
        private Int32 ID_Goods_Klient_Check = -1;
        public Goods_Klient()
        {
            InitializeComponent();
        }

        private void Goods_Klient_Check_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            CbFill();
        }

        private void CbFill()
        {
            comboBoxKlient.DataSource = new Table_Class("SELECT ID_Klient, First_Name_Klient FROM dbo.Klient").table.DefaultView;
            comboBoxKlient.ValueMember = "ID_Klient";
            comboBoxKlient.DisplayMember = "First_Name_Klient";
            comboBoxKlient.SelectedIndex = -1;

            comboBoxGoods.DataSource = new Table_Class("SELECT ID_Goods, Name_of_Goods FROM dbo.Goods").table.DefaultView;
            comboBoxGoods.ValueMember = "ID_Goods";
            comboBoxGoods.DisplayMember = "Name_of_Goods";
            comboBoxGoods.SelectedIndex = -1;
        }

        private void DgFill()
        {

            string sqlstr = "SELECT " +
            "ID_Goods_Klient_Check, " +
            "Klient.First_Name_Klient as Клиент, " +
            "Goods.Name_of_Goods as Товар, " +
            "Goods_ID, Klient_ID " +
            "FROM Goods_Klient_Check " +
            "INNER JOIN Goods ON ID_Goods = Goods_ID " +
            "INNER JOIN Klient ON ID_Klient = Klient_ID ";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void DataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID_Goods_Klient_Check = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            comboBoxKlient.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxGoods.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(comboBoxGoods.SelectedValue);
            arrayList.Add(comboBoxKlient.SelectedValue);
            new Procedure_Class().procedure_Execution("Goods_Klient_Check_insert", arrayList);
            DgFill();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button6_Click(object sender, EventArgs e)
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
    }
}
