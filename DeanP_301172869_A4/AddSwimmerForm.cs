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
    public partial class AddSwimmerForm : Form
    {
        public Swimmer Swimmer { get; private set; }

        public AddSwimmerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == string.Empty)
            {
                MessageBox.Show("Swimmer name must not be empty!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dateOfBirth = dateTimePicker.Value;
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;
            ulong phone;
            try
            {
                phone = Convert.ToUInt64(txtPhone.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phone Number wrong format!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address(street, city, province, postalCode);
            Swimmer = new Swimmer(name, dateOfBirth, address, phone);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
