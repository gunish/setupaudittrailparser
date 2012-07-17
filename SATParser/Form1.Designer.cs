namespace SATParser
{
    partial class FormSAT
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
            this.labelSAT = new System.Windows.Forms.Label();
            this.buttonSATLoad = new System.Windows.Forms.Button();
            this.textBoxSAT = new System.Windows.Forms.TextBox();
            this.dataGridViewSAT = new System.Windows.Forms.DataGridView();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.openFileDialogSAT = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSAT = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSAT)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSAT
            // 
            this.labelSAT.AutoSize = true;
            this.labelSAT.Location = new System.Drawing.Point(11, 23);
            this.labelSAT.Name = "labelSAT";
            this.labelSAT.Size = new System.Drawing.Size(85, 13);
            this.labelSAT.TabIndex = 90;
            this.labelSAT.Text = "Setup Audit Trail";
            // 
            // buttonSATLoad
            // 
            this.buttonSATLoad.Location = new System.Drawing.Point(548, 18);
            this.buttonSATLoad.Name = "buttonSATLoad";
            this.buttonSATLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonSATLoad.TabIndex = 89;
            this.buttonSATLoad.Text = "Select";
            this.buttonSATLoad.UseVisualStyleBackColor = true;
            this.buttonSATLoad.Click += new System.EventHandler(this.buttonSATLoad_Click);
            // 
            // textBoxSAT
            // 
            this.textBoxSAT.Location = new System.Drawing.Point(102, 21);
            this.textBoxSAT.Name = "textBoxSAT";
            this.textBoxSAT.Size = new System.Drawing.Size(440, 20);
            this.textBoxSAT.TabIndex = 88;
            // 
            // dataGridViewSAT
            // 
            this.dataGridViewSAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSAT.Location = new System.Drawing.Point(14, 58);
            this.dataGridViewSAT.Name = "dataGridViewSAT";
            this.dataGridViewSAT.Size = new System.Drawing.Size(609, 192);
            this.dataGridViewSAT.TabIndex = 91;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(14, 256);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(609, 218);
            this.textBoxLog.TabIndex = 92;
            // 
            // openFileDialogSAT
            // 
            this.openFileDialogSAT.FileName = "openFileDialogSAT";
            // 
            // FormSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 486);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.dataGridViewSAT);
            this.Controls.Add(this.labelSAT);
            this.Controls.Add(this.buttonSATLoad);
            this.Controls.Add(this.textBoxSAT);
            this.Name = "FormSAT";
            this.Text = "Setup Audit Trail Parser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSAT;
        private System.Windows.Forms.Button buttonSATLoad;
        private System.Windows.Forms.TextBox textBoxSAT;
        private System.Windows.Forms.DataGridView dataGridViewSAT;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.OpenFileDialog openFileDialogSAT;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSAT;
    }
}

