namespace CarWorkshop
{
    partial class NewTypeAdding
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
            this.Type_Label = new System.Windows.Forms.Label();
            this.CodeOfType_TextBox = new System.Windows.Forms.TextBox();
            this.CodeOfType_Label = new System.Windows.Forms.Label();
            this.Type_TextBox = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.Type_Label.Location = new System.Drawing.Point(14, 15);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(31, 13);
            this.Type_Label.TabIndex = 53;
            this.Type_Label.Text = "Type";
            // 
            // CodeOfType_TextBox
            // 
            this.CodeOfType_TextBox.Location = new System.Drawing.Point(124, 40);
            this.CodeOfType_TextBox.Name = "CodeOfType_TextBox";
            this.CodeOfType_TextBox.Size = new System.Drawing.Size(150, 20);
            this.CodeOfType_TextBox.TabIndex = 56;
            // 
            // CodeOfType_Label
            // 
            this.CodeOfType_Label.AutoSize = true;
            this.CodeOfType_Label.Location = new System.Drawing.Point(14, 43);
            this.CodeOfType_Label.Name = "CodeOfType_Label";
            this.CodeOfType_Label.Size = new System.Drawing.Size(67, 13);
            this.CodeOfType_Label.TabIndex = 57;
            this.CodeOfType_Label.Text = "Code of type";
            // 
            // Type_TextBox
            // 
            this.Type_TextBox.Location = new System.Drawing.Point(124, 12);
            this.Type_TextBox.Name = "Type_TextBox";
            this.Type_TextBox.Size = new System.Drawing.Size(150, 20);
            this.Type_TextBox.TabIndex = 58;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(118, 76);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 60;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(199, 76);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 59;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // NewTypeAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Type_TextBox);
            this.Controls.Add(this.CodeOfType_Label);
            this.Controls.Add(this.CodeOfType_TextBox);
            this.Controls.Add(this.Type_Label);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "NewTypeAdding";
            this.Text = "NewTypeAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.TextBox CodeOfType_TextBox;
        private System.Windows.Forms.Label CodeOfType_Label;
        private System.Windows.Forms.TextBox Type_TextBox;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
    }
}