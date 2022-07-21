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
                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;'");
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from Sheet1", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
    }
}
