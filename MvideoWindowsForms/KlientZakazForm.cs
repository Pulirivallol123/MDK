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
using Xceed.Words.NET;
using Xceed.Document.NET;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;

namespace MvideoWindowsForms
{
    public partial class KlientZakazForm : Form
    {

        private Int32 ID_Товар = -1;
        private int ID_Check;
        public KlientZakazForm(int ID_Check)
        {
            InitializeComponent();
            this.ID_Check = ID_Check;
        }

        private void KlientZakazForm_Load(object sender, EventArgs e)
        {
            dataGridViewЗаказ.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            CbFill();

        }

        private void CbFill()
        {
            comboBoxТовар.DataSource = new Table_Class("select ID_Goods, Name_of_Goods  from Goods").table.DefaultView;
            comboBoxТовар.ValueMember = "ID_Goods";
            comboBoxТовар.DisplayMember = "Name_of_Goods";
            comboBoxТовар.SelectedIndex = -1;
        }

        Table_Class table_class;

        private void DgFill()
        {
            ID_Товар = -1;
            string sqlstr = "select ID_Goods_Klient_Check, Goods.Name_of_Goods from dbo.Goods_Klient_Check " +
                "inner join  dbo.Goods on dbo.Goods_Klient_Check.Goods_ID = dbo.Goods.ID_Goods "+
                "where dbo.Goods_Klient_Check.Klient_ID = "+ Program.IDKlient +
                "and "+
                "dbo.Goods_Klient_Check.Check_ID = " + ID_Check;

            table_class = new Table_Class(sqlstr);
           
            dataGridViewЗаказ.DataSource = table_class.table.DefaultView;
        }

        private void ButtonДобавить_Click(object sender, EventArgs e)
        {
            if(comboBoxТовар.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран товар!");
                return;
            }

            //
            ArrayList arrayList = new ArrayList();
            arrayList.Add(comboBoxТовар.SelectedValue);
            arrayList.Add(Program.IDKlient);
            arrayList.Add(ID_Check);

            new Procedure_Class().procedure_Execution("Goods_Klient_Check_insert", arrayList);
            DgFill();

        }



        private void ButtonУдалить_Click(object sender, EventArgs e)
        {
            if(ID_Товар == -1)
            {
                MessageBox.Show("Не выбран товар!");
                return;
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Товар);
            new Procedure_Class().procedure_Execution("Goods_Klient_Check_delete", arrayList);
            DgFill();
            

        }

        private void DataGridViewЗаказ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Товар = (Int32)dataGridViewЗаказ.Rows[e.RowIndex].Cells[0].Value;
            labelТоварДляУдаления.Text = (Int32)dataGridViewЗаказ.Rows[e.RowIndex].Cells[0].Value + " "+
                (string)dataGridViewЗаказ.Rows[e.RowIndex].Cells[1].Value;
        }

        private void ButtonЗакрыть_Click(object sender, EventArgs e)
        {
            Close();
        }



        string extension = string.Empty;
        private void ButtonЭкспорт_Click(object sender, EventArgs e)
        {
            createExportDoc();
        }

        private void createExportDoc()
        {
            try
            {

                if (extension == string.Empty)
                {
                    MessageBox.Show("Не выбран тип экспортруемого файла");
                    return;
                }

                switch (extension)
                {
                    case (".docx"):
                        string pathDocumentDOCX = Program.baseDir + "Check" + extension;
                        DocX document = DocX.Create(pathDocumentDOCX);
                        Xceed.Document.NET.Paragraph paragraph = document.InsertParagraph();
                        paragraph.
                            AppendLine("Документ '" + "Check" + "' создан " + DateTime.Now.ToShortDateString()).
                            Font("Time New Roman").
                            FontSize(16).Bold().Alignment = Alignment.left;

                        paragraph.AppendLine();
                        Xceed.Document.NET.Table doctable = document.AddTable(table_class.table.Rows.Count + 1, 2);
                        doctable.Design = TableDesign.TableGrid;
                        doctable.TableCaption = "Check";

                        doctable.Rows[0].Cells[0].Paragraphs[0].Append("id").Font("Times New Roman").FontSize(14);
                        doctable.Rows[0].Cells[1].Paragraphs[0].Append("Goods").Font("Times New Roman").FontSize(14);

                        for (int i = 0; i < table_class.table.Rows.Count; i++)
                        {
                            doctable.Rows[i + 1].Cells[0].Paragraphs[0].Append(Convert.ToString(table_class.table.Rows[i][0])).Font("Times New Roman").FontSize(14);
                            doctable.Rows[i + 1].Cells[1].Paragraphs[0].Append(Convert.ToString(table_class.table.Rows[i][1])).Font("Times New Roman").FontSize(14);
                        }
                        document.InsertParagraph().InsertTableAfterSelf(doctable);
                        document.Save();
                        MessageBox.Show("Отчет успешно сформирован!");
                        Process.Start(pathDocumentDOCX);
                        break;

                    case (".xlsx"):
                        Excel.Application excel;
                        Excel.Workbook worKbooK;
                        Excel.Worksheet worKsheeT;
                        Excel.Range celLrangE;

                        string pathDocumentXLSX = Program.baseDir + "Check" + extension;

                        try
                        {
                            excel = new Excel.Application();
                            excel.Visible = false;
                            excel.DisplayAlerts = false;
                            worKbooK = excel.Workbooks.Add(Type.Missing);


                            worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                            worKsheeT.Name = "Check";

                            worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 8]].Merge();
                            worKsheeT.Cells[1, 1] = "Check";
                            worKsheeT.Cells.Font.Size = 15;

                            for (int i = 0; i < table_class.table.Rows.Count; i++)
                            {
                                worKsheeT.Cells[i + 3, 1] = table_class.table.Rows[i][0];
                                worKsheeT.Cells[i + 3, 2] = table_class.table.Rows[i][1];
                            }

                            worKbooK.SaveAs(pathDocumentXLSX); ;
                            worKbooK.Close();
                            excel.Quit();
                            MessageBox.Show("Отчет успешно сформирован!");
                            Process.Start(pathDocumentXLSX);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            worKsheeT = null;
                            celLrangE = null;
                            worKbooK = null;
                        }

                        break;


                    case (".pdf"):
                        string pathDocumentPDF = Program.baseDir + "Check" + extension;
                        if (File.Exists(Program.baseDir + "Check.docx"))
                        {
                            Word.Application appWord = new Word.Application();
                            var wordDocument = appWord.Documents.Open(Program.baseDir + "Check.docx");
                            wordDocument.ExportAsFixedFormat(pathDocumentPDF, Word.WdExportFormat.wdExportFormatPDF);
                            MessageBox.Show("Отчет успешно сформирован!");
                            wordDocument.Close();
                            Process.Start(pathDocumentPDF);
                        }
                        else
                            MessageBox.Show("Сначала сформируйте отчет .docx");
                        break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Отсутсвие Ms Office на компьютере. Пожалуйста скачайте его.");
                Process.Start("https://www.microsoft.com/ru-ru/microsoft-365/compare-all-microsoft-365-products?tab=1&rtc=1");
            }
        }

 

        private void ComboBoxЭкспорт_SelectedValueChanged(object sender, EventArgs e)
        {
            extension = comboBoxЭкспорт.SelectedItem.ToString();
        }
    }
}
