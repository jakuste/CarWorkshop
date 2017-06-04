namespace Przychodnia
{
    partial class ActivityEditor
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
            this.Description_Label = new System.Windows.Forms.Label();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.TypeAdding_Button = new System.Windows.Forms.Button();
            this.Type_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Worker_Label = new System.Windows.Forms.Label();
            this.Worker_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(12, 9);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(60, 13);
            this.Description_Label.TabIndex = 0;
            this.Description_Label.Text = "Description";
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.Location = new System.Drawing.Point(15, 25);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(207, 139);
            this.Description_TextBox.TabIndex = 1;
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(66, 170);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(129, 21);
            this.Type_ComboBox.TabIndex = 2;
            // 
            // TypeAdding_Button
            // 
            this.TypeAdding_Button.Location = new System.Drawing.Point(201, 170);
            this.TypeAdding_Button.Name = "TypeAdding_Button";
            this.TypeAdding_Button.Size = new System.Drawing.Size(21, 21);
            this.TypeAdding_Button.TabIndex = 3;
            this.TypeAdding_Button.Text = "+";
            this.TypeAdding_Button.UseVisualStyleBackColor = true;
            this.TypeAdding_Button.Click += new System.EventHandler(this.TypeAdding_Button_Click);
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.Type_Label.Location = new System.Drawing.Point(12, 174);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(31, 13);
            this.Type_Label.TabIndex = 4;
            this.Type_Label.Text = "Type";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(66, 224);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(147, 224);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 25);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Worker_Label
            // 
            this.Worker_Label.AutoSize = true;
            this.Worker_Label.Location = new System.Drawing.Point(12, 200);
            this.Worker_Label.Name = "Worker_Label";
            this.Worker_Label.Size = new System.Drawing.Size(42, 13);
            this.Worker_Label.TabIndex = 8;
            this.Worker_Label.Text = "Worker";
            // 
            // Worker_ComboBox
            // 
            this.Worker_ComboBox.FormattingEnabled = true;
            this.Worker_ComboBox.Location = new System.Drawing.Point(66, 197);
            this.Worker_ComboBox.Name = "Worker_ComboBox";
            this.Worker_ComboBox.Size = new System.Drawing.Size(156, 21);
            this.Worker_ComboBox.TabIndex = 7;
            // 
            // ActivityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.Worker_Label);
            this.Controls.Add(this.Worker_ComboBox);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Type_Label);
            this.Controls.Add(this.TypeAdding_Button);
            this.Controls.Add(this.Type_ComboBox);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.Description_Label);
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "ActivityEditor";
            this.Text = "ActivityEditor";
            this.Load += new System.EventHandler(this.ActivityEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.ComboBox Type_ComboBox;
        private System.Windows.Forms.Button TypeAdding_Button;
        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label Worker_Label;
        private System.Windows.Forms.ComboBox Worker_ComboBox;
    }
}