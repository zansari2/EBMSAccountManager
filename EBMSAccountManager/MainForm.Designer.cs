namespace EBMSAccountManager
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dodIDTextBox = new System.Windows.Forms.TextBox();
            this.facilityComboBox = new System.Windows.Forms.ComboBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Text = "First Name";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(12, 39);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.middleNameTextBox.TabIndex = 1;
            this.middleNameTextBox.Text = "Middle Name (Initial)";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(12, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Last Name";
            // 
            // dodIDTextBox
            // 
            this.dodIDTextBox.Location = new System.Drawing.Point(12, 92);
            this.dodIDTextBox.Name = "dodIDTextBox";
            this.dodIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.dodIDTextBox.TabIndex = 3;
            this.dodIDTextBox.Text = "DoD ID";
            // 
            // facilityComboBox
            // 
            this.facilityComboBox.FormattingEnabled = true;
            this.facilityComboBox.Location = new System.Drawing.Point(12, 119);
            this.facilityComboBox.Name = "facilityComboBox";
            this.facilityComboBox.Size = new System.Drawing.Size(121, 21);
            this.facilityComboBox.TabIndex = 4;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(12, 147);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(197, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.facilityComboBox);
            this.Controls.Add(this.dodIDTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EBMS-T Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox dodIDTextBox;
        private System.Windows.Forms.ComboBox facilityComboBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Button StartButton;
    }
}

