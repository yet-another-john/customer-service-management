using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomerServiceManagementWF
{
    public partial class MainForm : Form
    {
        readonly string connectionString = @"Server = localhost\SQLEXPRESS; Database = CustomerServiceManagementDataBase; Trusted_Connection = True;";

        DataSet dataSet = new DataSet();

        void GetData()
        {
            dataSet.Clear();

            SqlConnection sqlConn = new SqlConnection(connectionString);

            sqlConn.Open();

            var select = "SELECT * FROM CustomerServiceManagementTableMain";

            var dataAdapter = new SqlDataAdapter(select, sqlConn);

            dataAdapter.Fill(dataSet);

            DataGridView.DataSource = dataSet.Tables[0];

            DataGridView.Columns["id"].ReadOnly = true;

            DataGridView.Columns["date_time"].ReadOnly = true;

            sqlConn.Close();

            SearchTextBox.Text = "";

            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.CurrentCell = DataGridView[0, DataGridView.Rows.Count - 1];                
            }
        }

        public MainForm()
        {
            InitializeComponent();
            
            GetData();
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(connectionString);
            
            sqlConn.Open();

            SqlCommand sqlComm = new SqlCommand();

            sqlComm.CommandText = $"INSERT INTO CustomerServiceManagementTableMain (date_time, incident_status, incident_number, person_name, person_tel_number, person_email, incident_details, incident_resolution) VALUES ('{DateTime.Now}', 'Открыто', 'Введите номер инцидента', 'Введите имя клиента', 'Введите номер телефона клиента', 'Введите адрес электронной почты клиента', 'Введите текст обращения', 'Введите текст решения по обращению')";
            
            sqlComm.Connection = sqlConn;
            
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

            GetData();
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(connectionString);

            sqlConn.Open();

            var select = "SELECT * FROM CustomerServiceManagementTableMain";

            var dataAdapter = new SqlDataAdapter(select, sqlConn);
                        
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        
            dataAdapter.Update(dataSet);

            sqlConn.Close();

            GetData();
        }

        private void SearchDataButton_Click(object sender, EventArgs e)
        {
            dataSet.Clear();

            SqlConnection sqlConn = new SqlConnection(connectionString);

            sqlConn.Open();

            string searchValue =  SearchTextBox.Text.ToString();

            var select = $"SELECT * FROM CustomerServiceManagementTableMain WHERE incident_status = '{searchValue}' OR incident_number = '{searchValue}' OR person_name = '{searchValue}' OR person_tel_number = '{searchValue}' OR person_email = '{searchValue}' OR incident_details = '{searchValue}' OR incident_resolution = '{searchValue}'";

            var dataAdapter = new SqlDataAdapter(select, sqlConn);

            dataAdapter.Fill(dataSet);

            DataGridView.DataSource = dataSet.Tables[0];

            DataGridView.Columns["id"].ReadOnly = true;

            DataGridView.Columns["date_time"].ReadOnly = true;

            sqlConn.Close();

            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.CurrentCell = DataGridView[0, DataGridView.Rows.Count - 1];
            }
        }

        private void DataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentCell != null)
            {
                IncidentTextBox.Text = DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[7].Value.ToString();
                
                SolutionTextBox.Text = DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[8].Value.ToString();
            }
        }

        private void IncidentTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[7].Value = IncidentTextBox.Text;
        }

        private void SolutionTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[8].Value = SolutionTextBox.Text;
        }
    }
}