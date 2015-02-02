namespace _05_BusinessReportApplication
{
    partial class BusinessReport
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
            this.importDataBtn = new System.Windows.Forms.Button();
            this.exportToWordBtn = new System.Windows.Forms.Button();
            this.exportToDropboxBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.reportsLable = new System.Windows.Forms.Label();
            this.reportDetails = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // importDataBtn
            // 
            this.importDataBtn.Location = new System.Drawing.Point(14, 12);
            this.importDataBtn.Name = "importDataBtn";
            this.importDataBtn.Size = new System.Drawing.Size(158, 40);
            this.importDataBtn.TabIndex = 0;
            this.importDataBtn.Text = "Import Data";
            this.importDataBtn.UseVisualStyleBackColor = true;
            this.importDataBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportToWordBtn
            // 
            this.exportToWordBtn.Location = new System.Drawing.Point(178, 12);
            this.exportToWordBtn.Name = "exportToWordBtn";
            this.exportToWordBtn.Size = new System.Drawing.Size(158, 40);
            this.exportToWordBtn.TabIndex = 1;
            this.exportToWordBtn.Text = "Export to Word";
            this.exportToWordBtn.UseVisualStyleBackColor = true;
            // 
            // exportToDropboxBtn
            // 
            this.exportToDropboxBtn.Location = new System.Drawing.Point(343, 12);
            this.exportToDropboxBtn.Name = "exportToDropboxBtn";
            this.exportToDropboxBtn.Size = new System.Drawing.Size(158, 40);
            this.exportToDropboxBtn.TabIndex = 2;
            this.exportToDropboxBtn.Text = "Export to Dropbox";
            this.exportToDropboxBtn.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(507, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(158, 40);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(14, 97);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 344);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // reportsLable
            // 
            this.reportsLable.AutoSize = true;
            this.reportsLable.Location = new System.Drawing.Point(12, 72);
            this.reportsLable.Name = "reportsLable";
            this.reportsLable.Size = new System.Drawing.Size(70, 17);
            this.reportsLable.TabIndex = 5;
            this.reportsLable.Text = "Reports:";
            // 
            // reportDetails
            // 
            this.reportDetails.AutoSize = true;
            this.reportDetails.Location = new System.Drawing.Point(231, 72);
            this.reportDetails.Name = "reportDetails";
            this.reportDetails.Size = new System.Drawing.Size(117, 17);
            this.reportDetails.TabIndex = 6;
            this.reportDetails.Text = "Report Details:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(234, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(634, 344);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // BusinessReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 453);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.reportDetails);
            this.Controls.Add(this.reportsLable);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.exportToDropboxBtn);
            this.Controls.Add(this.exportToWordBtn);
            this.Controls.Add(this.importDataBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BusinessReport";
            this.Text = "Business Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importDataBtn;
        private System.Windows.Forms.Button exportToWordBtn;
        private System.Windows.Forms.Button exportToDropboxBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label reportsLable;
        private System.Windows.Forms.Label reportDetails;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

