using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Added Namespaces
using System.Data.SqlClient;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;

namespace SunViewProject1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Update Datagrid with new values
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\SunViewProject1\SunViewProject1\Servers.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT ServerId, ResponseTime, TSRequest, TSResponse, TypeOfServer, TSDifference FROM ServersDB", cnn);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);

                //ExportData(dbDataSet, sda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ExportData(DataTable dbData, SqlDataAdapter adapter)
        {
            // Export data to excel file
            DataSet ds = new DataSet("New_DataSet");
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            adapter.Fill(dbData);
            ds.Tables.Add(dbData);
            ExcelLibrary.DataSetHelper.CreateWorkbook(@"H:\SunViewProject1\SunViewProject1\test3b_Wireless_program.xls", ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int flag = 0;
            // Iterate through each row of the table and check for time threshold violations
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Time threshold in ms
                double tThreshold = 500.00;
                if (Convert.ToDouble(row.Cells[1].Value) > tThreshold)
                {
                    // Color those rows for which there is a time threshold violation
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    flag++;
                }

                if (flag == 10)
                {
                    MessageBox.Show("Consecutive time threshold violation.");
                }
            }
        }
    }
}
