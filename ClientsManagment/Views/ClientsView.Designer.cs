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
            this.ClientsContainer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsContainer
            // 
            this.ClientsContainer.AllowUserToAddRows = false;
            this.ClientsContainer.AllowUserToDeleteRows = false;
            this.ClientsContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsContainer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientsContainer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientsContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsContainer.Location = new System.Drawing.Point(22, 91);
            this.ClientsContainer.Name = "ClientsContainer";
            this.ClientsContainer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientsContainer.RowHeadersVisible = false;
            this.ClientsContainer.Size = new System.Drawing.Size(557, 296);
            this.ClientsContainer.TabIndex = 3;
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ClientsContainer);
            this.Name = "ClientsView";
            this.Size = new System.Drawing.Size(792, 559);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ClientsContainer;
    }
}
