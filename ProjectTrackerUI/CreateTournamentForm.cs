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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDownBox.DataSource = null;

            selectTeamDropDownBox.DataSource = availableTeams;
            selectTeamDropDownBox.DisplayMember = "TeamName";

            teamsListbox.DataSource = null;

            teamsListbox.DataSource = selectedTeams;
            teamsListbox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";


        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)selectTeamDropDownBox.SelectedItem;
            if(team != null)
            {
                selectedTeams.Add(team);
                availableTeams.Remove(team);

                WireUpLists();
            }
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)teamsListbox.SelectedItem;
            if(team != null)
            {
                selectedTeams.Remove(team);
                availableTeams.Add(team);

                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the Create{rize form

            CreatePrizeForm pform = new CreatePrizeForm(this);
            pform.Show();
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a PrizeModel
            //Put the PrizeModel into the list of selected prizes

            selectedPrizes.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm tform = new CreateTeamForm(this);
            tform.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            availableTeams.Add(model);
            WireUpLists();
        }

        private void deletePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel prize = (PrizeModel)prizesListBox.SelectedItem;
            if(prize != null)
            {
                selectedPrizes.Remove(prize);
                WireUpLists();
            }
                   
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //create tournament entry
            TournamentModel tm = new TournamentModel();

            decimal fee = 0;
            bool feeIsValid = decimal.TryParse(entryFeeValueTextbox.Text, out fee);

            if (!feeIsValid)
            {
                MessageBox.Show("You need to enter a valid entry fee",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

        

            tm.TournamentName = tournamentNameVallueTextbox.Text;
            //tm.EntreeFee = decimal.Parse(entryFeeValueTextbox.Text);
            tm.EntreeFee = fee;

            tm.EnteredTeams = selectedTeams;
            tm.Prizes = selectedPrizes;

            //TODO - Wire up matchups
            TournamentLogic.CreateRounds(tm);





            GlobalConfig.Connection.CreateTournament(tm);

            //create all of the prizes entries
            //create all of the team entries
        }
    }
}
