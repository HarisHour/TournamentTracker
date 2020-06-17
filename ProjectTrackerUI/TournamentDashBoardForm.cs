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
    public partial class TournamentDashBoardForm : Form, ITournamentRequester
    {

        List<TournamentModel> availableTournaments = GlobalConfig.Connection.GetTournaments_All();

        private void WireUpLists()
        {
            loadExTournDropDownBox.DataSource = null;

            loadExTournDropDownBox.DataSource = availableTournaments;
            loadExTournDropDownBox.DisplayMember = "TournamentName";

            

        }


        public TournamentDashBoardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void loadCrTourFormButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm tournform = new CreateTournamentForm(this);
            tournform.Show();

        }

        private void loadTournButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadExTournDropDownBox.SelectedItem;
            TournamentViewer frm = new TournamentViewer(tm);
            frm.Show();

        }

        public void TournamentComplete(TournamentModel model)
        {
            availableTournaments.Add(model);
            WireUpLists();
        }
    }
}
