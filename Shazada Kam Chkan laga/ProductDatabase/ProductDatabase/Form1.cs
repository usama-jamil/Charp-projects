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

namespace ProductDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9FPV3LG\\SQLEXPRESS;Initial Catalog=MyStore;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand("insert into Products ( Name, Type, Price, Supplier, Origin, Description ) values ( @name, @type, @price, @supplier, @origin, @description) ", connection);

                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@type", comboBoxType.Text);
                command.Parameters.AddWithValue("@price", textBoxPrice.Text);
                command.Parameters.AddWithValue("@supplier", textBoxSupplier.Text);
                command.Parameters.AddWithValue("@origin", textBoxOrigin.Text);
                command.Parameters.AddWithValue("@description", textBoxDescription.Text);

                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();
                MessageBox.Show("Product is added...");

                textBoxName.Clear();
                comboBoxType.Text = "";
                textBoxPrice.Clear();
                textBoxSupplier.Clear();
                textBoxOrigin.Clear();
                textBoxDescription.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowProducts(0);

            page = 0;

            PageNumber();
        }
        int rows;
        private void ShowProducts(int counter)
        {
            
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    var command = new SqlCommand("select * from Products", connection);

                    var table = new DataTable();
                    var adapter = new SqlDataAdapter(command);

                    adapter.Fill(table);

                    if (counter == -1)
                        counter = table.Rows.Count - 1;

                    labelID.Text = table.Rows[counter]["ID"].ToString();
                    labelName.Text = table.Rows[counter]["Name"].ToString();
                    labelType.Text = table.Rows[counter]["Type"].ToString();
                    labelPrice.Text = table.Rows[counter]["Price"].ToString();
                    labelSupplier.Text = table.Rows[counter]["Supplier"].ToString();
                    labelOrigin.Text = table.Rows[counter]["Origin"].ToString();
                    labelDescription.Text = table.Rows[counter]["Description"].ToString();

                    command.ExecuteNonQuery();
                    command.Dispose();

                    connection.Close();

                    rows = table.Rows.Count;
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Error" + error);
            }
            
            
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            ShowProducts(-1);

            page = rows - 1;

            PageNumber();
        }

        private void PageNumber()
        {
            labelPage.Text = page.ToString();
        }

        int page = 1;
        private void next_Click(object sender, EventArgs e)
        {
            if (page < rows -1 )
            {
                page++;

                ShowProducts(page);

                PageNumber();
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (page> 0)
            {
                page--;

                ShowProducts(page);

                PageNumber();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (IsToDelete() && connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand("delete from Products where id = @id", connection);

                command.Parameters.AddWithValue("@id", labelID.Text);

                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();

                MessageBox.Show("Product was deleted");
            }
        }

        private static bool IsToDelete()
        {
            return MessageBox.Show("Are you sure To Delete...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static string name, price, type, supplier, origin, description ,id;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            name = labelID.Text;
            price = labelPrice.Text;
            type = labelType.Text;
            supplier = labelSupplier.Text;
            origin = labelOrigin.Text;
            description = labelDescription.Text;
            id = labelID.Text;
            var updateForm = new FormUpdate();
            updateForm.ShowDialog();
            
            
        }
    }
}
