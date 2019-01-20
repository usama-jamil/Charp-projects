using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class DataSetForm : Form
    {
        public DataSetForm()
        {
            InitializeComponent();
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myContactsDataSet);

        }

        private void DataSetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myContactsDataSet.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.myContactsDataSet.contacts);
            

        }


     
    }
}
