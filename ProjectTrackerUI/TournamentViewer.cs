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

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;

                }
            }

            WireUpMatchupsLists();
        }

    }
}
