
namespace SRL_Calculator
{
    partial class frmRoSrlSalaryTaxCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGrossMonthly = new System.Windows.Forms.TextBox();
            this.lblGrossMonthly = new System.Windows.Forms.Label();
            this.lblAccountantMonthly = new System.Windows.Forms.Label();
            this.txtAccountantMonthly = new System.Windows.Forms.TextBox();
            this.lblGrossAnnually = new System.Windows.Forms.Label();
            this.txtGrossAnnually = new System.Windows.Forms.TextBox();
            this.lblAnafAnnually = new System.Windows.Forms.Label();
            this.txtAnafAnnually = new System.Windows.Forms.TextBox();
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.lbl3Percent = new System.Windows.Forms.Label();
            this.txt3PercentMonth = new System.Windows.Forms.TextBox();
            this.txt3PercentYear = new System.Windows.Forms.TextBox();
            this.lbl3PercentMonth = new System.Windows.Forms.Label();
            this.lbl3PercentYear = new System.Windows.Forms.Label();
            this.lblAccountantYear = new System.Windows.Forms.Label();
            this.lblAccountantMonth = new System.Windows.Forms.Label();
            this.txtAccountantYear = new System.Windows.Forms.TextBox();
            this.txtAccountantMonth = new System.Windows.Forms.TextBox();
            this.lblAccountant = new System.Windows.Forms.Label();
            this.lbl5PercentYear = new System.Windows.Forms.Label();
            this.lbl5PercentMonth = new System.Windows.Forms.Label();
            this.txt5PercentYear = new System.Windows.Forms.TextBox();
            this.txt5PercentMonth = new System.Windows.Forms.TextBox();
            this.lbl5Percent = new System.Windows.Forms.Label();
            this.lblAnafYear = new System.Windows.Forms.Label();
            this.lblAnafMonth = new System.Windows.Forms.Label();
            this.txtAnafYear = new System.Windows.Forms.TextBox();
            this.txtAnafMonth = new System.Windows.Forms.TextBox();
            this.lblAnaf = new System.Windows.Forms.Label();
            this.lblSeparator3 = new System.Windows.Forms.Label();
            this.lblNetMonth = new System.Windows.Forms.Label();
            this.txtNetMonth = new System.Windows.Forms.TextBox();
            this.txtNetYear = new System.Windows.Forms.TextBox();
            this.lblNetYear = new System.Windows.Forms.Label();
            this.lblCompanyMoney = new System.Windows.Forms.Label();
            this.lblPersonalMoney = new System.Windows.Forms.Label();
            this.lblSeparator2 = new System.Windows.Forms.Label();
            this.txtSpendingsMonthly = new System.Windows.Forms.TextBox();
            this.lblSpendingsMonthly = new System.Windows.Forms.Label();
            this.lblSpendingsYear = new System.Windows.Forms.Label();
            this.lblSpendingsMonth = new System.Windows.Forms.Label();
            this.txtSpendingsYear = new System.Windows.Forms.TextBox();
            this.txtSpendingsMonth = new System.Windows.Forms.TextBox();
            this.lblSpendings = new System.Windows.Forms.Label();
            this.lblGrossAnnuallyEur = new System.Windows.Forms.Label();
            this.txtGrossAnnuallyEur = new System.Windows.Forms.TextBox();
            this.lblGrossMonthlyEur = new System.Windows.Forms.Label();
            this.txtGrossMonthlyEur = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtNetYearEur = new System.Windows.Forms.TextBox();
            this.lblNetYearEur = new System.Windows.Forms.Label();
            this.txtNetMonthEur = new System.Windows.Forms.TextBox();
            this.lblNetMonthEur = new System.Windows.Forms.Label();
            this.lblPercentageHead = new System.Windows.Forms.Label();
            this.lblEurValue = new System.Windows.Forms.Label();
            this.txtEurValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGrossMonthly
            // 
            this.txtGrossMonthly.Location = new System.Drawing.Point(151, 11);
            this.txtGrossMonthly.MaxLength = 5;
            this.txtGrossMonthly.Name = "txtGrossMonthly";
            this.txtGrossMonthly.Size = new System.Drawing.Size(75, 22);
            this.txtGrossMonthly.TabIndex = 0;
            this.txtGrossMonthly.Text = "0";
            this.txtGrossMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrossMonthly.TextChanged += new System.EventHandler(this.txtGrossMonthly_TextChanged);
            this.txtGrossMonthly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyAllowNumbers);
            // 
            // lblGrossMonthly
            // 
            this.lblGrossMonthly.AutoSize = true;
            this.lblGrossMonthly.Location = new System.Drawing.Point(33, 14);
            this.lblGrossMonthly.Name = "lblGrossMonthly";
            this.lblGrossMonthly.Size = new System.Drawing.Size(112, 17);
            this.lblGrossMonthly.TabIndex = 1;
            this.lblGrossMonthly.Text = "Brut / luna RON:";
            // 
            // lblAccountantMonthly
            // 
            this.lblAccountantMonthly.AutoSize = true;
            this.lblAccountantMonthly.Location = new System.Drawing.Point(33, 70);
            this.lblAccountantMonthly.Name = "lblAccountantMonthly";
            this.lblAccountantMonthly.Size = new System.Drawing.Size(102, 17);
            this.lblAccountantMonthly.TabIndex = 3;
            this.lblAccountantMonthly.Text = "Contabil / luna:";
            // 
            // txtAccountantMonthly
            // 
            this.txtAccountantMonthly.Location = new System.Drawing.Point(151, 67);
            this.txtAccountantMonthly.MaxLength = 5;
            this.txtAccountantMonthly.Name = "txtAccountantMonthly";
            this.txtAccountantMonthly.Size = new System.Drawing.Size(75, 22);
            this.txtAccountantMonthly.TabIndex = 2;
            this.txtAccountantMonthly.Text = "150";
            this.txtAccountantMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountantMonthly.TextChanged += new System.EventHandler(this.txtAccountantMonthly_TextChanged);
            this.txtAccountantMonthly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyAllowNumbers);
            // 
            // lblGrossAnnually
            // 
            this.lblGrossAnnually.AutoSize = true;
            this.lblGrossAnnually.Location = new System.Drawing.Point(268, 14);
            this.lblGrossAnnually.Name = "lblGrossAnnually";
            this.lblGrossAnnually.Size = new System.Drawing.Size(101, 17);
            this.lblGrossAnnually.TabIndex = 5;
            this.lblGrossAnnually.Text = "Brut / an RON:";
            // 
            // txtGrossAnnually
            // 
            this.txtGrossAnnually.Location = new System.Drawing.Point(375, 11);
            this.txtGrossAnnually.Name = "txtGrossAnnually";
            this.txtGrossAnnually.ReadOnly = true;
            this.txtGrossAnnually.Size = new System.Drawing.Size(75, 22);
            this.txtGrossAnnually.TabIndex = 4;
            this.txtGrossAnnually.Text = "0";
            this.txtGrossAnnually.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrossAnnually.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyAllowNumbers);
            // 
            // lblAnafAnnually
            // 
            this.lblAnafAnnually.AutoSize = true;
            this.lblAnafAnnually.Location = new System.Drawing.Point(268, 67);
            this.lblAnafAnnually.Name = "lblAnafAnnually";
            this.lblAnafAnnually.Size = new System.Drawing.Size(76, 17);
            this.lblAnafAnnually.TabIndex = 11;
            this.lblAnafAnnually.Text = "ANAF / an:";
            // 
            // txtAnafAnnually
            // 
            this.txtAnafAnnually.Location = new System.Drawing.Point(375, 67);
            this.txtAnafAnnually.MaxLength = 5;
            this.txtAnafAnnually.Name = "txtAnafAnnually";
            this.txtAnafAnnually.Size = new System.Drawing.Size(75, 22);
            this.txtAnafAnnually.TabIndex = 10;
            this.txtAnafAnnually.Text = "3060";
            this.txtAnafAnnually.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnafAnnually.TextChanged += new System.EventHandler(this.txtAnafAnnually_TextChanged);
            this.txtAnafAnnually.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyAllowNumbers);
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator1.Location = new System.Drawing.Point(16, 138);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(454, 2);
            this.lblSeparator1.TabIndex = 12;
            // 
            // lbl3Percent
            // 
            this.lbl3Percent.AutoSize = true;
            this.lbl3Percent.Location = new System.Drawing.Point(13, 158);
            this.lbl3Percent.Name = "lbl3Percent";
            this.lbl3Percent.Size = new System.Drawing.Size(203, 17);
            this.lbl3Percent.TabIndex = 13;
            this.lbl3Percent.Text = "- 3% impozit pe suma facturata";
            // 
            // txt3PercentMonth
            // 
            this.txt3PercentMonth.Location = new System.Drawing.Point(223, 155);
            this.txt3PercentMonth.Name = "txt3PercentMonth";
            this.txt3PercentMonth.ReadOnly = true;
            this.txt3PercentMonth.Size = new System.Drawing.Size(75, 22);
            this.txt3PercentMonth.TabIndex = 14;
            this.txt3PercentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3PercentYear
            // 
            this.txt3PercentYear.Location = new System.Drawing.Point(354, 155);
            this.txt3PercentYear.Name = "txt3PercentYear";
            this.txt3PercentYear.ReadOnly = true;
            this.txt3PercentYear.Size = new System.Drawing.Size(75, 22);
            this.txt3PercentYear.TabIndex = 15;
            this.txt3PercentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl3PercentMonth
            // 
            this.lbl3PercentMonth.AutoSize = true;
            this.lbl3PercentMonth.Location = new System.Drawing.Point(304, 158);
            this.lbl3PercentMonth.Name = "lbl3PercentMonth";
            this.lbl3PercentMonth.Size = new System.Drawing.Size(43, 17);
            this.lbl3PercentMonth.TabIndex = 16;
            this.lbl3PercentMonth.Text = "/ luna";
            // 
            // lbl3PercentYear
            // 
            this.lbl3PercentYear.AutoSize = true;
            this.lbl3PercentYear.Location = new System.Drawing.Point(435, 158);
            this.lbl3PercentYear.Name = "lbl3PercentYear";
            this.lbl3PercentYear.Size = new System.Drawing.Size(32, 17);
            this.lbl3PercentYear.TabIndex = 17;
            this.lbl3PercentYear.Text = "/ an";
            // 
            // lblAccountantYear
            // 
            this.lblAccountantYear.AutoSize = true;
            this.lblAccountantYear.Location = new System.Drawing.Point(435, 186);
            this.lblAccountantYear.Name = "lblAccountantYear";
            this.lblAccountantYear.Size = new System.Drawing.Size(32, 17);
            this.lblAccountantYear.TabIndex = 22;
            this.lblAccountantYear.Text = "/ an";
            // 
            // lblAccountantMonth
            // 
            this.lblAccountantMonth.AutoSize = true;
            this.lblAccountantMonth.Location = new System.Drawing.Point(304, 186);
            this.lblAccountantMonth.Name = "lblAccountantMonth";
            this.lblAccountantMonth.Size = new System.Drawing.Size(43, 17);
            this.lblAccountantMonth.TabIndex = 21;
            this.lblAccountantMonth.Text = "/ luna";
            // 
            // txtAccountantYear
            // 
            this.txtAccountantYear.Location = new System.Drawing.Point(354, 183);
            this.txtAccountantYear.Name = "txtAccountantYear";
            this.txtAccountantYear.ReadOnly = true;
            this.txtAccountantYear.Size = new System.Drawing.Size(75, 22);
            this.txtAccountantYear.TabIndex = 20;
            this.txtAccountantYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccountantMonth
            // 
            this.txtAccountantMonth.Location = new System.Drawing.Point(223, 183);
            this.txtAccountantMonth.Name = "txtAccountantMonth";
            this.txtAccountantMonth.ReadOnly = true;
            this.txtAccountantMonth.Size = new System.Drawing.Size(75, 22);
            this.txtAccountantMonth.TabIndex = 19;
            this.txtAccountantMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAccountant
            // 
            this.lblAccountant.AutoSize = true;
            this.lblAccountant.Location = new System.Drawing.Point(13, 184);
            this.lblAccountant.Name = "lblAccountant";
            this.lblAccountant.Size = new System.Drawing.Size(66, 17);
            this.lblAccountant.TabIndex = 18;
            this.lblAccountant.Text = "- contabil";
            // 
            // lbl5PercentYear
            // 
            this.lbl5PercentYear.AutoSize = true;
            this.lbl5PercentYear.Location = new System.Drawing.Point(435, 242);
            this.lbl5PercentYear.Name = "lbl5PercentYear";
            this.lbl5PercentYear.Size = new System.Drawing.Size(32, 17);
            this.lbl5PercentYear.TabIndex = 27;
            this.lbl5PercentYear.Text = "/ an";
            // 
            // lbl5PercentMonth
            // 
            this.lbl5PercentMonth.AutoSize = true;
            this.lbl5PercentMonth.Location = new System.Drawing.Point(304, 242);
            this.lbl5PercentMonth.Name = "lbl5PercentMonth";
            this.lbl5PercentMonth.Size = new System.Drawing.Size(43, 17);
            this.lbl5PercentMonth.TabIndex = 26;
            this.lbl5PercentMonth.Text = "/ luna";
            // 
            // txt5PercentYear
            // 
            this.txt5PercentYear.Location = new System.Drawing.Point(354, 239);
            this.txt5PercentYear.Name = "txt5PercentYear";
            this.txt5PercentYear.ReadOnly = true;
            this.txt5PercentYear.Size = new System.Drawing.Size(75, 22);
            this.txt5PercentYear.TabIndex = 25;
            this.txt5PercentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt5PercentMonth
            // 
            this.txt5PercentMonth.Location = new System.Drawing.Point(223, 239);
            this.txt5PercentMonth.Name = "txt5PercentMonth";
            this.txt5PercentMonth.ReadOnly = true;
            this.txt5PercentMonth.Size = new System.Drawing.Size(75, 22);
            this.txt5PercentMonth.TabIndex = 24;
            this.txt5PercentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl5Percent
            // 
            this.lbl5Percent.AutoSize = true;
            this.lbl5Percent.Location = new System.Drawing.Point(14, 242);
            this.lbl5Percent.Name = "lbl5Percent";
            this.lbl5Percent.Size = new System.Drawing.Size(152, 17);
            this.lbl5Percent.TabIndex = 23;
            this.lbl5Percent.Text = "- 5% taxe pe dividende";
            // 
            // lblAnafYear
            // 
            this.lblAnafYear.AutoSize = true;
            this.lblAnafYear.Location = new System.Drawing.Point(435, 298);
            this.lblAnafYear.Name = "lblAnafYear";
            this.lblAnafYear.Size = new System.Drawing.Size(32, 17);
            this.lblAnafYear.TabIndex = 36;
            this.lblAnafYear.Text = "/ an";
            // 
            // lblAnafMonth
            // 
            this.lblAnafMonth.AutoSize = true;
            this.lblAnafMonth.Location = new System.Drawing.Point(304, 298);
            this.lblAnafMonth.Name = "lblAnafMonth";
            this.lblAnafMonth.Size = new System.Drawing.Size(43, 17);
            this.lblAnafMonth.TabIndex = 35;
            this.lblAnafMonth.Text = "/ luna";
            // 
            // txtAnafYear
            // 
            this.txtAnafYear.Location = new System.Drawing.Point(354, 295);
            this.txtAnafYear.Name = "txtAnafYear";
            this.txtAnafYear.ReadOnly = true;
            this.txtAnafYear.Size = new System.Drawing.Size(75, 22);
            this.txtAnafYear.TabIndex = 34;
            this.txtAnafYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnafMonth
            // 
            this.txtAnafMonth.Location = new System.Drawing.Point(223, 295);
            this.txtAnafMonth.Name = "txtAnafMonth";
            this.txtAnafMonth.ReadOnly = true;
            this.txtAnafMonth.Size = new System.Drawing.Size(75, 22);
            this.txtAnafMonth.TabIndex = 33;
            this.txtAnafMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnaf
            // 
            this.lblAnaf.AutoSize = true;
            this.lblAnaf.Location = new System.Drawing.Point(14, 298);
            this.lblAnaf.Name = "lblAnaf";
            this.lblAnaf.Size = new System.Drawing.Size(53, 17);
            this.lblAnaf.TabIndex = 32;
            this.lblAnaf.Text = "- ANAF";
            // 
            // lblSeparator3
            // 
            this.lblSeparator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator3.Location = new System.Drawing.Point(13, 328);
            this.lblSeparator3.Name = "lblSeparator3";
            this.lblSeparator3.Size = new System.Drawing.Size(454, 2);
            this.lblSeparator3.TabIndex = 37;
            // 
            // lblNetMonth
            // 
            this.lblNetMonth.AutoSize = true;
            this.lblNetMonth.Location = new System.Drawing.Point(17, 346);
            this.lblNetMonth.Name = "lblNetMonth";
            this.lblNetMonth.Size = new System.Drawing.Size(108, 17);
            this.lblNetMonth.TabIndex = 38;
            this.lblNetMonth.Text = "Net / luna RON:";
            // 
            // txtNetMonth
            // 
            this.txtNetMonth.Location = new System.Drawing.Point(131, 343);
            this.txtNetMonth.Name = "txtNetMonth";
            this.txtNetMonth.ReadOnly = true;
            this.txtNetMonth.Size = new System.Drawing.Size(75, 22);
            this.txtNetMonth.TabIndex = 39;
            this.txtNetMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNetYear
            // 
            this.txtNetYear.Location = new System.Drawing.Point(323, 343);
            this.txtNetYear.Name = "txtNetYear";
            this.txtNetYear.ReadOnly = true;
            this.txtNetYear.Size = new System.Drawing.Size(75, 22);
            this.txtNetYear.TabIndex = 41;
            this.txtNetYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNetYear
            // 
            this.lblNetYear.AutoSize = true;
            this.lblNetYear.Location = new System.Drawing.Point(220, 346);
            this.lblNetYear.Name = "lblNetYear";
            this.lblNetYear.Size = new System.Drawing.Size(97, 17);
            this.lblNetYear.TabIndex = 40;
            this.lblNetYear.Text = "Net / an RON:";
            // 
            // lblCompanyMoney
            // 
            this.lblCompanyMoney.AutoSize = true;
            this.lblCompanyMoney.Location = new System.Drawing.Point(13, 128);
            this.lblCompanyMoney.Name = "lblCompanyMoney";
            this.lblCompanyMoney.Size = new System.Drawing.Size(77, 17);
            this.lblCompanyMoney.TabIndex = 43;
            this.lblCompanyMoney.Text = "Banii firmei";
            // 
            // lblPersonalMoney
            // 
            this.lblPersonalMoney.AutoSize = true;
            this.lblPersonalMoney.Location = new System.Drawing.Point(13, 271);
            this.lblPersonalMoney.Name = "lblPersonalMoney";
            this.lblPersonalMoney.Size = new System.Drawing.Size(98, 17);
            this.lblPersonalMoney.TabIndex = 45;
            this.lblPersonalMoney.Text = "Bani personali";
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator2.Location = new System.Drawing.Point(16, 281);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(454, 2);
            this.lblSeparator2.TabIndex = 44;
            // 
            // txtSpendingsMonthly
            // 
            this.txtSpendingsMonthly.Location = new System.Drawing.Point(151, 95);
            this.txtSpendingsMonthly.MaxLength = 5;
            this.txtSpendingsMonthly.Name = "txtSpendingsMonthly";
            this.txtSpendingsMonthly.Size = new System.Drawing.Size(75, 22);
            this.txtSpendingsMonthly.TabIndex = 46;
            this.txtSpendingsMonthly.Text = "0";
            this.txtSpendingsMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpendingsMonthly.TextChanged += new System.EventHandler(this.txtSpendingsMonthly_TextChanged);
            this.txtSpendingsMonthly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyAllowNumbers);
            // 
            // lblSpendingsMonthly
            // 
            this.lblSpendingsMonthly.AutoSize = true;
            this.lblSpendingsMonthly.Location = new System.Drawing.Point(33, 98);
            this.lblSpendingsMonthly.Name = "lblSpendingsMonthly";
            this.lblSpendingsMonthly.Size = new System.Drawing.Size(108, 17);
            this.lblSpendingsMonthly.TabIndex = 47;
            this.lblSpendingsMonthly.Text = "Cheltuieli / luna:";
            // 
            // lblSpendingsYear
            // 
            this.lblSpendingsYear.AutoSize = true;
            this.lblSpendingsYear.Location = new System.Drawing.Point(435, 214);
            this.lblSpendingsYear.Name = "lblSpendingsYear";
            this.lblSpendingsYear.Size = new System.Drawing.Size(32, 17);
            this.lblSpendingsYear.TabIndex = 52;
            this.lblSpendingsYear.Text = "/ an";
            // 
            // lblSpendingsMonth
            // 
            this.lblSpendingsMonth.AutoSize = true;
            this.lblSpendingsMonth.Location = new System.Drawing.Point(304, 214);
            this.lblSpendingsMonth.Name = "lblSpendingsMonth";
            this.lblSpendingsMonth.Size = new System.Drawing.Size(43, 17);
            this.lblSpendingsMonth.TabIndex = 51;
            this.lblSpendingsMonth.Text = "/ luna";
            // 
            // txtSpendingsYear
            // 
            this.txtSpendingsYear.Location = new System.Drawing.Point(354, 211);
            this.txtSpendingsYear.Name = "txtSpendingsYear";
            this.txtSpendingsYear.ReadOnly = true;
            this.txtSpendingsYear.Size = new System.Drawing.Size(75, 22);
            this.txtSpendingsYear.TabIndex = 50;
            this.txtSpendingsYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpendingsMonth
            // 
            this.txtSpendingsMonth.Location = new System.Drawing.Point(223, 211);
            this.txtSpendingsMonth.Name = "txtSpendingsMonth";
            this.txtSpendingsMonth.ReadOnly = true;
            this.txtSpendingsMonth.Size = new System.Drawing.Size(75, 22);
            this.txtSpendingsMonth.TabIndex = 49;
            this.txtSpendingsMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSpendings
            // 
            this.lblSpendings.AutoSize = true;
            this.lblSpendings.Location = new System.Drawing.Point(14, 214);
            this.lblSpendings.Name = "lblSpendings";
            this.lblSpendings.Size = new System.Drawing.Size(72, 17);
            this.lblSpendings.TabIndex = 48;
            this.lblSpendings.Text = "- cheltuieli";
            // 
            // lblGrossAnnuallyEur
            // 
            this.lblGrossAnnuallyEur.AutoSize = true;
            this.lblGrossAnnuallyEur.Location = new System.Drawing.Point(268, 42);
            this.lblGrossAnnuallyEur.Name = "lblGrossAnnuallyEur";
            this.lblGrossAnnuallyEur.Size = new System.Drawing.Size(99, 17);
            this.lblGrossAnnuallyEur.TabIndex = 56;
            this.lblGrossAnnuallyEur.Text = "Brut / an EUR:";
            // 
            // txtGrossAnnuallyEur
            // 
            this.txtGrossAnnuallyEur.Location = new System.Drawing.Point(375, 39);
            this.txtGrossAnnuallyEur.Name = "txtGrossAnnuallyEur";
            this.txtGrossAnnuallyEur.ReadOnly = true;
            this.txtGrossAnnuallyEur.Size = new System.Drawing.Size(75, 22);
            this.txtGrossAnnuallyEur.TabIndex = 55;
            this.txtGrossAnnuallyEur.Text = "0";
            this.txtGrossAnnuallyEur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrossMonthlyEur
            // 
            this.lblGrossMonthlyEur.AutoSize = true;
            this.lblGrossMonthlyEur.Location = new System.Drawing.Point(33, 43);
            this.lblGrossMonthlyEur.Name = "lblGrossMonthlyEur";
            this.lblGrossMonthlyEur.Size = new System.Drawing.Size(110, 17);
            this.lblGrossMonthlyEur.TabIndex = 54;
            this.lblGrossMonthlyEur.Text = "Brut / luna EUR:";
            // 
            // txtGrossMonthlyEur
            // 
            this.txtGrossMonthlyEur.Location = new System.Drawing.Point(151, 39);
            this.txtGrossMonthlyEur.Name = "txtGrossMonthlyEur";
            this.txtGrossMonthlyEur.ReadOnly = true;
            this.txtGrossMonthlyEur.Size = new System.Drawing.Size(75, 22);
            this.txtGrossMonthlyEur.TabIndex = 53;
            this.txtGrossMonthlyEur.Text = "0";
            this.txtGrossMonthlyEur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Location = new System.Drawing.Point(411, 374);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(56, 17);
            this.lblPercentage.TabIndex = 42;
            this.lblPercentage.Text = "? %";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNetYearEur
            // 
            this.txtNetYearEur.Location = new System.Drawing.Point(323, 371);
            this.txtNetYearEur.Name = "txtNetYearEur";
            this.txtNetYearEur.ReadOnly = true;
            this.txtNetYearEur.Size = new System.Drawing.Size(75, 22);
            this.txtNetYearEur.TabIndex = 60;
            this.txtNetYearEur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNetYearEur
            // 
            this.lblNetYearEur.AutoSize = true;
            this.lblNetYearEur.Location = new System.Drawing.Point(220, 374);
            this.lblNetYearEur.Name = "lblNetYearEur";
            this.lblNetYearEur.Size = new System.Drawing.Size(95, 17);
            this.lblNetYearEur.TabIndex = 59;
            this.lblNetYearEur.Text = "Net / an EUR:";
            // 
            // txtNetMonthEur
            // 
            this.txtNetMonthEur.Location = new System.Drawing.Point(131, 371);
            this.txtNetMonthEur.Name = "txtNetMonthEur";
            this.txtNetMonthEur.ReadOnly = true;
            this.txtNetMonthEur.Size = new System.Drawing.Size(75, 22);
            this.txtNetMonthEur.TabIndex = 58;
            this.txtNetMonthEur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNetMonthEur
            // 
            this.lblNetMonthEur.AutoSize = true;
            this.lblNetMonthEur.Location = new System.Drawing.Point(17, 374);
            this.lblNetMonthEur.Name = "lblNetMonthEur";
            this.lblNetMonthEur.Size = new System.Drawing.Size(106, 17);
            this.lblNetMonthEur.TabIndex = 57;
            this.lblNetMonthEur.Text = "Net / luna EUR:";
            // 
            // lblPercentageHead
            // 
            this.lblPercentageHead.AutoSize = true;
            this.lblPercentageHead.Location = new System.Drawing.Point(408, 346);
            this.lblPercentageHead.Name = "lblPercentageHead";
            this.lblPercentageHead.Size = new System.Drawing.Size(62, 17);
            this.lblPercentageHead.TabIndex = 61;
            this.lblPercentageHead.Text = "Din brut:";
            // 
            // lblEurValue
            // 
            this.lblEurValue.AutoSize = true;
            this.lblEurValue.Location = new System.Drawing.Point(268, 95);
            this.lblEurValue.Name = "lblEurValue";
            this.lblEurValue.Size = new System.Drawing.Size(81, 17);
            this.lblEurValue.TabIndex = 63;
            this.lblEurValue.Text = "EUR / RON:";
            // 
            // txtEurValue
            // 
            this.txtEurValue.Location = new System.Drawing.Point(375, 95);
            this.txtEurValue.MaxLength = 5;
            this.txtEurValue.Name = "txtEurValue";
            this.txtEurValue.Size = new System.Drawing.Size(75, 22);
            this.txtEurValue.TabIndex = 62;
            this.txtEurValue.Text = "5";
            this.txtEurValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEurValue.TextChanged += new System.EventHandler(this.txtEurValue_TextChanged);
            this.txtEurValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyAllowNumbers);
            // 
            // frmRoSrlSalaryTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.lblEurValue);
            this.Controls.Add(this.txtEurValue);
            this.Controls.Add(this.lblPercentageHead);
            this.Controls.Add(this.txtNetYearEur);
            this.Controls.Add(this.lblNetYearEur);
            this.Controls.Add(this.txtNetMonthEur);
            this.Controls.Add(this.lblNetMonthEur);
            this.Controls.Add(this.lblGrossAnnuallyEur);
            this.Controls.Add(this.txtGrossAnnuallyEur);
            this.Controls.Add(this.lblGrossMonthlyEur);
            this.Controls.Add(this.txtGrossMonthlyEur);
            this.Controls.Add(this.lblSpendingsYear);
            this.Controls.Add(this.lblSpendingsMonth);
            this.Controls.Add(this.txtSpendingsYear);
            this.Controls.Add(this.txtSpendingsMonth);
            this.Controls.Add(this.lblSpendings);
            this.Controls.Add(this.lblSpendingsMonthly);
            this.Controls.Add(this.txtSpendingsMonthly);
            this.Controls.Add(this.lblPersonalMoney);
            this.Controls.Add(this.lblSeparator2);
            this.Controls.Add(this.lblCompanyMoney);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtNetYear);
            this.Controls.Add(this.lblNetYear);
            this.Controls.Add(this.txtNetMonth);
            this.Controls.Add(this.lblNetMonth);
            this.Controls.Add(this.lblSeparator3);
            this.Controls.Add(this.lblAnafYear);
            this.Controls.Add(this.lblAnafMonth);
            this.Controls.Add(this.txtAnafYear);
            this.Controls.Add(this.txtAnafMonth);
            this.Controls.Add(this.lblAnaf);
            this.Controls.Add(this.lbl5PercentYear);
            this.Controls.Add(this.lbl5PercentMonth);
            this.Controls.Add(this.txt5PercentYear);
            this.Controls.Add(this.txt5PercentMonth);
            this.Controls.Add(this.lbl5Percent);
            this.Controls.Add(this.lblAccountantYear);
            this.Controls.Add(this.lblAccountantMonth);
            this.Controls.Add(this.txtAccountantYear);
            this.Controls.Add(this.txtAccountantMonth);
            this.Controls.Add(this.lblAccountant);
            this.Controls.Add(this.lbl3PercentYear);
            this.Controls.Add(this.lbl3PercentMonth);
            this.Controls.Add(this.txt3PercentYear);
            this.Controls.Add(this.txt3PercentMonth);
            this.Controls.Add(this.lbl3Percent);
            this.Controls.Add(this.lblSeparator1);
            this.Controls.Add(this.lblAnafAnnually);
            this.Controls.Add(this.txtAnafAnnually);
            this.Controls.Add(this.lblGrossAnnually);
            this.Controls.Add(this.txtGrossAnnually);
            this.Controls.Add(this.lblAccountantMonthly);
            this.Controls.Add(this.txtAccountantMonthly);
            this.Controls.Add(this.lblGrossMonthly);
            this.Controls.Add(this.txtGrossMonthly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoSrlSalaryTaxCalculator";
            this.Text = "RO SRL Salary Tax Calculator";
            this.Load += new System.EventHandler(this.frmRoSrlSalaryTaxCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrossMonthly;
        private System.Windows.Forms.Label lblGrossMonthly;
        private System.Windows.Forms.Label lblAccountantMonthly;
        private System.Windows.Forms.TextBox txtAccountantMonthly;
        private System.Windows.Forms.Label lblGrossAnnually;
        private System.Windows.Forms.TextBox txtGrossAnnually;
        private System.Windows.Forms.Label lblAnafAnnually;
        private System.Windows.Forms.TextBox txtAnafAnnually;
        private System.Windows.Forms.Label lblSeparator1;
        private System.Windows.Forms.Label lbl3Percent;
        private System.Windows.Forms.TextBox txt3PercentMonth;
        private System.Windows.Forms.TextBox txt3PercentYear;
        private System.Windows.Forms.Label lbl3PercentMonth;
        private System.Windows.Forms.Label lbl3PercentYear;
        private System.Windows.Forms.Label lblAccountantYear;
        private System.Windows.Forms.Label lblAccountantMonth;
        private System.Windows.Forms.TextBox txtAccountantYear;
        private System.Windows.Forms.TextBox txtAccountantMonth;
        private System.Windows.Forms.Label lblAccountant;
        private System.Windows.Forms.Label lbl5PercentYear;
        private System.Windows.Forms.Label lbl5PercentMonth;
        private System.Windows.Forms.TextBox txt5PercentYear;
        private System.Windows.Forms.TextBox txt5PercentMonth;
        private System.Windows.Forms.Label lbl5Percent;
        private System.Windows.Forms.Label lblAnafYear;
        private System.Windows.Forms.Label lblAnafMonth;
        private System.Windows.Forms.TextBox txtAnafYear;
        private System.Windows.Forms.TextBox txtAnafMonth;
        private System.Windows.Forms.Label lblAnaf;
        private System.Windows.Forms.Label lblSeparator3;
        private System.Windows.Forms.Label lblNetMonth;
        private System.Windows.Forms.TextBox txtNetMonth;
        private System.Windows.Forms.TextBox txtNetYear;
        private System.Windows.Forms.Label lblNetYear;
        private System.Windows.Forms.Label lblCompanyMoney;
        private System.Windows.Forms.Label lblPersonalMoney;
        private System.Windows.Forms.Label lblSeparator2;
        private System.Windows.Forms.TextBox txtSpendingsMonthly;
        private System.Windows.Forms.Label lblSpendingsMonthly;
        private System.Windows.Forms.Label lblSpendingsYear;
        private System.Windows.Forms.Label lblSpendingsMonth;
        private System.Windows.Forms.TextBox txtSpendingsYear;
        private System.Windows.Forms.TextBox txtSpendingsMonth;
        private System.Windows.Forms.Label lblSpendings;
        private System.Windows.Forms.Label lblGrossAnnuallyEur;
        private System.Windows.Forms.TextBox txtGrossAnnuallyEur;
        private System.Windows.Forms.Label lblGrossMonthlyEur;
        private System.Windows.Forms.TextBox txtGrossMonthlyEur;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtNetYearEur;
        private System.Windows.Forms.Label lblNetYearEur;
        private System.Windows.Forms.TextBox txtNetMonthEur;
        private System.Windows.Forms.Label lblNetMonthEur;
        private System.Windows.Forms.Label lblPercentageHead;
        private System.Windows.Forms.Label lblEurValue;
        private System.Windows.Forms.TextBox txtEurValue;
    }
}

