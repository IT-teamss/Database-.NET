using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopbowl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-HGQAP5N;Initial Catalog=BowlingStormAccessories;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Size = new Size(1300,800);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("Zakaz", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;
                sqlConnection.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("ZakazWithParameters", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("IdOrder", SqlDbType.NVarChar).Value = IdOrderText.Text.Trim();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;
                sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
