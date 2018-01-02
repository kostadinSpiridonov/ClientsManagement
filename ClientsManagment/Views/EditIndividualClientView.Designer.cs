namespace ClientsManagment.Views
{
    partial class EditIndividualClientView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdNumTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.FullNameErrors = new System.Windows.Forms.Label();
            this.GenderErrors = new System.Windows.Forms.Label();
            this.IdNumberErrors = new System.Windows.Forms.Label();
            this.AddressErrors = new System.Windows.Forms.Label();
            this.PhoneErrors = new System.Windows.Forms.Label();
            this.EmailErrors = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(132, 125);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // IdNumTextBox
            // 
            this.IdNumTextBox.Location = new System.Drawing.Point(132, 198);
            this.IdNumTextBox.Name = "IdNumTextBox";
            this.IdNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdNumTextBox.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(132, 276);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(132, 345);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(132, 406);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(132, 162);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenderComboBox.TabIndex = 6;
            // 
            // FullNameErrors
            // 
            this.FullNameErrors.AutoSize = true;
            this.FullNameErrors.Location = new System.Drawing.Point(287, 131);
            this.FullNameErrors.Name = "FullNameErrors";
            this.FullNameErrors.Size = new System.Drawing.Size(35, 13);
            this.FullNameErrors.TabIndex = 7;
            this.FullNameErrors.Text = "label1";
            // 
            // GenderErrors
            // 
            this.GenderErrors.AutoSize = true;
            this.GenderErrors.Location = new System.Drawing.Point(287, 170);
            this.GenderErrors.Name = "GenderErrors";
            this.GenderErrors.Size = new System.Drawing.Size(35, 13);
            this.GenderErrors.TabIndex = 8;
            this.GenderErrors.Text = "label2";
            // 
            // IdNumberErrors
            // 
            this.IdNumberErrors.AutoSize = true;
            this.IdNumberErrors.Location = new System.Drawing.Point(287, 205);
            this.IdNumberErrors.Name = "IdNumberErrors";
            this.IdNumberErrors.Size = new System.Drawing.Size(35, 13);
            this.IdNumberErrors.TabIndex = 9;
            this.IdNumberErrors.Text = "label3";
            // 
            // AddressErrors
            // 
            this.AddressErrors.AutoSize = true;
            this.AddressErrors.Location = new System.Drawing.Point(287, 283);
            this.AddressErrors.Name = "AddressErrors";
            this.AddressErrors.Size = new System.Drawing.Size(35, 13);
            this.AddressErrors.TabIndex = 10;
            this.AddressErrors.Text = "label4";
            // 
            // PhoneErrors
            // 
            this.PhoneErrors.AutoSize = true;
            this.PhoneErrors.Location = new System.Drawing.Point(287, 348);
            this.PhoneErrors.Name = "PhoneErrors";
            this.PhoneErrors.Size = new System.Drawing.Size(35, 13);
            this.PhoneErrors.TabIndex = 11;
            this.PhoneErrors.Text = "label5";
            // 
            // EmailErrors
            // 
            this.EmailErrors.AutoSize = true;
            this.EmailErrors.Location = new System.Drawing.Point(304, 409);
            this.EmailErrors.Name = "EmailErrors";
            this.EmailErrors.Size = new System.Drawing.Size(35, 13);
            this.EmailErrors.TabIndex = 12;
            this.EmailErrors.Text = "label6";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(132, 478);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "button1";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // EditIndividualClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.EmailErrors);
            this.Controls.Add(this.PhoneErrors);
            this.Controls.Add(this.AddressErrors);
            this.Controls.Add(this.IdNumberErrors);
            this.Controls.Add(this.GenderErrors);
            this.Controls.Add(this.FullNameErrors);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.IdNumTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Name = "EditIndividualClientView";
            this.Size = new System.Drawing.Size(1018, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IdNumTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label FullNameErrors;
        private System.Windows.Forms.Label GenderErrors;
        private System.Windows.Forms.Label IdNumberErrors;
        private System.Windows.Forms.Label AddressErrors;
        private System.Windows.Forms.Label PhoneErrors;
        private System.Windows.Forms.Label EmailErrors;
        private System.Windows.Forms.Button UpdateButton;
    }
}
