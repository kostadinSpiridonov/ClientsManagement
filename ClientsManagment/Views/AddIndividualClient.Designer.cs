namespace ClientsManagment.Views
{
    partial class AddIndividualClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdNumTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddForm = new System.Windows.Forms.GroupBox();
            this.EmailErrors = new System.Windows.Forms.Label();
            this.PhoneErrors = new System.Windows.Forms.Label();
            this.AddressErrors = new System.Windows.Forms.Label();
            this.IdNumberErrors = new System.Windows.Forms.Label();
            this.GenderErrors = new System.Windows.Forms.Label();
            this.FullNameErrors = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.AddForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Individual Client";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(172, 119);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextBox.TabIndex = 1;
            this.FullNameTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // IdNumTextBox
            // 
            this.IdNumTextBox.Location = new System.Drawing.Point(172, 238);
            this.IdNumTextBox.Name = "IdNumTextBox";
            this.IdNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdNumTextBox.TabIndex = 3;
            this.IdNumTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(172, 284);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(172, 325);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 5;
            this.PhoneTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(172, 368);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 6;
            this.EmailTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(34, 406);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identification Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // AddForm
            // 
            this.AddForm.Controls.Add(this.GenderComboBox);
            this.AddForm.Controls.Add(this.EmailErrors);
            this.AddForm.Controls.Add(this.PhoneErrors);
            this.AddForm.Controls.Add(this.AddressErrors);
            this.AddForm.Controls.Add(this.IdNumberErrors);
            this.AddForm.Controls.Add(this.GenderErrors);
            this.AddForm.Controls.Add(this.FullNameErrors);
            this.AddForm.Controls.Add(this.FullNameTextBox);
            this.AddForm.Controls.Add(this.label7);
            this.AddForm.Controls.Add(this.label6);
            this.AddForm.Controls.Add(this.IdNumTextBox);
            this.AddForm.Controls.Add(this.label5);
            this.AddForm.Controls.Add(this.AddressTextBox);
            this.AddForm.Controls.Add(this.label4);
            this.AddForm.Controls.Add(this.PhoneTextBox);
            this.AddForm.Controls.Add(this.label3);
            this.AddForm.Controls.Add(this.EmailTextBox);
            this.AddForm.Controls.Add(this.label2);
            this.AddForm.Controls.Add(this.AddButton);
            this.AddForm.Location = new System.Drawing.Point(37, 90);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(499, 456);
            this.AddForm.TabIndex = 14;
            this.AddForm.TabStop = false;
            // 
            // EmailErrors
            // 
            this.EmailErrors.AutoSize = true;
            this.EmailErrors.Location = new System.Drawing.Point(295, 371);
            this.EmailErrors.Name = "EmailErrors";
            this.EmailErrors.Size = new System.Drawing.Size(41, 13);
            this.EmailErrors.TabIndex = 19;
            this.EmailErrors.Text = "label13";
            // 
            // PhoneErrors
            // 
            this.PhoneErrors.AutoSize = true;
            this.PhoneErrors.Location = new System.Drawing.Point(295, 332);
            this.PhoneErrors.Name = "PhoneErrors";
            this.PhoneErrors.Size = new System.Drawing.Size(41, 13);
            this.PhoneErrors.TabIndex = 18;
            this.PhoneErrors.Text = "label12";
            // 
            // AddressErrors
            // 
            this.AddressErrors.AutoSize = true;
            this.AddressErrors.Location = new System.Drawing.Point(295, 284);
            this.AddressErrors.Name = "AddressErrors";
            this.AddressErrors.Size = new System.Drawing.Size(41, 13);
            this.AddressErrors.TabIndex = 17;
            this.AddressErrors.Text = "label11";
            // 
            // IdNumberErrors
            // 
            this.IdNumberErrors.AutoSize = true;
            this.IdNumberErrors.Location = new System.Drawing.Point(295, 238);
            this.IdNumberErrors.Name = "IdNumberErrors";
            this.IdNumberErrors.Size = new System.Drawing.Size(41, 13);
            this.IdNumberErrors.TabIndex = 16;
            this.IdNumberErrors.Text = "label10";
            // 
            // GenderErrors
            // 
            this.GenderErrors.AutoSize = true;
            this.GenderErrors.Location = new System.Drawing.Point(295, 191);
            this.GenderErrors.Name = "GenderErrors";
            this.GenderErrors.Size = new System.Drawing.Size(35, 13);
            this.GenderErrors.TabIndex = 15;
            this.GenderErrors.Text = "label9";
            // 
            // FullNameErrors
            // 
            this.FullNameErrors.AutoSize = true;
            this.FullNameErrors.Location = new System.Drawing.Point(295, 119);
            this.FullNameErrors.Name = "FullNameErrors";
            this.FullNameErrors.Size = new System.Drawing.Size(34, 13);
            this.FullNameErrors.TabIndex = 14;
            this.FullNameErrors.Text = "error8";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(172, 191);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(100, 21);
            this.GenderComboBox.TabIndex = 20;
            // 
            // AddIndividualClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.label1);
            this.Name = "AddIndividualClient";
            this.Size = new System.Drawing.Size(741, 590);
            this.AddForm.ResumeLayout(false);
            this.AddForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IdNumTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox AddForm;
        private System.Windows.Forms.Label EmailErrors;
        private System.Windows.Forms.Label PhoneErrors;
        private System.Windows.Forms.Label AddressErrors;
        private System.Windows.Forms.Label IdNumberErrors;
        private System.Windows.Forms.Label GenderErrors;
        private System.Windows.Forms.Label FullNameErrors;
        private System.Windows.Forms.ComboBox GenderComboBox;
    }
}
