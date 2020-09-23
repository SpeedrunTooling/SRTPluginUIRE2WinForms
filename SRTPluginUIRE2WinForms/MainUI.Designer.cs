﻿namespace SRTPluginUIRE2WinForms
{
    partial class MainUI
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
            this.playerHealthStatus = new System.Windows.Forms.PictureBox();
            this.statisticsPanel = new DoubleBufferedPanel();
            this.inventoryPanel = new DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.playerHealthStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // playerHealthStatus
            // 
            this.playerHealthStatus.Image = (System.Drawing.Bitmap)global::SRTPluginUIRE2WinForms.Properties.Resources.ResourceManager.GetObject("EMPTY");
            this.playerHealthStatus.InitialImage = (System.Drawing.Bitmap)global::SRTPluginUIRE2WinForms.Properties.Resources.ResourceManager.GetObject("EMPTY");
            this.playerHealthStatus.Location = new System.Drawing.Point(1, 1);
            this.playerHealthStatus.Name = "playerHealthStatus";
            this.playerHealthStatus.Size = new System.Drawing.Size(150, 60);
            this.playerHealthStatus.TabIndex = 0;
            this.playerHealthStatus.TabStop = false;
            this.playerHealthStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerHealthStatus_MouseDown);
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Location = new System.Drawing.Point(1, 67);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(150, 354);
            this.statisticsPanel.TabIndex = 2;
            this.statisticsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statisticsPanel_MouseDown);
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Location = new System.Drawing.Point(157, 1);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(336, 420);
            this.inventoryPanel.TabIndex = 3;
            this.inventoryPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inventoryPanel_MouseDown);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(494, 422);
            this.Controls.Add(this.inventoryPanel);
            this.Controls.Add(this.statisticsPanel);
            this.Controls.Add(this.playerHealthStatus);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.Text = "RE2 (2019) SRT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUI_FormClosed);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerHealthStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerHealthStatus;
        private DoubleBufferedPanel statisticsPanel;
        private DoubleBufferedPanel inventoryPanel;
    }
}