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
    public partial class EmployeeForm : Form
    {
        private Int32 ID_Employee = -1;
        //private Table_Class tableClass;
        public EmployeeForm()
        {
            InitializeComponent();


            //comboBoxPosition.Item

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            CbFill();
        }

        private void CbFill()
        {
            comboBoxEducation.DataSource = new Table_Class("SELECT ID_Education, Type_of_Education FROM dbo.Education").table.DefaultView;
            comboBoxEducation.ValueMember = "ID_Education";
            comboBoxEducation.DisplayMember = "Type_of_Education";
            comboBoxEducation.SelectedIndex = -1;

            comboBoxPosition.DataSource = new Table_Class("SELECT ID_Position, Type_of_Position FROM dbo.Position").table.DefaultView;
            comboBoxPosition.ValueMember = "ID_Position";
            comboBoxPosition.DisplayMember = "Type_of_Position";
            comboBoxPosition.SelectedIndex = -1;


        }

        private void DgFill()
        {

            string sqlstr = "SELECT " +
            "ID_Employee,  " +
            "Education.Type_of_Education as Образование, " +
            "Position.Type_of_Position as Должность, " +
            "Data_Recruitment as Дата_приема_на_работу, " +
            "First_Name as Фамилия, Name_Employee as Имя, Middle_Name as Отчество, Employee_Login as Логин, Employee_Password as Пароль, " +
            "Education_ID, Position_ID " +
            "FROM Employee " +
            "INNER JOIN Education ON ID_Education = Education_ID " +
            "INNER JOIN Position ON ID_Position = Position_ID " +
            "INNER JOIN Recruitment ON ID_Recruitment = Recruitment_ID";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            //var v = table_class.table.Rows[3].ItemArray[3];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Employee = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBoxEducation.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

         private void Button2_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Employee);
            new Procedure_Class().procedure_Execution("Employee_delete", arrayList);
            DgFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxFirstName.Text);
            arrayList.Add(textBoxName.Text);
            arrayList.Add(textBoxMiddleName.Text);
            arrayList.Add(textBoxLogin.Text);
            arrayList.Add(textBoxPassword.Text);
            arrayList.Add(comboBoxEducation.SelectedValue);
            arrayList.Add(comboBoxPosition.SelectedValue);
            arrayList.Add(1);
            new Procedure_Class().procedure_Execution("Employee_insert", arrayList);
            DgFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(ID_Employee == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Employee);
            arrayList.Add(textBoxFirstName.Text);
            arrayList.Add(textBoxName.Text);
            arrayList.Add(textBoxMiddleName.Text);
            arrayList.Add(textBoxLogin.Text);
            arrayList.Add(textBoxPassword.Text);
            arrayList.Add(comboBoxEducation.SelectedValue);
            arrayList.Add(comboBoxPosition.SelectedValue);
            arrayList.Add(1);
            new Procedure_Class().procedure_Execution("Employee_update", arrayList);
            DgFill();
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

        //private void BtDocCreate_Click(object sender, EventArgs e)
        //{
        //    Document_Class document = new Document_Class();
        //    switch ()
        //    {
        //        case 0:
        //            btDocCreate.Enabled = false;
        //            document.Document_Create(Document_Class.Document_Type.Statistic, Document_Class.Document_Format.Excel, "Статистика о затратах", dtExpences);
        //            btDocCreate.Enabled = true;
        //            break;
        //        case 1:
        //            btDocCreate.Enabled = false;
        //            document.Document_Create(Document_Class.Document_Type.Report, Document_Class.Document_Format.PDF, "Отчёт о популярности товаров", dtTop5);
        //            btDocCreate.Enabled = true;
        //            break;
        //        case 2:
        //            btDocCreate.Enabled = false;
        //            document.Document_Create(Document_Class.Document_Type.Report, Document_Class.Document_Format.Word, "Отчёт о затратах", dtSale_Check);
        //            btDocCreate.Enabled = true;
        //            break;
        //        case 3:
        //            MessageBox.Show("Создание документа не предусмотренно!");
        //            break;
        //    }
        //}
    }
}
