namespace NICEEvents
{
    partial class NICE_Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NICE_Events));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapLakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.victorMineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gahchoKueProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblEventsCount = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.nudResultDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultDays)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToExcelToolStripMenuItem.Text = "&Export to CSV";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snapLakeToolStripMenuItem,
            this.victorMineToolStripMenuItem,
            this.gahchoKueProjectToolStripMenuItem});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.locationToolStripMenuItem.Text = "&Location";
            // 
            // snapLakeToolStripMenuItem
            // 
            this.snapLakeToolStripMenuItem.Name = "snapLakeToolStripMenuItem";
            this.snapLakeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.snapLakeToolStripMenuItem.Text = "&Snap Lake";
            this.snapLakeToolStripMenuItem.Click += new System.EventHandler(this.snapLakeToolStripMenuItem_Click);
            // 
            // victorMineToolStripMenuItem
            // 
            this.victorMineToolStripMenuItem.Name = "victorMineToolStripMenuItem";
            this.victorMineToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.victorMineToolStripMenuItem.Text = "&Victor Mine";
            this.victorMineToolStripMenuItem.Click += new System.EventHandler(this.victorMineToolStripMenuItem_Click);
            // 
            // gahchoKueProjectToolStripMenuItem
            // 
            this.gahchoKueProjectToolStripMenuItem.Name = "gahchoKueProjectToolStripMenuItem";
            this.gahchoKueProjectToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gahchoKueProjectToolStripMenuItem.Text = "&Gahcho Kue Project";
            this.gahchoKueProjectToolStripMenuItem.Click += new System.EventHandler(this.gahchoKueProjectToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 61);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.Size = new System.Drawing.Size(1160, 589);
            this.DGV1.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(12, 41);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(120, 19);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "None Selected";
            // 
            // btnGO
            // 
            this.btnGO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(148, 35);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 3;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lblEventsCount
            // 
            this.lblEventsCount.AutoSize = true;
            this.lblEventsCount.Location = new System.Drawing.Point(244, 45);
            this.lblEventsCount.Name = "lblEventsCount";
            this.lblEventsCount.Size = new System.Drawing.Size(43, 13);
            this.lblEventsCount.TabIndex = 4;
            this.lblEventsCount.Text = "000000";
            this.lblEventsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(293, 45);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(40, 13);
            this.lblEvents.TabIndex = 5;
            this.lblEvents.Text = "Events";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(368, 45);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(37, 13);
            this.lblPending.TabIndex = 6;
            this.lblPending.Text = "          ";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudResultDays
            // 
            this.nudResultDays.Location = new System.Drawing.Point(371, 38);
            this.nudResultDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudResultDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResultDays.Name = "nudResultDays";
            this.nudResultDays.Size = new System.Drawing.Size(44, 20);
            this.nudResultDays.TabIndex = 7;
            this.nudResultDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days";
            // 
            // NICE_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudResultDays);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblEventsCount);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NICE_Events";
            this.Text = "NICE - Events (One Month)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapLakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem victorMineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gahchoKueProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblEventsCount;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.NumericUpDown nudResultDays;
        private System.Windows.Forms.Label label1;
    }
}

