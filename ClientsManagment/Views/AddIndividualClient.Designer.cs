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
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.EmailErrors = new System.Windows.Forms.Label();
            this.PhoneErrors = new System.Windows.Forms.Label();
            this.AddressErrors = new System.Windows.Forms.Label();
            this.IdNumberErrors = new System.Windows.Forms.Label();
            this.GenderErrors = new System.Windows.Forms.Label();
            this.FullNameErrors = new System.Windows.Forms.Label();
            this.AddForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Individual Client";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTextBox.Location = new System.Drawing.Point(233, 48);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(263, 29);
            this.FullNameTextBox.TabIndex = 1;
            this.FullNameTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // IdNumTextBox
            // 
            this.IdNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdNumTextBox.Location = new System.Drawing.Point(233, 177);
            this.IdNumTextBox.Name = "IdNumTextBox";
            this.IdNumTextBox.Size = new System.Drawing.Size(263, 29);
            this.IdNumTextBox.TabIndex = 3;
            this.IdNumTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTextBox.Location = new System.Drawing.Point(233, 241);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(263, 29);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.Location = new System.Drawing.Point(233, 306);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(263, 29);
            this.PhoneTextBox.TabIndex = 5;
            this.PhoneTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(233, 368);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(263, 29);
            this.EmailTextBox.TabIndex = 6;
            this.EmailTextBox.Validated += new System.EventHandler(this.FormTextBox_Validated);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(233, 436);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 40);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identification Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
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
            this.AddForm.Location = new System.Drawing.Point(37, 77);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(840, 510);
            this.AddForm.TabIndex = 14;
            this.AddForm.TabStop = false;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(233, 111);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(263, 32);
            this.GenderComboBox.TabIndex = 20;
            // 
            // EmailErrors
            // 
            this.EmailErrors.AutoSize = true;
            this.EmailErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailErrors.ForeColor = System.Drawing.Color.Red;
            this.EmailErrors.Location = new System.Drawing.Point(527, 373);
            this.EmailErrors.Name = "EmailErrors";
            this.EmailErrors.Size = new System.Drawing.Size(70, 24);
            this.EmailErrors.TabIndex = 19;
            this.EmailErrors.Text = "label13";
            // 
            // PhoneErrors
            // 
            this.PhoneErrors.AutoSize = true;
            this.PhoneErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneErrors.ForeColor = System.Drawing.Color.Red;
            this.PhoneErrors.Location = new System.Drawing.Point(527, 311);
            this.PhoneErrors.Name = "PhoneErrors";
            this.PhoneErrors.Size = new System.Drawing.Size(70, 24);
            this.PhoneErrors.TabIndex = 18;
            this.PhoneErrors.Text = "label12";
            // 
            // AddressErrors
            // 
            this.AddressErrors.AutoSize = true;
            this.AddressErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressErrors.ForeColor = System.Drawing.Color.Red;
            this.AddressErrors.Location = new System.Drawing.Point(527, 246);
            this.AddressErrors.Name = "AddressErrors";
            this.AddressErrors.Size = new System.Drawing.Size(70, 24);
            this.AddressErrors.TabIndex = 17;
            this.AddressErrors.Text = "label11";
            // 
            // IdNumberErrors
            // 
            this.IdNumberErrors.AutoSize = true;
            this.IdNumberErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdNumberErrors.ForeColor = System.Drawing.Color.Red;
            this.IdNumberErrors.Location = new System.Drawing.Point(527, 182);
            this.IdNumberErrors.Name = "IdNumberErrors";
            this.IdNumberErrors.Size = new System.Drawing.Size(70, 24);
            this.IdNumberErrors.TabIndex = 16;
            this.IdNumberErrors.Text = "label10";
            // 
            // GenderErrors
            // 
            this.GenderErrors.AutoSize = true;
            this.GenderErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderErrors.ForeColor = System.Drawing.Color.Red;
            this.GenderErrors.Location = new System.Drawing.Point(527, 119);
            this.GenderErrors.Name = "GenderErrors";
            this.GenderErrors.Size = new System.Drawing.Size(60, 24);
            this.GenderErrors.TabIndex = 15;
            this.GenderErrors.Text = "label9";
            // 
            // FullNameErrors
            // 
            this.FullNameErrors.AutoSize = true;
            this.FullNameErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameErrors.ForeColor = System.Drawing.Color.Red;
            this.FullNameErrors.Location = new System.Drawing.Point(527, 58);
            this.FullNameErrors.Name = "FullNameErrors";
            this.FullNameErrors.Size = new System.Drawing.Size(60, 24);
            this.FullNameErrors.TabIndex = 14;
            this.FullNameErrors.Text = "error8";
            // 
            // AddIndividualClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.label1);
            this.Name = "AddIndividualClient";
            this.Size = new System.Drawing.Size(1110, 590);
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
