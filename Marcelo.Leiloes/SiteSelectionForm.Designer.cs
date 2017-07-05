namespace Marcelo.Leiloes
{
    partial class SiteSelectionForm
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
            this.chkMegaLeiloes = new System.Windows.Forms.CheckBox();
            this.chkLeiloesVIP = new System.Windows.Forms.CheckBox();
            this.chkMilan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkMegaLeiloes
            // 
            this.chkMegaLeiloes.AutoSize = true;
            this.chkMegaLeiloes.Location = new System.Drawing.Point(12, 34);
            this.chkMegaLeiloes.Name = "chkMegaLeiloes";
            this.chkMegaLeiloes.Size = new System.Drawing.Size(89, 17);
            this.chkMegaLeiloes.TabIndex = 0;
            this.chkMegaLeiloes.Text = "Mega Leilões";
            this.chkMegaLeiloes.UseVisualStyleBackColor = true;
            // 
            // chkLeiloesVIP
            // 
            this.chkLeiloesVIP.AutoSize = true;
            this.chkLeiloesVIP.Location = new System.Drawing.Point(12, 57);
            this.chkLeiloesVIP.Name = "chkLeiloesVIP";
            this.chkLeiloesVIP.Size = new System.Drawing.Size(79, 17);
            this.chkLeiloesVIP.TabIndex = 1;
            this.chkLeiloesVIP.Text = "Leilões VIP";
            this.chkLeiloesVIP.UseVisualStyleBackColor = true;
            // 
            // chkMilan
            // 
            this.chkMilan.AutoSize = true;
            this.chkMilan.Location = new System.Drawing.Point(12, 80);
            this.chkMilan.Name = "chkMilan";
            this.chkMilan.Size = new System.Drawing.Size(87, 17);
            this.chkMilan.TabIndex = 2;
            this.chkMilan.Text = "Milan Leilões";
            this.chkMilan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione os sites que deseja buscar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Busca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SiteSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMilan);
            this.Controls.Add(this.chkLeiloesVIP);
            this.Controls.Add(this.chkMegaLeiloes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiteSelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Sites de Leilão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMegaLeiloes;
        private System.Windows.Forms.CheckBox chkLeiloesVIP;
        private System.Windows.Forms.CheckBox chkMilan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}