using System;
using System.Windows.Forms;

namespace SRL_Calculator
{
    public partial class frmRoSrlSalaryTaxCalculator : Form
    {
        public frmRoSrlSalaryTaxCalculator()
        {
            InitializeComponent();
        }

        private float accountantMonthlyPrice { get; set; } = 150;

        private float anafAnuallyTax { get; set; } = 3060;

        private float eurValue { get; set; } = 5;

        private float monthlySpendings { get; set; } = 0;

        private int noVatMaxValue { get; } = 25000;

        private void frmRoSrlSalaryTaxCalculator_Load(object sender, EventArgs e)
        {
            txtAnafAnnually.Text = anafAnuallyTax.ToString();
            txtAccountantMonthly.Text = accountantMonthlyPrice.ToString();
            txtSpendingsMonthly.Text = monthlySpendings.ToString();
            txtEurValue.Text = eurValue.ToString();
        }

        private void OnlyAllowNumbers(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back &&
                e.KeyData != Keys.Delete &&
                e.KeyData != Keys.OemPeriod)
            {
                e.SuppressKeyPress = !int.TryParse(Convert.ToString((char)e.KeyData), out int _);
            }
        }

        private void ResetGrossAmounts()
        {
            txtGrossMonthly.Text = "";
            txtGrossMonthlyEur.Text = "";
            txtGrossAnnually.Text = "";
            txtGrossAnnuallyEur.Text = "";
        }

        private void ResetOutputAmounts()
        {
            txt3PercentMonth.Text = "";
            txt3PercentYear.Text = "";
            txtAccountantMonth.Text = "";
            txtAccountantYear.Text = "";
            txtSpendingsMonth.Text = "";
            txtSpendingsYear.Text = "";
            txt5PercentMonth.Text = "";
            txt5PercentYear.Text = "";
            txtAnafMonth.Text = "";
            txtAnafYear.Text = "";
            txtNetMonth.Text = "";
            txtNetYear.Text = "";
            txtNetMonthEur.Text = "";
            txtNetYearEur.Text = "";
            lblPercentage.Text = "? %";
        }

        private void txtAccountantMonthly_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAccountantMonthly.Text))
            {
                UpdateAmounts();
            }
            else
            {
                ResetOutputAmounts();
            }
        }

        private void txtAnafAnnually_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnafAnnually.Text))
            {
                UpdateAmounts();
            }
            else
            {
                ResetOutputAmounts();
            }
        }

        private void txtEurValue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEurValue.Text))
            {
                eurValue = float.Parse(txtEurValue.Text);

                if (!string.IsNullOrEmpty(txtGrossMonthly.Text))
                {
                    txtGrossMonthlyEur.Text = (float.Parse(txtGrossMonthly.Text) / eurValue).ToString();
                    txtGrossAnnuallyEur.Text = (float.Parse(txtGrossAnnually.Text) / eurValue).ToString();
                }
                UpdateAmounts();
            }
            else
            {
                ResetOutputAmounts();
            }
        }

        private void txtGrossMonthly_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrossMonthly.Text))
            {
                if (float.Parse(txtGrossMonthly.Text) > noVatMaxValue)
                {
                    MessageBox.Show($"Valoarea maxima este {noVatMaxValue}", "Eroare TVA");
                    ResetGrossAmounts();
                    return;
                }

                txtGrossMonthlyEur.Text = (float.Parse(txtGrossMonthly.Text) / eurValue).ToString();

                txtGrossAnnually.Text = (float.Parse(txtGrossMonthly.Text) * 12).ToString();
                txtGrossAnnuallyEur.Text = (float.Parse(txtGrossAnnually.Text) / eurValue).ToString();
            }
            else
            {
                ResetGrossAmounts();
            }

            UpdateAmounts();
        }

        private void txtSpendingsMonthly_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSpendingsMonthly.Text))
            {
                UpdateAmounts();
            }
            else
            {
                ResetOutputAmounts();
            }
        }

        private void UpdateAmounts()
        {
            bool haveAllData = !string.IsNullOrEmpty(txtGrossMonthly.Text) &&
                !string.IsNullOrEmpty(txtAccountantMonthly.Text) &&
                !string.IsNullOrEmpty(txtSpendingsMonthly.Text) &&
                !string.IsNullOrEmpty(txtAnafAnnually.Text);

            if (!haveAllData)
            {
                ResetOutputAmounts();
            }
            else
            {
                float grossMonthly = float.Parse(txtGrossMonthly.Text);
                float accountantMonthly = float.Parse(txtAccountantMonthly.Text);
                float spendingsMonthly = float.Parse(txtSpendingsMonthly.Text);
                float anafMonthly = float.Parse(txtAnafAnnually.Text) / 12;

                // substract 3%
                txt3PercentMonth.Text = (grossMonthly - (grossMonthly * 3 / 100)).ToString();
                txt3PercentYear.Text = (float.Parse(txt3PercentMonth.Text) * 12).ToString();

                // substract accountant
                txtAccountantMonth.Text = (float.Parse(txt3PercentMonth.Text) - accountantMonthly).ToString();
                txtAccountantYear.Text = (float.Parse(txtAccountantMonth.Text) * 12).ToString();

                // substract spendings
                txtSpendingsMonth.Text = (float.Parse(txtAccountantMonth.Text) - spendingsMonthly).ToString();
                txtSpendingsYear.Text = (float.Parse(txtSpendingsMonth.Text) * 12).ToString();

                // substract 5%
                txt5PercentMonth.Text = (float.Parse(txtSpendingsMonth.Text) - (float.Parse(txtSpendingsMonth.Text) * 5 / 100)).ToString();
                txt5PercentYear.Text = (float.Parse(txt5PercentMonth.Text) * 12).ToString();

                // substract anaf
                txtAnafMonth.Text = (float.Parse(txt5PercentMonth.Text) - anafMonthly).ToString();
                txtAnafYear.Text = (float.Parse(txtAnafMonth.Text) * 12).ToString();

                // set net ammounts
                txtNetMonth.Text = txtAnafMonth.Text;
                txtNetYear.Text = txtAnafYear.Text;
                txtNetMonthEur.Text = (float.Parse(txtNetMonth.Text) / eurValue).ToString();
                txtNetYearEur.Text = (float.Parse(txtNetYear.Text) / eurValue).ToString();

                // set percentage
                lblPercentage.Text = String.Format("{0:0.00}", float.Parse(txtNetMonth.Text) * 100 / float.Parse(txtGrossMonthly.Text)) + "%";
            }
        }
    }
}