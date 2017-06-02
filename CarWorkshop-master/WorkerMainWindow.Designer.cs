namespace Przychodnia
{
    partial class WorkerMainWindow
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
            this.Search_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SequenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfRequwst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Show_Button = new System.Windows.Forms.Button();
            this.NextDay_Button = new System.Windows.Forms.Button();
            this.PreviousDay_Button = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.WelcomeText_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(651, 31);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(121, 21);
            this.Search_Button.TabIndex = 20;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SequenceNumber,
            this.nameOfRequwst,
            this.Description,
            this.DateRequest,
            this.dateFinCancel,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 365);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SequenceNumber
            // 
            this.SequenceNumber.HeaderText = "Seq Nr";
            this.SequenceNumber.Name = "SequenceNumber";
            this.SequenceNumber.Width = 50;
            // 
            // nameOfRequwst
            // 
            this.nameOfRequwst.HeaderText = "Name";
            this.nameOfRequwst.Name = "nameOfRequwst";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // DateRequest
            // 
            this.DateRequest.HeaderText = "Date Request";
            this.DateRequest.Name = "DateRequest";
            // 
            // dateFinCancel
            // 
            this.dateFinCancel.HeaderText = "Time Out";
            this.dateFinCancel.Name = "dateFinCancel";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Status_ComboBox
            // 
            this.Status_ComboBox.FormattingEnabled = true;
            this.Status_ComboBox.Location = new System.Drawing.Point(524, 31);
            this.Status_ComboBox.Name = "Status_ComboBox";
            this.Status_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Status_ComboBox.TabIndex = 23;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(481, 35);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(37, 13);
            this.Status_Label.TabIndex = 24;
            this.Status_Label.Text = "Status";
            // 
            // Show_Button
            // 
            this.Show_Button.Location = new System.Drawing.Point(651, 430);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(121, 26);
            this.Show_Button.TabIndex = 25;
            this.Show_Button.Text = "Show";
            this.Show_Button.UseVisualStyleBackColor = true;
            this.Show_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // NextDay_Button
            // 
            this.NextDay_Button.Location = new System.Drawing.Point(451, 32);
            this.NextDay_Button.Name = "NextDay_Button";
            this.NextDay_Button.Size = new System.Drawing.Size(21, 21);
            this.NextDay_Button.TabIndex = 39;
            this.NextDay_Button.Text = ">";
            this.NextDay_Button.UseVisualStyleBackColor = true;
            // 
            // PreviousDay_Button
            // 
            this.PreviousDay_Button.Location = new System.Drawing.Point(219, 31);
            this.PreviousDay_Button.Name = "PreviousDay_Button";
            this.PreviousDay_Button.Size = new System.Drawing.Size(21, 21);
            this.PreviousDay_Button.TabIndex = 38;
            this.PreviousDay_Button.Text = "<";
            this.PreviousDay_Button.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "DD.MM.YYYY";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(247, 32);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.DateTimePicker.TabIndex = 37;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(14, 34);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 41;
            this.Name_Label.Text = "Name";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(55, 31);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(150, 20);
            this.Name_TextBox.TabIndex = 40;
            // 
            // LogOut_button
            // 
            this.LogOut_button.Location = new System.Drawing.Point(697, 2);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.Size = new System.Drawing.Size(75, 23);
            this.LogOut_button.TabIndex = 42;
            this.LogOut_button.Text = "Log out";
            this.LogOut_button.UseVisualStyleBackColor = true;
            // 
            // WelcomeText_Label
            // 
            this.WelcomeText_Label.AutoSize = true;
            this.WelcomeText_Label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WelcomeText_Label.Location = new System.Drawing.Point(14, 7);
            this.WelcomeText_Label.Name = "WelcomeText_Label";
            this.WelcomeText_Label.Size = new System.Drawing.Size(55, 13);
            this.WelcomeText_Label.TabIndex = 43;
            this.WelcomeText_Label.Text = "Welcome!";
            // 
            // WorkerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.WelcomeText_Label);
            this.Controls.Add(this.LogOut_button);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.NextDay_Button);
            this.Controls.Add(this.PreviousDay_Button);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Status_ComboBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "WorkerMainWindow";
            this.Text = "WorkerMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Status_ComboBox;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn SequenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfRequwst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button Show_Button;
        private System.Windows.Forms.Button NextDay_Button;
        private System.Windows.Forms.Button PreviousDay_Button;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.Label WelcomeText_Label;
    }
}