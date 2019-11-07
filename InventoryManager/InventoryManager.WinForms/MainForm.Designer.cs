namespace InventoryManager.WinForms
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
            this.fileLabelText = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileLabelText
            // 
            this.fileLabelText.AutoSize = true;
            this.fileLabelText.Location = new System.Drawing.Point(12, 9);
            this.fileLabelText.Name = "fileLabelText";
            this.fileLabelText.Size = new System.Drawing.Size(34, 17);
            this.fileLabelText.TabIndex = 0;
            this.fileLabelText.Text = "File:";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(713, 6);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(48, 6);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(659, 22);
            this.filenameTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.fileLabelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLabelText;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filenameTextBox;
    }
}

