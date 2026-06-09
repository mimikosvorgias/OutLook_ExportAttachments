namespace MaltProjectHelper
{
    partial class main
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
            this.dataGridView_ExportList = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.button_ReadOutLookFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Export = new System.Windows.Forms.Button();
            this.progressBar_Main = new System.Windows.Forms.ProgressBar();
            this.textBox_Export_Attachment_Path = new System.Windows.Forms.TextBox();
            this.textBox_OutLookFilePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog_SaveAttachments = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExportList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ExportList
            // 
            this.dataGridView_ExportList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ExportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExportList.Location = new System.Drawing.Point(21, 192);
            this.dataGridView_ExportList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_ExportList.Name = "dataGridView_ExportList";
            this.dataGridView_ExportList.ReadOnly = true;
            this.dataGridView_ExportList.RowHeadersWidth = 51;
            this.dataGridView_ExportList.RowTemplate.Height = 24;
            this.dataGridView_ExportList.Size = new System.Drawing.Size(1067, 432);
            this.dataGridView_ExportList.TabIndex = 1;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(121, 4);
            this.dateTimePicker_From.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(335, 29);
            this.dateTimePicker_From.TabIndex = 2;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(121, 46);
            this.dateTimePicker_To.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(335, 29);
            this.dateTimePicker_To.TabIndex = 3;
            // 
            // button_ReadOutLookFile
            // 
            this.button_ReadOutLookFile.Location = new System.Drawing.Point(21, 90);
            this.button_ReadOutLookFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ReadOutLookFile.Name = "button_ReadOutLookFile";
            this.button_ReadOutLookFile.Size = new System.Drawing.Size(437, 34);
            this.button_ReadOutLookFile.TabIndex = 4;
            this.button_ReadOutLookFile.Text = "Read OutLookFile";
            this.button_ReadOutLookFile.UseVisualStyleBackColor = true;
            this.button_ReadOutLookFile.Click += new System.EventHandler(this.button_ReadOutLookFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Date";
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(21, 130);
            this.button_Export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(437, 34);
            this.button_Export.TabIndex = 7;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // progressBar_Main
            // 
            this.progressBar_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Main.Location = new System.Drawing.Point(0, 641);
            this.progressBar_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar_Main.Name = "progressBar_Main";
            this.progressBar_Main.Size = new System.Drawing.Size(1100, 34);
            this.progressBar_Main.TabIndex = 8;
            // 
            // textBox_Export_Attachment_Path
            // 
            this.textBox_Export_Attachment_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Export_Attachment_Path.Location = new System.Drawing.Point(466, 134);
            this.textBox_Export_Attachment_Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Export_Attachment_Path.Name = "textBox_Export_Attachment_Path";
            this.textBox_Export_Attachment_Path.ReadOnly = true;
            this.textBox_Export_Attachment_Path.Size = new System.Drawing.Size(620, 29);
            this.textBox_Export_Attachment_Path.TabIndex = 9;
            this.textBox_Export_Attachment_Path.TextChanged += new System.EventHandler(this.textBox_Export_Attachment_Path_TextChanged);
            // 
            // textBox_OutLookFilePath
            // 
            this.textBox_OutLookFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OutLookFilePath.Location = new System.Drawing.Point(466, 92);
            this.textBox_OutLookFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_OutLookFilePath.Name = "textBox_OutLookFilePath";
            this.textBox_OutLookFilePath.ReadOnly = true;
            this.textBox_OutLookFilePath.Size = new System.Drawing.Size(620, 29);
            this.textBox_OutLookFilePath.TabIndex = 10;
            this.textBox_OutLookFilePath.TextChanged += new System.EventHandler(this.textBox_OutLookFilePath_TextChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.textBox_OutLookFilePath);
            this.Controls.Add(this.textBox_Export_Attachment_Path);
            this.Controls.Add(this.progressBar_Main);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ReadOutLookFile);
            this.Controls.Add(this.dateTimePicker_To);
            this.Controls.Add(this.dateTimePicker_From);
            this.Controls.Add(this.dataGridView_ExportList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main";
            this.Text = "Export Attachments";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_ExportList;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Button button_ReadOutLookFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.ProgressBar progressBar_Main;
        private System.Windows.Forms.TextBox textBox_Export_Attachment_Path;
        private System.Windows.Forms.TextBox textBox_OutLookFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_SaveAttachments;
    }
}

