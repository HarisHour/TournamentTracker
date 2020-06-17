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

        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();
        }

     
        private void WireUpLists()
        {
            roundDropdown.DataSource = null;
            roundDropdown.DataSource = rounds;
        }
       
        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
            
            //roundDropdown.DisplayMember = 
        }

        private void LoadRounds()
        {
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

            WireUpLists();
        }

    }
}
