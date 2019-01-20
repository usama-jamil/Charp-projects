using Project.Lib.Models;
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
using UsamaWindowsFormsApplicationTempletes.Interface;
using UsamaWinFormDesgineClassLibrary2;

namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    public partial class AddProductWin : Form,ICategoryRequester,ISupplierRequester
    {
        IProductRequester callingWin;
        public AddProductWin(IProductRequester caller)
        {
            InitializeComponent();

            callingWin = caller;

            RefreshList();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }


        private void ResetErrors()
        {
            ErrorName.Text = "*";
            ErrorDescription.Text = "*";
            ErrorSupplier.Text = "*";
            ErrorCategory.Text = "*";
        }

        private void ButtonAddNewCategory_Click(object sender, EventArgs e)
        {
            var AddCategoryWin = new AddCategoryWin(this);
            AddCategoryWin.Show();

            RefreshList();
        }
        public void CompleteCategory(Category category)
        {
            callingWin.Categories.Add(category);

            RefreshList();
        }

        private void ButtonAddNewSupplier_Click(object sender, EventArgs e)
        {
            var AddSupplierWin = new AddSupplierWin(this);
            AddSupplierWin.Show();

            RefreshList();
        }
        public void CompleteSupplier(Supplier supplier)
        {
            callingWin.Suppliers.Add(supplier);

            RefreshList();
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!IsProductValid())
                return;

            var product = new Product
            {
                Name = TextBoxName.Text.Trim(),
                Description = TextBoxDescription.Text.Trim(),
                Supplier = DropDownSupplier.SelectedItem as Supplier,
                Category = DropDownCategory.SelectedItem as Category
            };

            var productRepo = new ProductRepository();
            productRepo.Add(product);

            callingWin.CompleteProduct(product);

            this.Close();
        }

        private bool IsProductValid()
        {
            var output = true;

            if (TextBoxName.Text == TextBoxName.Tag as string)
            {
                output = false;

                ErrorName.Text = string.Concat(ErrorName.Text, "Enter a Product...");
                ErrorName.Visible = true;
            }
            else
            {
                ErrorName.Visible = false;
            }

            if (TextBoxDescription.Text == TextBoxDescription.Tag as string)
            {
                output = false;

                ErrorDescription.Text = string.Concat(ErrorDescription.Text, "Enter a Description...");
                ErrorDescription.Visible = true;
            }
            else
            {
                ErrorDescription.Visible = false;
            }

            if (DropDownSupplier.SelectedItem == null)
            {
                output = false;

                ErrorSupplier.Text = string.Concat(ErrorSupplier.Text, "Enter a Supplier...");
                ErrorSupplier.Visible = true;
            }
            else
            {
                ErrorSupplier.Visible = false;
            }

            if (DropDownCategory.SelectedItem == null)
            {
                output = false;

                ErrorCategory.Text = string.Concat(ErrorCategory.Text, "Enter a Category...");
                ErrorCategory.Visible = true;
            }
            else
            {
                ErrorCategory.Visible = false;
            }

            return output;
        }

       

        private void RefreshList()
        {
            DropDownSupplier.DataSource = null;
            DropDownSupplier.DataSource = callingWin.Suppliers;
            DropDownSupplier.DisplayMember = "Name";

            DropDownCategory.DataSource = null;
            DropDownCategory.DataSource = callingWin.Categories;
            DropDownCategory.DisplayMember = "Name";
        }

    }
}
