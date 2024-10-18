using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManagementSystem
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void contact_submit_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string name = txtName.Text;
            string email = txtEmail.Text;
            string contactNumber = txtContact.Text;
            string message = txtMessage.Text;

            // Basic validation (optional, add your own logic)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Please fill out all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Handle form submission logic here
                // You can save to a database, send an email, or process the data.
                MessageBox.Show("Your message has been submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after submission
                txtName.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtMessage.Clear();
            }
        }

        private void contact_exit_Click(object sender, EventArgs e)
        {
            LinksForForms formLinks = new LinksForForms();
            this.Hide();
            formLinks.Show();
        }
    }
}
