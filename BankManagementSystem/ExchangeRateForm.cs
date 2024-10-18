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
    public partial class ExchangeRateForm : Form
    {
        public ExchangeRateForm()
        {
            InitializeComponent();
            // Initialize the currency options
            fromcombo1.Items.AddRange(new string[] { "USD", "EUR", "GBP", "ZAR" });
            tocombo2.Items.AddRange(new string[] { "USD", "EUR", "GBP", "ZAR" });

            // Default selection (optional)
            fromcombo1.SelectedIndex = 0;
            tocombo2.SelectedIndex = 1;
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            // Validate the input amount
            if (!decimal.TryParse(amount_txt.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected currencies
            string fromCurrency = fromcombo1.SelectedItem?.ToString();
            string toCurrency = tocombo2.SelectedItem?.ToString();

            // Validate that currencies are selected
            if (fromCurrency == null || toCurrency == null)
            {
                MessageBox.Show("Please select both the currencies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to perform conversion
            decimal convertedAmount = ConvertCurrency(amount, fromCurrency, toCurrency);

            // Display the converted amount
            converted_amount.Text = $"Converted amount is: {convertedAmount:F2} {toCurrency}";
        }

        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            // Hardcoded exchange rates (for simplicity, these should be fetched from an API in real apps)
            // Example rates (1 unit of the 'from' currency in 'to' currency)
            decimal exchangeRate = 1.0m;

            if (fromCurrency == "USD" && toCurrency == "EUR") exchangeRate = 0.85m;
            else if (fromCurrency == "USD" && toCurrency == "GBP") exchangeRate = 0.75m;
            else if (fromCurrency == "USD" && toCurrency == "ZAR") exchangeRate = 18.0m;
            else if (fromCurrency == "EUR" && toCurrency == "USD") exchangeRate = 1.18m;
            else if (fromCurrency == "EUR" && toCurrency == "GBP") exchangeRate = 0.88m;
            else if (fromCurrency == "EUR" && toCurrency == "ZAR") exchangeRate = 21.0m;
            else if (fromCurrency == "GBP" && toCurrency == "USD") exchangeRate = 1.33m;
            else if (fromCurrency == "GBP" && toCurrency == "EUR") exchangeRate = 1.14m;
            else if (fromCurrency == "GBP" && toCurrency == "ZAR") exchangeRate = 24.0m;
            else if (fromCurrency == "ZAR" && toCurrency == "USD") exchangeRate = 0.055m;
            else if (fromCurrency == "ZAR" && toCurrency == "EUR") exchangeRate = 0.048m;
            else if (fromCurrency == "ZAR" && toCurrency == "GBP") exchangeRate = 0.042m;

            // If the currencies are the same, no conversion is needed
            if (fromCurrency == toCurrency)
                return amount;

            return amount * exchangeRate;
        }


        private void exit_btn_Click(object sender, EventArgs e)
        {
            LinksForForms formLinks = new LinksForForms();
            this.Hide();
            formLinks.Show();
        }
    }
}
