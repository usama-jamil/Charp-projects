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

namespace MyEmployeeDatabase
{
    
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9FPV3LG\\SQLEXPRESS;Initial Catalog=MyCompany;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand($"insert into Employees (EmployeeName,EmployeeSurname,EmployeePhone,EmployeeGender,EmployeeAddress,EmployeePosition) values ('{textBoxName.Text}','{textBoxSurname.Text}','{int.Parse(textBoxPhone.Text)}','{comboBox1.Text}','{textBoxAddress.Text}','{comboBox2.Text}')", connection);

                
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                MessageBox.Show("Employee is added...");

                listView1.Items.Clear();
                ShowEmployees();
            }
        }

        private void ShowEmployees()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand("select * from Employees", connection);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var items = new ListViewItem();

                    items.Text = reader["ID"].ToString();
                    items.SubItems.Add(reader["EmployeeName"].ToString());
                    items.SubItems.Add(reader["EmployeeSurname"].ToString());
                    items.SubItems.Add(reader["EmployeePhone"].ToString());
                    items.SubItems.Add(reader["EmployeeAddress"].ToString());
                    items.SubItems.Add(reader["EmployeeGender"].ToString());
                    items.SubItems.Add(reader["EmployeePosition"].ToString());

                    listView1.Items.Add(items);
                }

                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (IsItYes() && connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand("delete from Employees where ID = @id", connection);
                command.Parameters.AddWithValue("@id", listView1.SelectedItems[0].Text);
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                listView1.Items.Clear();

                ShowEmployees();
            }
        }

        private static bool IsItYes()
        {
            return MessageBox.Show("Do you want to delete this record...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxPhone.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxAddress.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[6].Text;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand($"update Employees set EmployeeName = '{textBoxName.Text}' ,EmployeeSurname = '{textBoxSurname.Text}' ,EmployeePhone = '{int.Parse( textBoxPhone.Text)}' ,EmployeeAddress = '{textBoxAddress.Text}' ,EmployeeGender = '{comboBox1.Text}' ,EmployeePosition = '{comboBox1.Text}' where ID = @id ", connection);

                command.Parameters.AddWithValue("@id", listView1.SelectedItems[0].Text);
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                listView1.Items.Clear();

                ShowEmployees();
            }
        }
    }
}
