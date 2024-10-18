using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class LinksForForms : Form
    {
        public LinksForForms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm about = new MainForm();
            this.Hide();
            about.Show();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            this.Hide();
            about.Show();
        }

        private void contact_btn_Click(object sender, EventArgs e)
        {
            ContactForm contact = new ContactForm();
            this.Hide();
            contact.Show();
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            ExchangeRateForm convertCurrency = new ExchangeRateForm();
            this.Hide();
            convertCurrency.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
