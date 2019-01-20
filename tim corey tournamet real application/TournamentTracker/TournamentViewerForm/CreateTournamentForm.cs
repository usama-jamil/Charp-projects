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
    public partial class CreateTournamentForm : Form, IPrizeRequester , ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connections.GetAllTeam();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();


        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            comboBoxSelectTeam.DataSource = null;
            comboBoxSelectTeam.DataSource = availableTeams;
            comboBoxSelectTeam.DisplayMember = "TeamName";

            listBoxTornamentTeams.DataSource = null;
            listBoxTornamentTeams.DataSource = selectedTeams;
            listBoxTornamentTeams.DisplayMember = "TeamName";

            listBoxPrizes.DataSource = null;
            listBoxPrizes.DataSource = selectedPrizes;
            listBoxPrizes.DisplayMember = "PlaceName";
        }


        private void buttonAddTeam_Click(object sender, EventArgs e)
        {

            var team = (TeamModel) comboBoxSelectTeam.SelectedItem;

            if (team != null)
            {
                availableTeams.Remove(team);

                selectedTeams.Add(team);

                WireUpLists();
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            var createPrizeForm = new CreatePrizeForm(this);

            createPrizeForm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);

            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);

            WireUpLists();
        }

        private void linkLabelCreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var createTeamForm = new CreateTeamForm(this);

            createTeamForm.Show();
        }

        private void buttonRemoveSelectedPlayers_Click(object sender, EventArgs e)
        {
            var team = (TeamModel)listBoxTornamentTeams.SelectedItem;

            if (team != null)
            {
                selectedTeams.Remove(team);
                availableTeams.Add(team);

                WireUpLists();  
            }
        }

        private void buttonRemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            var prize = (PrizeModel)listBoxPrizes.SelectedItem;

            if (prize != null)
            {
                selectedPrizes.Remove(prize);

                WireUpLists();
            }
        }

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            decimal fee = 0 ;

            bool feeAceptable = decimal.TryParse(textBoxEntryFee.Text, out fee);

            if (!feeAceptable)
            {
                MessageBox.Show("You need to enter Valid Entry Fee.",
                                "Invalid Fee",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            //Create tournament model 
            var tournament = new TournamentModel();

            tournament.TournamentName = textBoxTournamentName.Text;
            tournament.EntryFee = fee;

            tournament.Prizes = selectedPrizes;
            tournament.EnteredTeams = selectedTeams;

            // TODO - Wireup the matchups then we can save this tournament.
            TournamentLogic.CreateRounds(tournament);

            // Create tournament Entry
            // Create all prizes entries
            // Create all of team entries
            GlobalConfig.Connections.CreateTournament(tournament);

            tournament.AlertUsersToNewRounds();

            var tournamentViewerForm = new FormTournametViewer(tournament);
            tournamentViewerForm.Show();

            this.Close();
        }
    }
}
