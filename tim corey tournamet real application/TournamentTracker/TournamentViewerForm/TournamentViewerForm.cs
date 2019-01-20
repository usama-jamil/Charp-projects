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
    public partial class FormTournametViewer : Form
    {
        private TournamentModel _tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public FormTournametViewer(TournamentModel tournament)
        {
            InitializeComponent();

           _tournament = tournament;

            _tournament.OnTournamentComplete += _tournament_OnTournamentComplete;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void _tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            labelTournamentName.Text = _tournament.TournamentName;
        }

        private void WireUpLists()
        {
            comboBoxRound.DataSource = rounds;

            listBoxMatchup.DataSource = selectedMatchups;
            listBoxMatchup.DisplayMember = "MatchupName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            var currentRound = 1;

            foreach (var matchups in _tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currentRound)
                {
                    currentRound = matchups.First().MatchupRound;
                    rounds.Add(currentRound);
                }   
            }

            LoadMatchups(1);
        }

        private string ValidateForm()
        {
            var output = "";

            var teamOneScore = 0.0;
            var teamTwoScore = 0.0;

            var isScoreOneValid = double.TryParse(textBoxTeamOneScore.Text, out teamOneScore);
            var isScoreTwoValid = double.TryParse(textBoxTeamTwoScore.Text, out teamTwoScore);

            if (!isScoreOneValid && !isScoreTwoValid)
            {
                output = "The both Score value is not valid number.";
            }
            else if (!isScoreOneValid)
            {
                output = $"The { labelTeamOne.Text } Score value is not valid number.";

            }
            else if (!isScoreTwoValid)
            {
                output = $@"The { labelTeamTwo.Text } Score value is not valid number.";
            }
            else if (teamOneScore == 0 && teamTwoScore == 0 )
            {
                output = "You did not enter a score for either team.";
            }
            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties in this application.";
            }

            return output;
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            var errorMessage = ValidateForm();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            var matchup = (MatchupModel)listBoxMatchup.SelectedItem;
            var teamOneScore = 0.0;
            var teamTwoScore = 0.0;

            for (int i = 0; i < matchup.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (matchup.Entries[0].TeamCompeting != null)
                    {
                        var isScoreValid = double.TryParse(textBoxTeamOneScore.Text, out teamOneScore);

                        if (isScoreValid)
                        {
                            matchup.Entries[0].Score = teamOneScore ;

                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team one.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (matchup.Entries[1].TeamCompeting != null)
                    {
                        var isScoreValid = double.TryParse(textBoxTeamTwoScore.Text, out teamTwoScore);

                        if (isScoreValid)
                        {
                            matchup.Entries[1].Score = teamTwoScore;

                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team two.");
                            return;
                        }

                    }
                    
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(_tournament);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had following error: { ex.Message }");
                return;
            }                       
            LoadMatchups((int)comboBoxRound.SelectedItem);

        }


        private void comboBoxRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)comboBoxRound.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (var matchups in _tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (var matchup in matchups)
                    {
                        if (matchup.Winner == null || !checkBoxUnplayedOnly.Checked)
                        {
                            selectedMatchups.Add(matchup);
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());

                DisplayMatchupInfo( true );
            }
        }

        private void DisplayMatchupInfo(bool isVisible)  // TODO - ye usama nay change kia hay Lesson 23 Time 28:22
        {
            labelTeamOne.Visible = isVisible;
            labelTeamOneScore.Visible = isVisible;
            textBoxTeamOneScore.Visible = isVisible;

            labelTeamTwo.Visible = isVisible;
            labelTeamTwoScore.Visible = isVisible;
            textBoxTeamTwoScore.Visible = isVisible;

            buttonScore.Visible = isVisible;
            labelVersus.Visible = isVisible;
        }

        private void LoadMatchup( MatchupModel matchup )
        {
          

            for (int i = 0; i < matchup.Entries.Count ; i++)
            {
                if ( i == 0 )
                {
                    if ( matchup.Entries[0].TeamCompeting != null )
                    {
                        labelTeamOne.Text = matchup.Entries[0].TeamCompeting.TeamName;
                        textBoxTeamOneScore.Text = matchup.Entries[0].Score.ToString();

                        labelTeamTwo.Text = "< bye >";
                        textBoxTeamTwoScore.Text = "0";
                    }
                    else
                    {
                        labelTeamOne.Text = "Not Yet Set ";
                        textBoxTeamOneScore.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (matchup.Entries[1].TeamCompeting != null)
                    {
                        labelTeamTwo.Text = matchup.Entries[1].TeamCompeting.TeamName;
                        textBoxTeamTwoScore.Text = matchup.Entries[1].Score.ToString();
                    }
                    else
                    {
                        labelTeamTwo.Text = "Not Yet Set ";
                        textBoxTeamTwoScore.Text = "";
                    }
                }
            }
        }

        private void listBoxMatchup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)listBoxMatchup.SelectedItem);
        }

        private void checkBoxUnplayedOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)comboBoxRound.SelectedItem);
        }
    }
}