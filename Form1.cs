using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFRM_SALARY_CALCULATOR
{
    public partial class Form1 : Form
    {
        string fileName = null;
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = false;
            ofd.Title = "Choose an excel file";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                //create a workbook
                Workbook workbook = new Workbook();
                //load from ofd result and import the data
                workbook.LoadFromFile(fileName);
                //initialize the worksheet
                Worksheet worksheet = workbook.Worksheets[0];
                //display the data
                dataGridView1.DataSource = worksheet.ExportDataTable();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {

        }
    }
}
