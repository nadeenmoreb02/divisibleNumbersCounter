namespace divisibleCounterWinFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int firstNumber = 0, lastNumber = 0;
        int divisibleTerm = 1;
        int controlNumber = 1;
        private void btnCount_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";
            if (txStartFrom.Text.Trim() == "" || txTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the necessary fields");
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("please select divisible term");
            }
            else
            {
                firstNumber = Convert.ToInt32(txStartFrom.Text);
                lastNumber = Convert.ToInt32(txTo.Text);
                MessageBox.Show("Divisible " + divisibleTerm + " from " + firstNumber + " to " + lastNumber);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                        divisibleNumber += i.ToString() + " ";
                    if (controlNumber % 10 == 0)
                    {
                        divisibleNumber += Environment.NewLine;
                        controlNumber++;
                    }
                }
                txtDivisibleNumbers.Text = divisibleNumber;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("10");
        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem.ToString());
        }

        private void txStartFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbRed.Checked = false;
                rbGreen.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)

            {
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)

            {
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                rbRed.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)

            {
                rbBlack.Checked = false;
                rbRed.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }
    }
}