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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            LinksForForms formLinks = new LinksForForms();
            this.Hide();
            formLinks.Show();
        }
    }
}
