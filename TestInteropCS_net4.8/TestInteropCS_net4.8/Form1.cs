using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;


namespace TestInteropCS_net4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return; //Es para que finalice el método
            }
            //si le dio al okey
            string ruta = dialogo.FileName;
            var wordApp = new Word.Application();

            wordApp.Documents.Add();
            string dato = txtTexto.Text;
            wordApp.Selection.TypeText(dato);
            wordApp.ActiveDocument.SaveAs2(ruta);
            wordApp.Visible = true;
        }

        private void pictureBoxExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return; //Es para que finalice el método
            }
            //si le dio al okey
            string ruta = dialogo.FileName;
            Excel.Application objAplicacion = new Excel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;
            objHoja.Cells[1, 1] = txtTexto.Text;
            objAplicacion.ActiveWorkbook.SaveAs(ruta);
            objAplicacion.Visible = true;
        }
    }
}
