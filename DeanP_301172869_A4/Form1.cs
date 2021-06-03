using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Library301172869;

namespace DeanP_301172869_A4
{
    public partial class Form1 : Form
    {
        private readonly IClubsRepository clubsManager;
        private readonly ISwimmersRepository swimmersManager;
        private readonly BindingSource clubsBinding = new BindingSource();
        private readonly BindingSource swimmersBinding = new BindingSource();
        private readonly BindingSource clubSwimmersBinding = new BindingSource();
        private readonly List<Registrant> clubSwimmers = new List<Registrant>();

        public Form1()
        {
            InitializeComponent();
            clubsManager = new ClubsManager();
            swimmersManager = new SwimmersManager(clubsManager);

            clubsBinding.DataSource = clubsManager.Clubs;
            listClubs.DisplayMember = "Name";
            listClubs.DataSource = clubsBinding;
            swimmersBinding.DataSource = swimmersManager.Swimmers;
            listSwimmers.DisplayMember = "Name";
            listSwimmers.DataSource = swimmersBinding;
            clubSwimmersBinding.DataSource = clubSwimmers;
            listBoxClubSwimmers.DisplayMember = "Name";
            listBoxClubSwimmers.DataSource = clubSwimmersBinding;
        }

        private void btnLoadClubs_Click(object sender, EventArgs e)
        {
            string path = txtBoxClubsPath.Text;
            if (!File.Exists(path))
            {
                showError("File does not exist!");
                return;
            }

            clubsManager.LoadClubs(path, ",");
            clubsBinding.ResetBindings(false);
        }

        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            AddSwimmerForm addSwimmerForm = new AddSwimmerForm();

            if (addSwimmerForm.ShowDialog() == DialogResult.Cancel)
                return;

            Swimmer swimmer = addSwimmerForm.Swimmer;
            swimmersManager.AddSwimmer(swimmer);
            swimmersBinding.ResetBindings(false);
        }

        private void btnLoadSwimmers_Click(object sender, EventArgs e)
        {
            string path = textBoxSwimmersPath.Text;
            if (!File.Exists(path))
            {
                showError("File does not exist!");
                return;
            }

            swimmersManager.LoadSwimmers(path, ",");
            swimmersBinding.ResetBindings(false);
        }

        private void listClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Club club = listClubs.SelectedItem as Club;

            if (club == null)
                return;

            labelClubNumber.Text = club.ClubNumber.ToString();
            labelClubName.Text = club.Name;
            Address address = club.ClubAddress;
            labelClubStreet.Text = address.Street;
            labelClubCity.Text = address.City;
            labelClubProvince.Text = address.Province;
            labelClubPostalCode.Text = address.PostalCode;
            labelClubPhone.Text = club.PhoneNumber.ToString();
            labelClubCoach.Text = club.Coach == null ? "Not Assigned" : club.Coach.Name;
            List<Registrant> swimmers = club.Swimmers;
            clubSwimmers.Clear();
            clubSwimmers.AddRange(swimmers);
            clubSwimmersBinding.ResetBindings(false);
            listBoxClubSwimmers.ClearSelected();
        }

        private void listBoxClubSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registrant swimmer = listBoxClubSwimmers.SelectedItem as Registrant;
            if (swimmer == null)
                return;
            updateSwimmerInfo(swimmer);
        }

        private void updateSwimmerInfo(Registrant swimmer)
        {
            labelSwimmerName.Text = swimmer.Name;
            labelSwimmerNumber.Text = swimmer.Id.ToString();
            Address address = swimmer.Address;
            labelSwimmerStreet.Text = address.Street;
            labelSwimmerCity.Text = address.City;
            labelSwimmerProvince.Text = address.Province;
            labelSwimmerPostalCode.Text = address.PostalCode;
            string dateString = swimmer.DateOfBirth.ToString(
                                            "yyyy-MM-dd",
                                            CultureInfo.InvariantCulture);
            labelSwimmerPhone.Text = swimmer.PhoneNumber.ToString();
            labelSwimmerDOB.Text = dateString;
            labelSwimmerClub.Text = swimmer.Club == null ? "Not Assigned" : swimmer.Club.Name;
        }

        private void listSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registrant swimmer = listSwimmers.SelectedItem as Registrant;
            updateSwimmerInfo(swimmer);
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            AddClubForm addClubForm = new AddClubForm();

            if (addClubForm.ShowDialog() == DialogResult.Cancel)
                return;

            Club club = addClubForm.Club;
            clubsManager.AddClub(club);
            clubsBinding.ResetBindings(false);
        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {
            string path = txtBoxClubsPath.Text;
            clubsManager.SaveClubs(path, ",");

            showInfo("Clubs Saved!");
        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {
            string path = textBoxSwimmersPath.Text;
            swimmersManager.SaveSwimmers(path, ",");

            showInfo("Swimmers Saved!");
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (listClubs.SelectedIndex == -1 || listSwimmers.SelectedIndex == -1)
            {
                showError("Select a Club and Swimmer to Assign!");
                return;
            }

            Club club = listClubs.SelectedItem as Club;
            Swimmer swimmer = listSwimmers.SelectedItem as Swimmer;

            if(swimmer.Club != null)
            {
                showError("Swimmer is already assigned to a club!");
                return;
            }

            string message = $"Do you want to assign Swimmer: {swimmer.Name} to Club: {club.Name}?";
            
            DialogResult result = MessageBox.Show(message, "Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                return;

            try
            {
                swimmer.Club = club;
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            listClubs.SetSelected(listClubs.SelectedIndex, true);
            listSwimmers.SetSelected(listSwimmers.SelectedIndex, true);
            listBoxClubSwimmers.ClearSelected();

            showInfo("Swimmer successfully assigned!");
        }

        private void showError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string browseFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        private void btnClubBrowse_Click(object sender, EventArgs e)
        {
            string path = browseFile();
            txtBoxClubsPath.Text = path;
        }

        private void btnSwimmersBrowse_Click(object sender, EventArgs e)
        {
            string path = browseFile();
            textBoxSwimmersPath.Text = path;
        }
    }
}
