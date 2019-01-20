using Project.Lib.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsamaWindowsFormsApplicationTempletes.AddData;
using UsamaWindowsFormsApplicationTempletes.Interface;
using UsamaWindowsFormsControlLibrary;
using UsamaWinFormDesgineClassLibrary2;
using Project.Lib.Models;
using UsamaWindowsFormsApplicationTempletes.ListData;

namespace UsamaWindowsFormsApplicationTempletes
{
    public partial class MainWin : Form , ICustomerRequester ,ISupplierRequester, IProductRequester
    {
        CustomerRepository   CustomerRepo = new CustomerRepository();
        SupplierRepository   SupplierRepo = new SupplierRepository();
        ProductRepository    ProductRepo  = new ProductRepository();
        CategoryRepository   CategoryRepo = new CategoryRepository();
        BrokerRepository     BrokerRepo = new BrokerRepository();
        SalePersonRepository SalePersonRepo = new SalePersonRepository();

        PurchaseInvoiceRepository    PurchaseInvoiceRepo = new PurchaseInvoiceRepository();
        SaleInvoiceRepository        SaleInvoiceRepo = new SaleInvoiceRepository();

        List<Customer> _Customers;
        List<Supplier> _Suppliers;
        List<Category> _Categories;
        List<Product>  _Products;
        List<Broker>   _Brokers;
        List<SalePerson> _SalePerson;


        List<PurchaseInvoice> _PurchaseInvoices;
        List<SaleInvoice>     _SaleIvoices;

        List<Broker>      InvoiceBroker = new List<Broker>();
        List<SalePerson> InvoiceSalePerson = new List<SalePerson>();

        public List<Supplier> Suppliers
        {
            get { return _Suppliers; }
        }

        public List<Category> Categories
        {
            get { return _Categories; }
        }

        public MainWin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);


            _Customers  = CustomerRepo.GetAll();
            _Suppliers  = SupplierRepo.GetAll();
            _Categories = CategoryRepo.GetAll();
            _Products    = ProductRepo.GetAll();
            _Brokers = BrokerRepo.GetAll();
            _SalePerson = SalePersonRepo.GetAll();

            _PurchaseInvoices = PurchaseInvoiceRepo.GetAllToday();
            _SaleIvoices = SaleInvoiceRepo.GetAllToday();

