namespace SRTPluginUIRE2WinForms
{
    partial class OptionsUI
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
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
            this.noTitlebarCheckBox = new System.Windows.Forms.CheckBox();
            this.transparentBackgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.noInventoryCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scalingFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.optionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalingFactorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // debugCheckBox
            // 
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.Location = new System.Drawing.Point(7, 97);
            this.debugCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(95, 19);
            this.debugCheckBox.TabIndex = 0;
            this.debugCheckBox.Text = "Debug Mode";
            this.debugCheckBox.UseVisualStyleBackColor = true;
            // 
            // noTitlebarCheckBox
            // 
            this.noTitlebarCheckBox.AutoSize = true;
            this.noTitlebarCheckBox.Location = new System.Drawing.Point(7, 22);
            this.noTitlebarCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noTitlebarCheckBox.Name = "noTitlebarCheckBox";
            this.noTitlebarCheckBox.Size = new System.Drawing.Size(84, 19);
            this.noTitlebarCheckBox.TabIndex = 2;
            this.noTitlebarCheckBox.Text = "No Titlebar";
            this.noTitlebarCheckBox.UseVisualStyleBackColor = true;
            // 
            // transparentBackgroundCheckBox
            // 
            this.transparentBackgroundCheckBox.AutoSize = true;
            this.transparentBackgroundCheckBox.Location = new System.Drawing.Point(7, 47);
            this.transparentBackgroundCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.transparentBackgroundCheckBox.Name = "transparentBackgroundCheckBox";
            this.transparentBackgroundCheckBox.Size = new System.Drawing.Size(154, 19);
            this.transparentBackgroundCheckBox.TabIndex = 4;
            this.transparentBackgroundCheckBox.Text = "Transparent Background";
            this.transparentBackgroundCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.noInventoryCheckBox);
            this.optionsGroupBox.Controls.Add(this.label1);
            this.optionsGroupBox.Controls.Add(this.scalingFactorNumericUpDown);
            this.optionsGroupBox.Controls.Add(this.debugCheckBox);
            this.optionsGroupBox.Controls.Add(this.transparentBackgroundCheckBox);
            this.optionsGroupBox.Controls.Add(this.noTitlebarCheckBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(2, 2);
            this.optionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.optionsGroupBox.Size = new System.Drawing.Size(197, 157);
            this.optionsGroupBox.TabIndex = 5;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // noInventoryCheckBox
            // 
            this.noInventoryCheckBox.AutoSize = true;
            this.noInventoryCheckBox.Location = new System.Drawing.Point(7, 72);
            this.noInventoryCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noInventoryCheckBox.Name = "noInventoryCheckBox";
            this.noInventoryCheckBox.Size = new System.Drawing.Size(136, 19);
            this.noInventoryCheckBox.TabIndex = 7;
            this.noInventoryCheckBox.Text = "No Inventory Display";
            this.noInventoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scaling Factor";
            // 
            // scalingFactorNumericUpDown
            // 
            this.scalingFactorNumericUpDown.DecimalPlaces = 2;
            this.scalingFactorNumericUpDown.Location = new System.Drawing.Point(7, 122);
            this.scalingFactorNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scalingFactorNumericUpDown.Name = "scalingFactorNumericUpDown";
            this.scalingFactorNumericUpDown.Size = new System.Drawing.Size(62, 23);
            this.scalingFactorNumericUpDown.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(2, 165);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 27);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(111, 165);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 27);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OptionsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 194);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.optionsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OptionsUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RE2 (2019) SRT";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalingFactorNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.CheckBox noTitlebarCheckBox;
        private System.Windows.Forms.CheckBox transparentBackgroundCheckBox;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown scalingFactorNumericUpDown;
        private System.Windows.Forms.CheckBox noInventoryCheckBox;
    }
}