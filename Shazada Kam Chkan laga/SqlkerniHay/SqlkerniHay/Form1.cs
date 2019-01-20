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

namespace SqlkerniHay
{
    
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9FPV3LG\\SQLEXPRESS;Initial Catalog=MyContacts;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand();

                command.Connection = connection;
                //command.CommandText = "insert into contacts(name,surname,phone) values('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "')";
                command.CommandText = $"insert into contacts(name,surname,phone) values(' { textBox1.Text } ' , '{ textBox2.Text }' , '{ textBox3.Text }')";
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                ListContacts();

                MessageBox.Show("contact is added...");
            }
        }

        private void ListContacts()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from contacts";

                var adapter = new SqlDataAdapter(command);

                var dataSet = new DataSet();

                adapter.Fill(dataSet, "contacts");

                dataGridView1.DataSource = dataSet.Tables["contacts"];
                dataGridView1.Columns[0].Visible = false;
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListContacts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsMessageYes() && connection.State == ConnectionState.Closed)
            {
                connection.Open();
                var command = new SqlCommand("delete from contacts where id=@id", connection);
                command.Parameters.AddWithValue("@id",dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                ListContacts();

            }
        }

        private static bool IsMessageYes()
        {
            return MessageBox.Show("Are you want to delete record", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                var command = new SqlCommand($"update contacts set name = '{textBox1.Text}' , surname = '{textBox2.Text}' , phone = '{textBox3.Text}' where id = @id",connection);
                command.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                MessageBox.Show("Update is complete ...");
                ListContacts();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
