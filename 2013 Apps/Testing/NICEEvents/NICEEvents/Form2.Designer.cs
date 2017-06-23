namespace NICEEvents
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.btnForm2Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(12, 12);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(732, 183);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = resources.GetString("rtbInfo.Text");
            // 
            // btnForm2Close
            // 
            this.btnForm2Close.Location = new System.Drawing.Point(669, 203);
            this.btnForm2Close.Name = "btnForm2Close";
            this.btnForm2Close.Size = new System.Drawing.Size(75, 23);
            this.btnForm2Close.TabIndex = 1;
            this.btnForm2Close.Text = "Close";
            this.btnForm2Close.UseVisualStyleBackColor = true;
            this.btnForm2Close.Click += new System.EventHandler(this.btnForm2Close_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 238);
            this.Controls.Add(this.btnForm2Close);
            this.Controls.Add(this.rtbInfo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoForm";
            this.Text = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button btnForm2Close;
    }
}