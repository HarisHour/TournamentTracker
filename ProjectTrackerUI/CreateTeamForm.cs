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
    public partial class CreateTeamForm : Form
    {
        List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpLists();
        }

        private void WireUpLists()
        {

            selectTeamMembersDropDownBox.DataSource = null;


            selectTeamMembersDropDownBox.DataSource = availableTeamMembers;
            selectTeamMembersDropDownBox.DisplayMember = "FullName";

            teamMembersListbox.DataSource = null;

            teamMembersListbox.DataSource = selectedTeamMembers;
            teamMembersListbox.DisplayMember = "FullName";
        }

    

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel model = new PersonModel();
                model.FirstName = firstNameValueTextbox.Text;
                model.LastName = lastNameValueTextbox.Text;
                model.EmailAdress = emailValueTextbox.Text;
                model.CellPhoneNumber = cellphoneValueTbox.Text;

                model = GlobalConfig.Connection.CreatePerson(model);

                availableTeamMembers.Add(model);
                WireUpLists();

                firstNameValueTextbox.Text = "";
                lastNameValueTextbox.Text = "";
                emailValueTextbox.Text = "";
                cellphoneValueTbox.Text = "";

            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }

        }

        private bool ValidateForm()
        {
            if(firstNameValueTextbox.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValueTextbox.Text.Length == 0)
            {
                return false;
            }

            if (emailValueTextbox.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValueTbox.Text.Length == 0)
            {
                return false;
            }



            return true;


        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMembersDropDownBox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListbox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamMembers = selectedTeamMembers;
            t.TeamName = teamNameVallueTextbox.Text;

            t = GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
            // TODO - If we aren't closing this form after creation, reset it
        }
    }
}
