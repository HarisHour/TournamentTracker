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

namespace ProjectTrackerUI
{
    public partial class TournamentViewer : Form
    {

        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        MatchupModel selectedMU = new MatchupModel();

        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();
            LoadRounds();
        }

     
        private void WireUpRoundsLists()
        {
            roundDropdown.DataSource = null;
            roundDropdown.DataSource = rounds;

            matchUpListbox.DataSource = null;
            matchUpListbox.DataSource = selectedMatchups;
            matchUpListbox.DisplayMember = "DisplayName";
        }

        private void WireUpMatchupsLists()
        {

            matchUpListbox.DataSource = null;
            matchUpListbox.DataSource = selectedMatchups;
            matchUpListbox.DisplayMember = "DisplayName";

            if(selectedMatchups.Count > 0)
            {
                MatchupModel mu = selectedMatchups.First();
                LoadMU(mu);
            }
            
            

        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
            
            //roundDropdown.DisplayMember = 
        }

        private void LoadRounds()
        {
            rounds = new List<int>();
            rounds.Add(1);
            int currRound = 1;

            foreach(List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                    
                }
            }

            WireUpRoundsLists();
        }

        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropdown.SelectedItem;

            //MatchupModel mu = new MatchupModel();
            //mu = (MatchupModel)matchUpListbox.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();

                    foreach (MatchupModel m in matchups) {
                        if (m.Winner == null || !unplayedOnlyCheckbox.Checked)
                        {

                            selectedMatchups.Add(m);
                        }

                    }
                }
            }
            

            WireUpMatchupsLists();
        }


        private void LoadMU(MatchupModel selectedMU)
        {

            int i = 0;

            if (selectedMU != null)
            {
                foreach (MatchupEntryModel entry in selectedMU.Entries)
                {

                    if (entry.TeamCompeting != null)
                    {
                        if (selectedMU.Entries.Count == 1)
                        {
                            teamOneName.Text = entry.TeamCompeting.TeamName;
                            teamTwoName.Text = "Dummy";
                        }
                        else if (selectedMU.Entries.Count == 2 && i == 0)
                        {
                            teamOneName.Text = entry.TeamCompeting.TeamName;
                            i++;
                        }
                        else
                        {
                            teamTwoName.Text = entry.TeamCompeting.TeamName;
                        }
                    }
                    else
                    {
                        teamOneName.Text = "TBA";
                        teamTwoName.Text = "TBA";
                    }
                }
            }
            else
            {
                teamOneName.Text = "TBA";
                teamTwoName.Text = "TBA";
            }
           
        }

        private void matchUpListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatchupModel mu = (MatchupModel)matchUpListbox.SelectedItem;
            LoadMU(mu);
        }

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();

        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchUpListbox.SelectedItem;

            double teamOneScore = 0;
            double teamTwoScore = 0;

            for(int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if(m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamOneScoreTextbox.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score!");
                            return;

                        }
                    }
                    else
                    {
                        MessageBox.Show("You can't enter a score yet!");
                    }

                }
                

                if(i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamTwoScoreTextbox.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score!");
                            return;

                        }
                    }
                    else
                    {
                        MessageBox.Show("You can't enter a score yet!");
                    }
                }

            }

            if (teamOneScore > teamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
                m.WinnerId = m.Entries[0].TeamCompetingId;
            }
            else if( teamTwoScore > teamOneScore)
            {
                m.Winner = m.Entries[1].TeamCompeting;
                m.WinnerId = m.Entries[1].TeamCompetingId;
            }
            else
            {
                MessageBox.Show("No ties!");
            }

          

            GlobalConfig.Connection.UpdateMatchup(m);
            
            }
        }
    }

