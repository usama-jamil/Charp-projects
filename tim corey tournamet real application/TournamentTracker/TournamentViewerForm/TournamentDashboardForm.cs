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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connections.GetAllTournament(); 

        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            comboBoxLoadExistingTournament.DataSource = tournaments;
            comboBoxLoadExistingTournament.DisplayMember = "TournamentName";

        }

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            var tournamentForm = new CreateTournamentForm();
            tournamentForm.Show();
        }

        private void buttonLoadTournament_Click(object sender, EventArgs e)
        {
            var tournament =(TournamentModel) comboBoxLoadExistingTournament.SelectedItem;

            var tournamentViewerForm = new FormTournametViewer(tournament);
            tournamentViewerForm.Show();
        }
    }
}
