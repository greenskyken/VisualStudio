namespace LenelTA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoadRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboLocationSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboAreaSelect = new System.Windows.Forms.ComboBox();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboPersonnelSelection = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoOneDaySelect = new System.Windows.Forms.RadioButton();
            this.rdoOneWeekSelect = new System.Windows.Forms.RadioButton();
            this.rdoOneMonthSelect = new System.Windows.Forms.RadioButton();
            this.rdoDateSelect = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadRecords
            // 
            this.btnLoadRecords.Location = new System.Drawing.Point(55, 51);
            this.btnLoadRecords.Name = "btnLoadRecords";
            this.btnLoadRecords.Size = new System.Drawing.Size(200, 20);
            this.btnLoadRecords.TabIndex = 0;
            this.btnLoadRecords.Text = "Load Records";
            this.btnLoadRecords.UseVisualStyleBackColor = true;
            this.btnLoadRecords.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Step One - Load Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step Two - Select Location";
            // 
            // cmboLocationSelect
            // 
            this.cmboLocationSelect.FormattingEnabled = true;
            this.cmboLocationSelect.Location = new System.Drawing.Point(55, 103);
            this.cmboLocationSelect.Name = "cmboLocationSelect";
            this.cmboLocationSelect.Size = new System.Drawing.Size(200, 21);
            this.cmboLocationSelect.TabIndex = 1;
            this.cmboLocationSelect.SelectedIndexChanged += new System.EventHandler(this.cmboLocationSelect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Step 3 - Select Area";
            // 
            // cmboAreaSelect
            // 
            this.cmboAreaSelect.FormattingEnabled = true;
            this.cmboAreaSelect.Location = new System.Drawing.Point(55, 156);
            this.cmboAreaSelect.Name = "cmboAreaSelect";
            this.cmboAreaSelect.Size = new System.Drawing.Size(200, 21);
            this.cmboAreaSelect.TabIndex = 2;
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(55, 263);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateStartDate.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Start";
            // 
            // dateEndDate
            // 
            this.dateEndDate.Location = new System.Drawing.Point(55, 300);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateEndDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "End";
            // 
            // cmboPersonnelSelection
            // 
            this.cmboPersonnelSelection.FormattingEnabled = true;
            this.cmboPersonnelSelection.Location = new System.Drawing.Point(55, 209);
            this.cmboPersonnelSelection.Name = "cmboPersonnelSelection";
            this.cmboPersonnelSelection.Size = new System.Drawing.Size(200, 21);
            this.cmboPersonnelSelection.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Step 4 - Personnel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Step 5 - Personnel";
            // 
            // rdoOneDaySelect
            // 
            this.rdoOneDaySelect.AutoSize = true;
            this.rdoOneDaySelect.Location = new System.Drawing.Point(55, 338);
            this.rdoOneDaySelect.Name = "rdoOneDaySelect";
            this.rdoOneDaySelect.Size = new System.Drawing.Size(67, 17);
            this.rdoOneDaySelect.TabIndex = 6;
            this.rdoOneDaySelect.Text = "One Day";
            this.rdoOneDaySelect.UseVisualStyleBackColor = true;
            this.rdoOneDaySelect.CheckedChanged += new System.EventHandler(this.rdoOneDaySelect_CheckedChanged);
            // 
            // rdoOneWeekSelect
            // 
            this.rdoOneWeekSelect.AutoSize = true;
            this.rdoOneWeekSelect.Location = new System.Drawing.Point(136, 338);
            this.rdoOneWeekSelect.Name = "rdoOneWeekSelect";
            this.rdoOneWeekSelect.Size = new System.Drawing.Size(77, 17);
            this.rdoOneWeekSelect.TabIndex = 7;
            this.rdoOneWeekSelect.Text = "One Week";
            this.rdoOneWeekSelect.UseVisualStyleBackColor = true;
            this.rdoOneWeekSelect.CheckedChanged += new System.EventHandler(this.rdoOneWeekSelect_CheckedChanged);
            // 
            // rdoOneMonthSelect
            // 
            this.rdoOneMonthSelect.AutoSize = true;
            this.rdoOneMonthSelect.Location = new System.Drawing.Point(227, 338);
            this.rdoOneMonthSelect.Name = "rdoOneMonthSelect";
            this.rdoOneMonthSelect.Size = new System.Drawing.Size(78, 17);
            this.rdoOneMonthSelect.TabIndex = 8;
            this.rdoOneMonthSelect.Text = "One Month";
            this.rdoOneMonthSelect.UseVisualStyleBackColor = true;
            this.rdoOneMonthSelect.CheckedChanged += new System.EventHandler(this.rdoOneMonthSelect_CheckedChanged);
            // 
            // rdoDateSelect
            // 
            this.rdoDateSelect.AutoSize = true;
            this.rdoDateSelect.Checked = true;
            this.rdoDateSelect.Location = new System.Drawing.Point(319, 338);
            this.rdoDateSelect.Name = "rdoDateSelect";
            this.rdoDateSelect.Size = new System.Drawing.Size(81, 17);
            this.rdoDateSelect.TabIndex = 9;
            this.rdoDateSelect.TabStop = true;
            this.rdoDateSelect.Text = "Select Date";
            this.rdoDateSelect.UseVisualStyleBackColor = true;
            this.rdoDateSelect.CheckedChanged += new System.EventHandler(this.rdoDateSelect_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoDateSelect);
            this.Controls.Add(this.rdoOneMonthSelect);
            this.Controls.Add(this.rdoOneWeekSelect);
            this.Controls.Add(this.rdoOneDaySelect);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmboPersonnelSelection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.cmboAreaSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmboLocationSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lenel - Time and Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboLocationSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboAreaSelect;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboPersonnelSelection;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoOneDaySelect;
        private System.Windows.Forms.RadioButton rdoOneWeekSelect;
        private System.Windows.Forms.RadioButton rdoOneMonthSelect;
        private System.Windows.Forms.RadioButton rdoDateSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