            RefreshList();
        }
     
        private void HomeButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, HomeTab, SliderPanel);

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, SalesTab, SliderPanel);

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, CustomerTab, SliderPanel);

        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, SuppliersTab, SliderPanel);

        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, PurchaseTab, SliderPanel);

        }

        private void ManageStockButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, ManageStockTab, SliderPanel);

        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
                MenuIndicator.SelectTabPage(sender as Control, uTabControl1, ReportTab, SliderPanel);

        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, StatisticTab, SliderPanel);

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            MenuIndicator.SelectTabPage(sender as Control, uTabControl1, ProductTab, SliderPanel);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                var point = new Point(m.LParam.ToInt32());
                point = this.PointToClient(point);

                if (point.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (point.X >= this.ClientSize.Width - cGrip && point.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);

            this.DoubleBuffered = true;

        }


        Dragable drag = new Dragable();

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag.MouseDown(e.X, e.Y);
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            drag.MouseMove(this, MousePosition.X, MousePosition.Y);
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag.MouseUp();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var distance = 130;
            if (panelMenu.Width == 190)
            {
                panelMenu.Width -= distance;

                uTabControl1.Width += distance;
                uTabControl1.Location = new Point(uTabControl1.Location.X - distance, uTabControl1.Location.Y);

                SettingButton.Location = new Point(15, 583);
                InfoButton.Location = new Point(15, 622);
            }
            else
            {
                panelMenu.Width += 130;

                uTabControl1.Width -= 130;
                uTabControl1.Location = new Point(uTabControl1.Location.X + distance, uTabControl1.Location.Y);

                SettingButton.Location = new Point(8, 622);
                InfoButton.Location = new Point(48, 622);
            }
        }

        private void SliderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void RefreshList()
        {
            dataGridCustomer.DataSource = null;
            dataGridCustomer.DataSource = _Customers;

            dataGridSupplier.DataSource = null;
            dataGridSupplier.DataSource = _Suppliers;

            dataGridProduct.DataSource = null;
            dataGridProduct.DataSource = _Products;

            DropDownPurchaseProduct.DataSource = null;
            DropDownPurchaseProduct.DataSource = _Products;
            DropDownPurchaseProduct.DisplayMember = "Name";

            dropDownPurchaseBroker.DataSource = null;
            dropDownPurchaseBroker.DataSource = InvoiceBroker;
            dropDownPurchaseBroker.DisplayMember = "Name";

            DropDownSaleProduct.DataSource = null;
            DropDownSaleProduct.DataSource = _Products;
            DropDownSaleProduct.DisplayMember = "Name";

            dropdownSale_SalePerson.DataSource = null;
            dropdownSale_SalePerson.DataSource = InvoiceSalePerson;
            dropdownSale_SalePerson.DisplayMember = "Name";


        }

        //private void RefreshSalePersonDropDown()
        //{
        //    dropdownSale_SalePerson.DataSource = null;
        //    dropdownSale_SalePerson.DataSource = InvoiceSalePerson;
        //    dropdownSale_SalePerson.DisplayMember = "Name";
        //}

        private void RefreshPurchaseInvoice()
        {
            dataGridPurchase.DataSource = null;
            dataGridPurchase.DataSource =PurchaseInvoiceRepo.FindProductsByBroker(_PurchaseInvoices,dropDownPurchaseBroker.SelectedItem as Broker);
        }

        private void RefreshSaleInvoice()
        {
            dataGridSale.DataSource = null;
            dataGridSale.DataSource = SaleInvoiceRepo.FindProductsBySalePerson(_SaleIvoices, dropdownSale_SalePerson.SelectedItem as SalePerson);
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var AddCustomerWin = new AddCustomerWin(this);

            AddCustomerWin.ShowDialog();
        }

        public void CompleteCustomer(Customer customer)
        {
            _Customers.Add(customer);
            RefreshList();
        }


        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            var AddSupplierWin = new AddSupplierWin(this);

            AddSupplierWin.ShowDialog();
        }

        public void CompleteSupplier(Supplier supplier)
        {
            _Suppliers.Add(supplier);
            RefreshList();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var AddProductWin = new AddProductWin(this);

            AddProductWin.ShowDialog();
        }

        public void CompleteProduct(Product product)
        {
            _Products.Add(product);
            RefreshList();
        }

        private void dropDownPurchaseBroker_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPurchaseInvoice();
        }

        private void dropdownSale_SalePerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownSale_SalePerson.SelectedItem == null) return;

            RefreshSaleInvoice();
        }
        private void buttonAddPurchaseProduct_Click(object sender, EventArgs e)
        {
            if (!IsPurchaseProductValid()) return;
            if (dropDownPurchaseBroker.SelectedItem == null) return;
            if (_PurchaseInvoices.Where(p => p.Broker.Id == (dropDownPurchaseBroker.SelectedItem as Broker).Id).First()
               .Products.Where(p => p.Id == (DropDownPurchaseProduct.SelectedItem as Product).Id).FirstOrDefault() != null) return;


            var stockProduct = DropDownPurchaseProduct.SelectedItem as Product;

            var purchaseProduct = new Product
            {
                Id = stockProduct.Id,
                Name = stockProduct.Name,
                RetailPrice = _PurchaseFactoryPrice,
                Tax = _PurchaseCustom,
                Quantity = _PurchaseProductQuantity,

                Broker = dropDownPurchaseBroker.SelectedItem as Broker,
                Category = stockProduct.Category,
                Description = stockProduct.Description,
                Supplier = stockProduct.Supplier
            };

           
            _PurchaseInvoices.Where(p => p.Broker.Id == (dropDownPurchaseBroker.SelectedItem as Broker).Id).First()
                .Products.Add(purchaseProduct);

            RefreshPurchaseInvoice();
        }
        private void buttonAddSaleProduct_Click(object sender, EventArgs e)
        {
            if (!IsSaleProductValid()) return;
            if (dropdownSale_SalePerson.SelectedItem == null) return;
            if (_SaleIvoices.Where(p => p.SalePerson.Id == (dropdownSale_SalePerson.SelectedItem as SalePerson).Id).First()
                .Products.Where(p => p.Id == (DropDownSaleProduct.SelectedItem as Product).Id).FirstOrDefault() != null) return;

            var stockProduct = DropDownSaleProduct.SelectedItem as Product;

            if (stockProduct.Quantity < _SaleProductQuantity)
            {
                MessageBox.Show($"You have only {stockProduct.Quantity} pieces","Out of Stock Product");
                return;
            }

            var saleProduct = new Product
            {
                Id = stockProduct.Id,
                Name = stockProduct.Name,
                RetailPrice = stockProduct.RetailPrice,
                Tax = stockProduct.Tax,
                Margin = stockProduct.Margin,
                Quantity = _SaleProductQuantity
            };

            _SaleIvoices.Where(p => p.SalePerson.Id == (dropdownSale_SalePerson.SelectedItem as SalePerson).Id).First()
                .Products.Add(saleProduct);

            RefreshSaleInvoice();
        }

        int _SaleProductQuantity;
        private bool IsSaleProductValid()
        {
            var output = true;

            if (!int.TryParse(textBoxSaleQuantity.Text, out _SaleProductQuantity))
            {
                output = false;
            };
            return output;
        }

        int _PurchaseProductQuantity;
        decimal _PurchaseFactoryPrice;
        decimal _PurchaseCustom;
        private bool IsPurchaseProductValid()
        {
            var output = true;

            if (!int.TryParse(textBoxPurchaseQuantity.Text, out _PurchaseProductQuantity))
            {
                output = false;
            }

            if (!decimal.TryParse(textBoxPurchaseFactoryPrice.Text, out _PurchaseFactoryPrice))
            {
                output = false;
            }

            if (!decimal.TryParse(textBoxPurchaseCustom.Text, out _PurchaseCustom))
            {
                output = false;
            }
            return output;
        }

      
        private void PurchaseAddBroker_Click(object sender, EventArgs e)
        {
            var BrokerListWin = new BrokerList(_Brokers, InvoiceBroker);

            BrokerListWin.ShowDialog();

            RefreshList();
        }

        private void buttonSaleAddSalePerson_Click(object sender, EventArgs e)
        {
            var SalePersonListWin = new SalePersonList(_SalePerson, InvoiceSalePerson);

            SalePersonListWin.ShowDialog();


            dropdownSale_SalePerson.DataSource = null;
            dropdownSale_SalePerson.DataSource = InvoiceSalePerson;
            dropdownSale_SalePerson.DisplayMember = "Name";
            //RefreshSalePersonDropDown();
            //RefreshList();
        }

        private void buttonSaleSaveInvoice_Click(object sender, EventArgs e)
        {
            var saleInvoice = SaleInvoiceRepo.FindInvoiceBySalePerson(_SaleIvoices, dropdownSale_SalePerson.SelectedItem as SalePerson);
            saleInvoice.PaymentMethod = PaymentMethodSaleInvoice.PaymentMethod;

            SaleInvoiceRepo.Save(saleInvoice);

            var saveProducts = saleInvoice.Products;
            ChangeStockProduct(saveProducts, false);

            RefreshList();
        }

        private void buttonSaleDeleteInvoice_Click(object sender, EventArgs e)
        {
            var saleInvoice = SaleInvoiceRepo.FindInvoiceBySalePerson(_SaleIvoices, dropdownSale_SalePerson.SelectedItem as SalePerson);

            SaleInvoiceRepo.Delete(saleInvoice);
            _SaleIvoices.Remove(saleInvoice);

            var deleteProducts = saleInvoice.Products;
            ChangeStockProduct(deleteProducts, true);

            InvoiceSalePerson.Remove(saleInvoice.SalePerson);

            RefreshList();
        }

        private void buttonPurchaseSaveInvoice_Click(object sender, EventArgs e)
        {
            if (dropDownPurchaseBroker.SelectedItem == null) return;

            var purchaseInvoice = PurchaseInvoiceRepo.FindInvoiceByBroker(_PurchaseInvoices, dropDownPurchaseBroker.SelectedItem as Broker);
            purchaseInvoice.PaymentMethod = PaymentMethodPurchaseInvoice.PaymentMethod;
           

            PurchaseInvoiceRepo.Save(purchaseInvoice);

            var saveProducts = purchaseInvoice.Products;
            ChangeStockProduct(saveProducts, true);

            RefreshList();
        }

        private void buttonPurchaseDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dropDownPurchaseBroker.SelectedItem == null) return;

            var purchaseInvoice = PurchaseInvoiceRepo.FindInvoiceByBroker(_PurchaseInvoices, dropDownPurchaseBroker.SelectedItem as Broker);

            PurchaseInvoiceRepo.Delete(purchaseInvoice);
            _PurchaseInvoices.Remove(purchaseInvoice);

            var deleteProducts = purchaseInvoice.Products;
            ChangeStockProduct(deleteProducts,false);

            InvoiceBroker.Remove(purchaseInvoice.Broker);

            RefreshList();
        }

        private void ChangeStockProduct(List<Product> deleteProducts,bool stockWay)
        {
            foreach (var product in deleteProducts)
            {
                var index = _Products.FindIndex(p => p.Id == product.Id);
                if (stockWay)
                {
                    _Products[index].Quantity += product.Quantity;
                    ProductRepo.AddQuantity(product);
                }
                else
                {
                    _Products[index].Quantity -= product.Quantity;
                    ProductRepo.SubQuantity(product);
                }
            }
        }

        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace( textBoxSearchCustomer.Text))
            {
                RefreshList();
            }
            else
            {
                dataGridCustomer.DataSource = _Customers.Where(c => c.Name.ToLower().Contains(textBoxSearchCustomer.Text.ToLower())).ToList();
            }
        }
    }
}
