using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library301172869;

namespace DeanP_301172869_A4
{
    public partial class AddClubForm : Form
    {
        public Club Club { get; private set; }

        public AddClubForm()
        {
            InitializeComponent();
        }

        private void AddClubForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == string.Empty)
            {
                MessageBox.Show("Club name must not be empty!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;
            ulong phone;
            try
            {
                phone = Convert.ToUInt64(txtPhone.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Phone Number wrong format!", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address(street, city, province, postalCode);
            Club = new Club(name, address, phone);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
