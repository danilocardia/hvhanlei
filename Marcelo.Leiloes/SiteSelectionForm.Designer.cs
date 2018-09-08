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
            this.label2 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.chkCaixaNorte = new System.Windows.Forms.CheckBox();
            this.chkCaixaCentroOeste = new System.Windows.Forms.CheckBox();
            this.chkCaixaNordeste = new System.Windows.Forms.CheckBox();
            this.chkCaixaSul = new System.Windows.Forms.CheckBox();
            this.chkCaixaRJMGES = new System.Windows.Forms.CheckBox();
            this.chkCaixaSP = new System.Windows.Forms.CheckBox();
            this.chkFreitas = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtZuckermanLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkZuckermanNorte = new System.Windows.Forms.CheckBox();
            this.chkZuckermanCentroOeste = new System.Windows.Forms.CheckBox();
            this.chkZuckermanNordeste = new System.Windows.Forms.CheckBox();
            this.chkZuckermanSul = new System.Windows.Forms.CheckBox();
            this.chkZuckermanRJMGES = new System.Windows.Forms.CheckBox();
            this.chkZuckermanSP = new System.Windows.Forms.CheckBox();
            this.chkSodre = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZuckermanLimit)).BeginInit();
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
            this.chkLeiloesVIP.Location = new System.Drawing.Point(158, 34);
            this.chkLeiloesVIP.Name = "chkLeiloesVIP";
            this.chkLeiloesVIP.Size = new System.Drawing.Size(79, 17);
            this.chkLeiloesVIP.TabIndex = 1;
            this.chkLeiloesVIP.Text = "Leilões VIP";
            this.chkLeiloesVIP.UseVisualStyleBackColor = true;
            // 
            // chkMilan
            // 
            this.chkMilan.AutoSize = true;
            this.chkMilan.Location = new System.Drawing.Point(12, 57);
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
            this.button1.Location = new System.Drawing.Point(186, 401);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa Econômica Federal";
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
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(152, 110);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(109, 20);
            this.dtPicker.TabIndex = 12;
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
            // chkFreitas
            // 
            this.chkFreitas.AutoSize = true;
            this.chkFreitas.Location = new System.Drawing.Point(158, 57);
            this.chkFreitas.Name = "chkFreitas";
            this.chkFreitas.Size = new System.Drawing.Size(93, 17);
            this.chkFreitas.TabIndex = 7;
            this.chkFreitas.Text = "Freitas Leilões";
            this.chkFreitas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZuckermanLimit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkZuckermanNorte);
            this.groupBox2.Controls.Add(this.chkZuckermanCentroOeste);
            this.groupBox2.Controls.Add(this.chkZuckermanNordeste);
            this.groupBox2.Controls.Add(this.chkZuckermanSul);
            this.groupBox2.Controls.Add(this.chkZuckermanRJMGES);
            this.groupBox2.Controls.Add(this.chkZuckermanSP);
            this.groupBox2.Location = new System.Drawing.Point(13, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 143);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zuckerman Leilões";
            // 
            // txtZuckermanLimit
            // 
            this.txtZuckermanLimit.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtZuckermanLimit.Location = new System.Drawing.Point(146, 111);
            this.txtZuckermanLimit.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtZuckermanLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtZuckermanLimit.Name = "txtZuckermanLimit";
            this.txtZuckermanLimit.Size = new System.Drawing.Size(92, 20);
            this.txtZuckermanLimit.TabIndex = 14;
            this.txtZuckermanLimit.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Limitar busca em";
            // 
            // chkZuckermanNorte
            // 
            this.chkZuckermanNorte.AutoSize = true;
            this.chkZuckermanNorte.Location = new System.Drawing.Point(15, 65);
            this.chkZuckermanNorte.Name = "chkZuckermanNorte";
            this.chkZuckermanNorte.Size = new System.Drawing.Size(89, 17);
            this.chkZuckermanNorte.TabIndex = 11;
            this.chkZuckermanNorte.Text = "Região Norte";
            this.chkZuckermanNorte.UseVisualStyleBackColor = true;
            // 
            // chkZuckermanCentroOeste
            // 
            this.chkZuckermanCentroOeste.AutoSize = true;
            this.chkZuckermanCentroOeste.Location = new System.Drawing.Point(15, 87);
            this.chkZuckermanCentroOeste.Name = "chkZuckermanCentroOeste";
            this.chkZuckermanCentroOeste.Size = new System.Drawing.Size(125, 17);
            this.chkZuckermanCentroOeste.TabIndex = 10;
            this.chkZuckermanCentroOeste.Text = "Região Centro-Oeste";
            this.chkZuckermanCentroOeste.UseVisualStyleBackColor = true;
            // 
            // chkZuckermanNordeste
            // 
            this.chkZuckermanNordeste.AutoSize = true;
            this.chkZuckermanNordeste.Location = new System.Drawing.Point(146, 65);
            this.chkZuckermanNordeste.Name = "chkZuckermanNordeste";
            this.chkZuckermanNordeste.Size = new System.Drawing.Size(106, 17);
            this.chkZuckermanNordeste.TabIndex = 9;
            this.chkZuckermanNordeste.Text = "Região Nordeste";
            this.chkZuckermanNordeste.UseVisualStyleBackColor = true;
            // 
            // chkZuckermanSul
            // 
            this.chkZuckermanSul.AutoSize = true;
            this.chkZuckermanSul.Location = new System.Drawing.Point(146, 87);
            this.chkZuckermanSul.Name = "chkZuckermanSul";
            this.chkZuckermanSul.Size = new System.Drawing.Size(78, 17);
            this.chkZuckermanSul.TabIndex = 8;
            this.chkZuckermanSul.Text = "Região Sul";
            this.chkZuckermanSul.UseVisualStyleBackColor = true;
            // 
            // chkZuckermanRJMGES
            // 
            this.chkZuckermanRJMGES.AutoSize = true;
            this.chkZuckermanRJMGES.Location = new System.Drawing.Point(15, 42);
            this.chkZuckermanRJMGES.Name = "chkZuckermanRJMGES";
            this.chkZuckermanRJMGES.Size = new System.Drawing.Size(94, 17);
            this.chkZuckermanRJMGES.TabIndex = 7;
            this.chkZuckermanRJMGES.Text = "RJ + MG + ES";
            this.chkZuckermanRJMGES.UseVisualStyleBackColor = true;
            // 
            // chkZuckermanSP
            // 
            this.chkZuckermanSP.AutoSize = true;
            this.chkZuckermanSP.Location = new System.Drawing.Point(15, 19);
            this.chkZuckermanSP.Name = "chkZuckermanSP";
            this.chkZuckermanSP.Size = new System.Drawing.Size(40, 17);
            this.chkZuckermanSP.TabIndex = 6;
            this.chkZuckermanSP.Text = "SP";
            this.chkZuckermanSP.UseVisualStyleBackColor = true;
            // 
            // chkSodre
            // 
            this.chkSodre.AutoSize = true;
            this.chkSodre.Location = new System.Drawing.Point(12, 80);
            this.chkSodre.Name = "chkSodre";
            this.chkSodre.Size = new System.Drawing.Size(94, 17);
            this.chkSodre.TabIndex = 8;
            this.chkSodre.Text = "Sodre Santoro";
            this.chkSodre.UseVisualStyleBackColor = true;
            this.chkSodre.CheckedChanged += new System.EventHandler(this.chkSodre_CheckedChanged);
            // 
            // SiteSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkSodre);
            this.Controls.Add(this.chkFreitas);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZuckermanLimit)).EndInit();
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
        private System.Windows.Forms.CheckBox chkFreitas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSodre;
        private System.Windows.Forms.NumericUpDown txtZuckermanLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkZuckermanNorte;
        private System.Windows.Forms.CheckBox chkZuckermanCentroOeste;
        private System.Windows.Forms.CheckBox chkZuckermanNordeste;
        private System.Windows.Forms.CheckBox chkZuckermanSul;
        private System.Windows.Forms.CheckBox chkZuckermanRJMGES;
        private System.Windows.Forms.CheckBox chkZuckermanSP;
    }
}