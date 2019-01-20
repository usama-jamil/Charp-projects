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

namespace ProductDatabase
{
    public partial class FormUpdate : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9FPV3LG\\SQLEXPRESS;Initial Catalog=MyStore;Integrated Security=True");

        public FormUpdate()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

                var command = new SqlCommand("update Products set Name = @name, Type = @type, Price = @price, Supplier = @supplier, Origin = @origin, Description = @description  where id = @id ", connection);

                command.Parameters.AddWithValue("@id", labelID.Text);
                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@type", comboBoxType.Text);
                command.Parameters.AddWithValue("@price", textBoxPrice.Text);
                command.Parameters.AddWithValue("@supplier", textBoxSupplier.Text);
                command.Parameters.AddWithValue("@origin", textBoxOrigin.Text);
                command.Parameters.AddWithValue("@description", textBoxDescription.Text);

                command.ExecuteNonQuery();
                command.Dispose();

                connection.Close();
                MessageBox.Show("Product is updated...");
            }
        }


        private void FormUpdate_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Form1.name;
            textBoxPrice.Text = Form1.price;
            textBoxOrigin.Text = Form1.origin;
            textBoxSupplier.Text = Form1.supplier;
            textBoxDescription.Text = Form1.description;
            labelID.Text = Form1.id;
            comboBoxType.Text = Form1.type;
        }
    }
}
