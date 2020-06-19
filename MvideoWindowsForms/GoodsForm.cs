using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace MvideoWindowsForms
{

    public partial class GoodsForm : Form
    {
        private Int32 ID_Goods = -1;
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            //CbFill();
        }

        ClassLibrary.Class1 class1 = new Class1();
        private void DgFill()
        {
            SqlConnection connection = new SqlConnection(class1.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(class1.sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;

            //string sqlstr = "SELECT " +
            //"ID_Goods, " +
            //"Name_of_Goods as Товар " +
            //"FROM Goods ";
            //var table_class = new Table_Class(sqlstr);
            //dataGridView1.DataSource = table_class.table.DefaultView;
            //dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID_Goods = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxGoods.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxGoods.Text);
            new Procedure_Class().procedure_Execution("Goods_insert", arrayList);
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

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ID_Goods == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Goods);
            arrayList.Add(textBoxGoods.Text);
            new Procedure_Class().procedure_Execution("Goods_update", arrayList);
            DgFill();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Goods);
            new Procedure_Class().procedure_Execution("Goods_delete", arrayList);
            DgFill();
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
