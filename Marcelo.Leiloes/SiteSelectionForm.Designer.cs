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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCaixaNorte = new System.Windows.Forms.CheckBox();
            this.chkCaixaCentroOeste = new System.Windows.Forms.CheckBox();
            this.chkCaixaNordeste = new System.Windows.Forms.CheckBox();
            this.chkCaixaSul = new System.Windows.Forms.CheckBox();
            this.chkCaixaRJMGES = new System.Windows.Forms.CheckBox();
            this.chkCaixaSP = new System.Windows.Forms.CheckBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(186, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Busca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtPicker);
            this.groupBox1.Controls.Add(this.chkCaixaNorte);
            this.groupBox1.Controls.Add(this.chkCaixaCentroOeste);
            this.groupBox1.Controls.Add(this.chkCaixaNordeste);
            this.groupBox1.Controls.Add(this.chkCaixaSul);
            this.groupBox1.Controls.Add(this.chkCaixaRJMGES);
            this.groupBox1.Controls.Add(this.chkCaixaSP);
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa Econômica Federal";
            // 
            // chkCaixaNorte
            // 
            this.chkCaixaNorte.AutoSize = true;
            this.chkCaixaNorte.Location = new System.Drawing.Point(15, 65);
            this.chkCaixaNorte.Name = "chkCaixaNorte";
            this.chkCaixaNorte.Size = new System.Drawing.Size(89, 17);
            this.chkCaixaNorte.TabIndex = 11;
            this.chkCaixaNorte.Text = "Região Norte";
            this.chkCaixaNorte.UseVisualStyleBackColor = true;
            // 
            // chkCaixaCentroOeste
            // 
            this.chkCaixaCentroOeste.AutoSize = true;
            this.chkCaixaCentroOeste.Location = new System.Drawing.Point(15, 87);
            this.chkCaixaCentroOeste.Name = "chkCaixaCentroOeste";
            this.chkCaixaCentroOeste.Size = new System.Drawing.Size(125, 17);
            this.chkCaixaCentroOeste.TabIndex = 10;
            this.chkCaixaCentroOeste.Text = "Região Centro-Oeste";
            this.chkCaixaCentroOeste.UseVisualStyleBackColor = true;
            // 
            // chkCaixaNordeste
            // 
            this.chkCaixaNordeste.AutoSize = true;
            this.chkCaixaNordeste.Location = new System.Drawing.Point(146, 65);
            this.chkCaixaNordeste.Name = "chkCaixaNordeste";
            this.chkCaixaNordeste.Size = new System.Drawing.Size(106, 17);
            this.chkCaixaNordeste.TabIndex = 9;
            this.chkCaixaNordeste.Text = "Região Nordeste";
            this.chkCaixaNordeste.UseVisualStyleBackColor = true;
            // 
            // chkCaixaSul
            // 
            this.chkCaixaSul.AutoSize = true;
            this.chkCaixaSul.Location = new System.Drawing.Point(146, 87);
            this.chkCaixaSul.Name = "chkCaixaSul";
            this.chkCaixaSul.Size = new System.Drawing.Size(78, 17);
            this.chkCaixaSul.TabIndex = 8;
            this.chkCaixaSul.Text = "Região Sul";
            this.chkCaixaSul.UseVisualStyleBackColor = true;
            // 
            // chkCaixaRJMGES
            // 
            this.chkCaixaRJMGES.AutoSize = true;
            this.chkCaixaRJMGES.Location = new System.Drawing.Point(15, 42);
            this.chkCaixaRJMGES.Name = "chkCaixaRJMGES";
            this.chkCaixaRJMGES.Size = new System.Drawing.Size(94, 17);
            this.chkCaixaRJMGES.TabIndex = 7;
            this.chkCaixaRJMGES.Text = "RJ + MG + ES";
            this.chkCaixaRJMGES.UseVisualStyleBackColor = true;
            // 
            // chkCaixaSP
            // 
            this.chkCaixaSP.AutoSize = true;
            this.chkCaixaSP.Location = new System.Drawing.Point(15, 19);
            this.chkCaixaSP.Name = "chkCaixaSP";
            this.chkCaixaSP.Size = new System.Drawing.Size(40, 17);
            this.chkCaixaSP.TabIndex = 6;
            this.chkCaixaSP.Text = "SP";
            this.chkCaixaSP.UseVisualStyleBackColor = true;
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(152, 110);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(109, 20);
            this.dtPicker.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Somente leilões a partir de:";
            // 
            // SiteSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 283);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMegaLeiloes;
        private System.Windows.Forms.CheckBox chkLeiloesVIP;
        private System.Windows.Forms.CheckBox chkMilan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCaixaNorte;
        private System.Windows.Forms.CheckBox chkCaixaCentroOeste;
        private System.Windows.Forms.CheckBox chkCaixaNordeste;
        private System.Windows.Forms.CheckBox chkCaixaSul;
        private System.Windows.Forms.CheckBox chkCaixaRJMGES;
        private System.Windows.Forms.CheckBox chkCaixaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPicker;
    }
}