using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsamaWindowsFormsApplicationTempletes.ListData
{
    public partial class SalePersonList : Form
    {
        private List<SalePerson> invoiceSalePerson;
        private List<SalePerson> _SalePerson;


        public SalePersonList(List<SalePerson> _SalePerson , List<SalePerson> invoiceSalePerson)
        {
            InitializeComponent();

            this.invoiceSalePerson = invoiceSalePerson;
            this._SalePerson = _SalePerson;
        }

        private void buttonAddSalePerson_Click(object sender, EventArgs e)
        {
            invoiceSalePerson.Add(listBoxSalePerson.SelectedItem as SalePerson);

            this.Close();

        }

        private void SalePersonList_Load(object sender, EventArgs e)
        {
            if (invoiceSalePerson.Count == 0)
            {
                listBoxSalePerson.DataSource = _SalePerson;
            }
            else
            {
                listBoxSalePerson.DataSource = _SalePerson.Except(invoiceSalePerson).ToList();
            }

            listBoxSalePerson.DisplayMember = "Name";
        }
    }
}
