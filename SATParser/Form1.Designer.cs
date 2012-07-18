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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.textBoxLog.Location = new System.Drawing.Point(14, 353);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(609, 121);
            this.textBoxLog.TabIndex = 92;
            // 
            // openFileDialogSAT
            // 
            this.openFileDialogSAT.FileName = "openFileDialogSAT";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 93;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(73, 295);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "End Date";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(279, 261);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(247, 79);
            this.checkedListBox1.TabIndex = 97;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 99;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 100;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 101;
            this.checkBox1.Text = "All Dates";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(199, 320);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 102;
            this.checkBox2.Text = "All Users";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FormSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 486);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

