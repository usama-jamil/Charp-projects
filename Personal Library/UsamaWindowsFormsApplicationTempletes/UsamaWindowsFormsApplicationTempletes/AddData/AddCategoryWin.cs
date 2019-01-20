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
    public partial class AddCategoryWin : Form
    {
        ICategoryRequester callingWin;
        public AddCategoryWin(ICategoryRequester caller)
        {
            InitializeComponent();

            callingWin = caller;
        }

        private void CategoryTextBox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void CategoryTextBox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }

        private bool IsCategoryValid()
        {
            var output = true;

            if (TextBoxCategory.Text == TextBoxCategory.Tag as string)
            {
                output = false;

                ErrorName.Text = string.Concat(ErrorName.Text, "Enter your Category...");
                ErrorName.Visible = true;

            }
            else
            {
                ErrorName.Visible = false;
            }

            return output;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            ResetError();

            if (!IsCategoryValid())
                return;

            var category = new Category
            {
                Name = TextBoxCategory.Text.Trim()
            };

            var categoryRepo = new CategoryRepository();
            categoryRepo.Add(category);

            callingWin.CompleteCategory(category);

            this.Close();

        }

        private void ResetError()
        {
            ErrorName.Text = "*";
        }

    }


}
