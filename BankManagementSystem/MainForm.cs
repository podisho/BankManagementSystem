﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinksForForms formLinks = new LinksForForms();
            this.Hide();
            formLinks.Show();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm formLinks = new RegistrationForm();
            this.Hide();
            formLinks.Show();
        }
    }
}
