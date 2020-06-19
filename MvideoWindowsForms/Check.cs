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
    public partial class Check : Form
    {
        private Int32 ID_Check = -1;
        public Check()
        {
            InitializeComponent();
        }

        private void Check_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            //CbFill();
        }

        private void DgFill()
        {

            string sqlstr = "SELECT " +
            "ID_Check, " +
            "Nomer_Check as Товар " +
            "FROM [Check] ";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Check = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxNomerCheck.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxNomerCheck.Text);
            new Procedure_Class().procedure_Execution("Check_insert", arrayList);
            DgFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ID_Check == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Check);
            arrayList.Add(textBoxNomerCheck.Text);
            new Procedure_Class().procedure_Execution("Goods_update", arrayList);
            DgFill();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Check);
            new Procedure_Class().procedure_Execution("Check_delete", arrayList);
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

        //private void BtDocCreate_Click(object sender, EventArgs e)
        //{
        //    Document_Class document = new Document_Class();
        //    switch (tbctrlKlient.SelectedIndex)
        //    {
        //        case 0:
        //            btDocCreate.Enabled = false;
        //            document.Document_Create(Document_Class.Document_Type.Statistic, Document_Class.Document_Format.Excel, "Отчет чек", dtCheck);
        //            btDocCreate.Enabled = true;
        //            break;
        //        case 1:
        //            btDocCreate.Enabled = false;
        //            document.Document_Create(Document_Class.Document_Type.Report, Document_Class.Document_Format.PDF, "Отчёт чек", dtCheck);
        //            btDocCreate.Enabled = true;
        //            break;
        //        case 2:
        //            btDocCreate.Enabled = false;
        //            document.Document_Create(Document_Class.Document_Type.Report, Document_Class.Document_Format.Word, "Отчёт чек", ID);
        //            btDocCreate.Enabled = true;
        //            break;
        //        case 3:
        //            MessageBox.Show("Создание документа не предусмотренно!");
        //            break;
        //    }
        //}
    }
} 
