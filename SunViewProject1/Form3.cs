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

namespace SunViewProject1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // Update Datagrid with new values
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\SunViewProject1\SunViewProject1\PingGet.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT PingGetID, Ping1, GetStatic, GetDynamic, Ping2, NetStaticRT, NetDynRT FROM PingGetTable", cnn);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView2.DataSource = bSource;
                sda.Update(dbDataSet);

                //ExportData(dbDataSet, sda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pingExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Iterate through each row of the table and check for time threshold violations
            foreach (DataGridViewRow row1 in dataGridView2.Rows)
            {
                // Time threshold in ms
                double tThreshold = 500.00;
                if (Convert.ToDouble(row1.Cells[2].Value) > tThreshold ||
                    Convert.ToDouble(row1.Cells[3].Value) > tThreshold)
                {
                    // Color those rows for which there is a time threshold violation
                    row1.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
