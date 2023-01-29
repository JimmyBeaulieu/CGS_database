using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CGS_database
{
    public partial class CuratorForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-R6LJ895I;Initial Catalog=CGS;Integrated Security=True");
        public CuratorForm()
        {
            InitializeComponent();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }


        private void insertBtn_Click(object sender, EventArgs e)
        {
            InsertTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        void DisplayTable()
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Curator";
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();


        }

        void InsertTable()
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Curator VALUES('" + curatorIDTextBox.Text+"', '" + curatorFirstNameTextBox.Text+"', '" +
                curatorLastNameTextBox.Text+"', '"+ Convert.ToDouble(curatorCommissionTextBox.Text)+"')";
            command.ExecuteNonQuery();
            connection.Close();
            DisplayTable();
            MessageBox.Show("You did it!!");
        }

        void UpdateTable()
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Curator SET Firstname='" + curatorFirstNameTextBox.Text + "', Lastname='" + curatorLastNameTextBox.Text + "', Commission=" +
                "'" + curatorCommissionTextBox.Text + "' WHERE CuratorID='" + curatorIDTextBox.Text + "'";
            command.ExecuteNonQuery();
            connection.Close();
            DisplayTable();
            MessageBox.Show("AlLOO !!!!11");
        }
    }
}
