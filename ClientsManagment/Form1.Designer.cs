﻿using ClientsManagment.ViewModels;

namespace ClientsManagment
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIndividualClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLevalEntityClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NavigationContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.addClientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIndividualClientToolStripMenuItem,
            this.addLevalEntityClientToolStripMenuItem});
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.addClientToolStripMenuItem.Text = "Add Client";
            // 
            // addIndividualClientToolStripMenuItem
            // 
            this.addIndividualClientToolStripMenuItem.Name = "addIndividualClientToolStripMenuItem";
            this.addIndividualClientToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addIndividualClientToolStripMenuItem.Text = "Add Individual Client";
            this.addIndividualClientToolStripMenuItem.Click += new System.EventHandler(this.addIndividualClientToolStripMenuItem_Click);
            // 
            // addLevalEntityClientToolStripMenuItem
            // 
            this.addLevalEntityClientToolStripMenuItem.Name = "addLevalEntityClientToolStripMenuItem";
            this.addLevalEntityClientToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addLevalEntityClientToolStripMenuItem.Text = "Add Legal Entity Client";
            this.addLevalEntityClientToolStripMenuItem.Click += new System.EventHandler(this.addLevalEntityClientToolStripMenuItem_Click);
            // 
            // NavigationContainer
            // 
            this.NavigationContainer.AutoSize = true;
            this.NavigationContainer.BackColor = System.Drawing.SystemColors.Control;
            this.NavigationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationContainer.Location = new System.Drawing.Point(0, 24);
            this.NavigationContainer.Name = "NavigationContainer";
            this.NavigationContainer.Size = new System.Drawing.Size(1284, 637);
            this.NavigationContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.NavigationContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clients Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.Panel NavigationContainer;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIndividualClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLevalEntityClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}

