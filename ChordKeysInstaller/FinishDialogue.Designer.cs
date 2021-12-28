namespace ChordKeysInstaller
{
    partial class FinishDialogue
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
            this.FinishPrompt = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinishPrompt
            // 
            this.FinishPrompt.AutoSize = true;
            this.FinishPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishPrompt.Location = new System.Drawing.Point(186, 69);
            this.FinishPrompt.Name = "FinishPrompt";
            this.FinishPrompt.Size = new System.Drawing.Size(273, 20);
            this.FinishPrompt.TabIndex = 0;
            this.FinishPrompt.Text = "Installation completed successfully.";
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(485, 127);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(114, 40);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // FinishDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 190);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.FinishPrompt);
            this.Name = "FinishDialogue";
            this.Text = "ChordKeys Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinishPrompt;
        private System.Windows.Forms.Button FinishButton;
    }
}