using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TournamentViewerForm
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetAllPerson();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
           // CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData ()
        {
            availableTeamMembers.Add(new PersonModel() { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel() { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel() { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel() { FirstName = "Bill", LastName = "Jones" });
        }
        private void WireUpLists()
        {
            comboBoxSelectTeamMember.DataSource = null;

            comboBoxSelectTeamMember.DataSource = availableTeamMembers;
            comboBoxSelectTeamMember.DisplayMember = "FullName";


            listBoxTeamMembers.DataSource = null;

            listBoxTeamMembers.DataSource = selectedTeamMembers;
            listBoxTeamMembers.DisplayMember = "FullName";
        }

        private void buttonCreateMember_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                var person = new PersonModel();

                person.FirstName = textBoxFirstName.Text;
                person.LastName = textBoxLastName.Text;
                person.EmailAddress = textBoxEmail.Text;
                person.CellPhoneNumber = textBoxCellPhone.Text;

                GlobalConfig.Connections.CreatePerson(person);

                selectedTeamMembers.Add(person);

                WireUpLists();

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxCellPhone.Text = "";
            }
            else
            {
                MessageBox.Show("Fill all the fields...");
            }
        }

        private bool IsValidForm()
        {
            if (textBoxFirstName.Text.Length == 0)
            {
                return false;
            }

            if (textBoxLastName.Text.Length == 0)
            {
                return false;
            }

            if (textBoxEmail.Text.Length == 0)
            {
                return false;
            }

            if (textBoxCellPhone.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            var person = (PersonModel) comboBoxSelectTeamMember.SelectedItem;

            if ( person != null)
            {
                availableTeamMembers.Remove(person);

                selectedTeamMembers.Add(person);

                WireUpLists(); 
            }
        }

        private void buttonRemoveSelectedMembers_Click(object sender, EventArgs e)
        {
            var person = (PersonModel)listBoxTeamMembers.SelectedItem;

            if ( person != null)
            {
                selectedTeamMembers.Remove(person);

                availableTeamMembers.Add(person);

                WireUpLists(); 
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            var team = new TeamModel();
            team.TeamName = textBoxTeamName.Text;
            team.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connections.CreateTeam(team);

            callingForm.TeamComplete(team);

            this.Close();

            // TODO - If we aren't closing this form after creation , reset the form
        }
    }
}
