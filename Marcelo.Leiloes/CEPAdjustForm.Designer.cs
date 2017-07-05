namespace Marcelo.Leiloes
{
    partial class CEPAdjustForm
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
            this.progressProgressBar = new System.Windows.Forms.ProgressBar();
            this.FillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressProgressBar
            // 
            this.progressProgressBar.Location = new System.Drawing.Point(12, 12);
            this.progressProgressBar.Name = "progressProgressBar";
            this.progressProgressBar.Size = new System.Drawing.Size(281, 23);
            this.progressProgressBar.TabIndex = 11;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(299, 12);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 10;
            this.FillButton.Text = "Processar";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // CEPAdjustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 47);
            this.Controls.Add(this.progressProgressBar);
            this.Controls.Add(this.FillButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CEPAdjustForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preenchimento de CEP";
            this.Load += new System.EventHandler(this.CEPAdjustForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressProgressBar;
        private System.Windows.Forms.Button FillButton;
    }
}