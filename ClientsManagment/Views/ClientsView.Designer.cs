namespace ClientsManagment.Views
{
    partial class ClientsView
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
            this.ClientsContainer = new System.Windows.Forms.ListBox();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientsContainer
            // 
            this.ClientsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsContainer.FormattingEnabled = true;
            this.ClientsContainer.Location = new System.Drawing.Point(0, 0);
            this.ClientsContainer.Name = "ClientsContainer";
            this.ClientsContainer.Size = new System.Drawing.Size(792, 559);
            this.ClientsContainer.TabIndex = 0;
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Location = new System.Drawing.Point(602, 81);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSelectedButton.TabIndex = 1;
            this.DeleteSelectedButton.Text = "DeleteSelectedButton";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(602, 124);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 23);
            this.DetailsButton.TabIndex = 2;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.ClientsContainer);
            this.Name = "ClientsView";
            this.Size = new System.Drawing.Size(792, 559);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ClientsContainer;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button DetailsButton;
    }
}
