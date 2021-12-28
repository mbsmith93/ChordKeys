namespace ChordKeysInstaller
{
    partial class TargetDirectoryDialogue
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
            this.TargetDirectoryPrompt = new System.Windows.Forms.Label();
            this.TargetDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.TargetDirectoryCancelButton = new System.Windows.Forms.Button();
            this.TargetDirectoryInstallButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetDirectoryPrompt
            // 
            this.TargetDirectoryPrompt.AutoSize = true;
            this.TargetDirectoryPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDirectoryPrompt.Location = new System.Drawing.Point(29, 28);
            this.TargetDirectoryPrompt.Name = "TargetDirectoryPrompt";
            this.TargetDirectoryPrompt.Size = new System.Drawing.Size(221, 20);
            this.TargetDirectoryPrompt.TabIndex = 0;
            this.TargetDirectoryPrompt.Text = "Choose installation directory";
            // 
            // TargetDirectoryTextBox
            // 
            this.TargetDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDirectoryTextBox.Location = new System.Drawing.Point(52, 63);
            this.TargetDirectoryTextBox.Name = "TargetDirectoryTextBox";
            this.TargetDirectoryTextBox.Size = new System.Drawing.Size(569, 28);
            this.TargetDirectoryTextBox.TabIndex = 1;
            this.TargetDirectoryTextBox.Text = "C:\\Program Files\\ChordKeys";
            // 
            // TargetDirectoryCancelButton
            // 
            this.TargetDirectoryCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDirectoryCancelButton.Location = new System.Drawing.Point(387, 121);
            this.TargetDirectoryCancelButton.Name = "TargetDirectoryCancelButton";
            this.TargetDirectoryCancelButton.Size = new System.Drawing.Size(114, 40);
            this.TargetDirectoryCancelButton.TabIndex = 2;
            this.TargetDirectoryCancelButton.Text = "cancel";
            this.TargetDirectoryCancelButton.UseVisualStyleBackColor = true;
            this.TargetDirectoryCancelButton.Click += new System.EventHandler(this.TargetDirectoryCancelButton_Click);
            // 
            // TargetDirectoryInstallButton
            // 
            this.TargetDirectoryInstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDirectoryInstallButton.Location = new System.Drawing.Point(507, 121);
            this.TargetDirectoryInstallButton.Name = "TargetDirectoryInstallButton";
            this.TargetDirectoryInstallButton.Size = new System.Drawing.Size(114, 40);
            this.TargetDirectoryInstallButton.TabIndex = 3;
            this.TargetDirectoryInstallButton.Text = "install";
            this.TargetDirectoryInstallButton.UseVisualStyleBackColor = true;
            this.TargetDirectoryInstallButton.Click += new System.EventHandler(this.TargetDirectoryInstallButton_Click);
            // 
            // TargetDirectoryDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 190);
            this.Controls.Add(this.TargetDirectoryInstallButton);
            this.Controls.Add(this.TargetDirectoryCancelButton);
            this.Controls.Add(this.TargetDirectoryTextBox);
            this.Controls.Add(this.TargetDirectoryPrompt);
            this.Name = "TargetDirectoryDialogue";
            this.Text = "ChordKeys Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TargetDirectoryPrompt;
        private System.Windows.Forms.TextBox TargetDirectoryTextBox;
        private System.Windows.Forms.Button TargetDirectoryCancelButton;
        private System.Windows.Forms.Button TargetDirectoryInstallButton;
    }
}

