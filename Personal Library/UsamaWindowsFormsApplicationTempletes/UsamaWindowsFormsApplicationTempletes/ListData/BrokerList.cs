using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Lib.Models;

namespace UsamaWindowsFormsApplicationTempletes.ListData
{
    public partial class BrokerList : Form
    {
        private List<Broker> invoiceBroker;
        private List<Broker> _Broker;

      
        public BrokerList(List<Broker> _Broker, List<Broker> invoiceBroker)
        {
            InitializeComponent();

            this._Broker = _Broker;
            this.invoiceBroker = invoiceBroker;
        }

        private void buttonAddBroker_Click(object sender, EventArgs e)
        {
            invoiceBroker.Add(listBoxBroker.SelectedItem as Broker);

            this.Close();
        }

        private void BrokerList_Load(object sender, EventArgs e)
        {
            if (invoiceBroker.Count == 0)
            {
                listBoxBroker.DataSource = _Broker;
            }
            else
            {
                listBoxBroker.DataSource = _Broker.Except(invoiceBroker).ToList();
            }

            listBoxBroker.DisplayMember = "Name";

        }
    }
}
