namespace Marcelo.Leiloes
{
    partial class ImportForm
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressProgressBar
            // 
            this.progressProgressBar.Location = new System.Drawing.Point(16, 41);
            this.progressProgressBar.Name = "progressProgressBar";
            this.progressProgressBar.Size = new System.Drawing.Size(281, 23);
            this.progressProgressBar.TabIndex = 7;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(303, 41);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 6;
            this.FillButton.Text = "Importar";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(303, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 5;
            this.selectFileButton.Text = "Selecionar...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o local do arquivo...";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 73);
            this.Controls.Add(this.progressProgressBar);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importar itens de um arquivo";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressProgressBar;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label label1;
    }
}