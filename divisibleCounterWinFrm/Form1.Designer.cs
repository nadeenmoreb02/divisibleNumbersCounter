namespace divisibleCounterWinFrm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCount = new Button();
            startLbl = new Label();
            label1 = new Label();
            txStartFrom = new TextBox();
            txTo = new TextBox();
            btnExit = new Button();
            label2 = new Label();
            cmbDivisibleTerm = new ComboBox();
            txtDivisibleNumbers = new TextBox();
            groupBox1 = new GroupBox();
            rbGreen = new RadioButton();
            rbBlue = new RadioButton();
            rbRed = new RadioButton();
            rbBlack = new RadioButton();
            chBold = new CheckBox();
            chItalic = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCount
            // 
            btnCount.BackColor = SystemColors.ActiveCaption;
            btnCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCount.Location = new Point(180, 220);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(115, 51);
            btnCount.TabIndex = 0;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // startLbl
            // 
            startLbl.AutoSize = true;
            startLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startLbl.Location = new Point(30, 59);
            startLbl.Name = "startLbl";
            startLbl.Size = new Size(119, 28);
            startLbl.TabIndex = 1;
            startLbl.Text = "Start From ";
            startLbl.Click += startLbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 59);
            label1.Name = "label1";
            label1.Size = new Size(34, 28);
            label1.TabIndex = 2;
            label1.Text = "To";
            label1.Click += label1_Click;
            // 
            // txStartFrom
            // 
            txStartFrom.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txStartFrom.Location = new Point(155, 59);
            txStartFrom.Name = "txStartFrom";
            txStartFrom.Size = new Size(125, 34);
            txStartFrom.TabIndex = 3;
            txStartFrom.TextChanged += txStartFrom_TextChanged;
            txStartFrom.KeyPress += txStartFrom_KeyPress;
            // 
            // txTo
            // 
            txTo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txTo.Location = new Point(394, 59);
            txTo.Name = "txTo";
            txTo.Size = new Size(125, 34);
            txTo.TabIndex = 4;
            txTo.KeyPress += txTo_KeyPress;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.RosyBrown;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(335, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 51);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 121);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 6;
            label2.Text = "Divisible Number";
            label2.Click += label2_Click;
            // 
            // cmbDivisibleTerm
            // 
            cmbDivisibleTerm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDivisibleTerm.FormattingEnabled = true;
            cmbDivisibleTerm.Location = new Point(238, 121);
            cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            cmbDivisibleTerm.Size = new Size(151, 36);
            cmbDivisibleTerm.TabIndex = 7;
            cmbDivisibleTerm.SelectedIndexChanged += cmbDivisibleTerm_SelectedIndexChanged;
            // 
            // txtDivisibleNumbers
            // 
            txtDivisibleNumbers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDivisibleNumbers.Location = new Point(19, 311);
            txtDivisibleNumbers.Multiline = true;
            txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            txtDivisibleNumbers.Size = new Size(769, 131);
            txtDivisibleNumbers.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbGreen);
            groupBox1.Controls.Add(rbBlue);
            groupBox1.Controls.Add(rbRed);
            groupBox1.Controls.Add(rbBlack);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(517, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 193);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Color";
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Location = new Point(28, 135);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(78, 27);
            rbGreen.TabIndex = 3;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbGreen_CheckedChanged;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Location = new Point(28, 102);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(66, 27);
            rbBlue.TabIndex = 2;
            rbBlue.Text = "Blue";
            rbBlue.UseVisualStyleBackColor = true;
            rbBlue.CheckedChanged += rbBlue_CheckedChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(28, 69);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(62, 27);
            rbRed.TabIndex = 1;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Checked = true;
            rbBlack.Location = new Point(28, 36);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(74, 27);
            rbBlack.TabIndex = 0;
            rbBlack.TabStop = true;
            rbBlack.Text = "Black";
            rbBlack.UseVisualStyleBackColor = true;
            rbBlack.CheckedChanged += rbBlack_CheckedChanged;
            // 
            // chBold
            // 
            chBold.AutoSize = true;
            chBold.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chBold.Location = new Point(34, 178);
            chBold.Name = "chBold";
            chBold.Size = new Size(77, 32);
            chBold.TabIndex = 10;
            chBold.Text = "Bold";
            chBold.UseVisualStyleBackColor = true;
            chBold.CheckedChanged += chBold_CheckedChanged;
            // 
            // chItalic
            // 
            chItalic.AutoSize = true;
            chItalic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chItalic.Location = new Point(34, 216);
            chItalic.Name = "chItalic";
            chItalic.Size = new Size(81, 32);
            chItalic.TabIndex = 11;
            chItalic.Text = "Italic";
            chItalic.UseVisualStyleBackColor = true;
            chItalic.CheckedChanged += chItalic_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chItalic);
            Controls.Add(chBold);
            Controls.Add(groupBox1);
            Controls.Add(txtDivisibleNumbers);
            Controls.Add(cmbDivisibleTerm);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(txTo);
            Controls.Add(txStartFrom);
            Controls.Add(label1);
            Controls.Add(startLbl);
            Controls.Add(btnCount);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Counting Numbers";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCount;
        private Label startLbl;
        private Label label1;
        private TextBox txStartFrom;
        private TextBox txTo;
        private Button btnExit;
        private Label label2;
        private ComboBox cmbDivisibleTerm;
        private TextBox txtDivisibleNumbers;
        private GroupBox groupBox1;
        private RadioButton rbGreen;
        private RadioButton rbBlue;
        private RadioButton rbRed;
        private RadioButton rbBlack;
        private CheckBox chBold;
        private CheckBox chItalic;
    }
}