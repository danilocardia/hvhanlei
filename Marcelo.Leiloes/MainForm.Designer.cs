namespace Marcelo.Leiloes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leilõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLeilõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarNovosLeilõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDoArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preenchimentoDeCEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leilõesToolStripMenuItem,
            this.correçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leilõesToolStripMenuItem
            // 
            this.leilõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarLeilõesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.buscarNovosLeilõesToolStripMenuItem,
            this.importarDoArquivoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exportarToolStripMenuItem});
            this.leilõesToolStripMenuItem.Name = "leilõesToolStripMenuItem";
            this.leilõesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.leilõesToolStripMenuItem.Text = "Leilões";
            // 
            // listarLeilõesToolStripMenuItem
            // 
            this.listarLeilõesToolStripMenuItem.Name = "listarLeilõesToolStripMenuItem";
            this.listarLeilõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarLeilõesToolStripMenuItem.Text = "Listar leilões";
            this.listarLeilõesToolStripMenuItem.Click += new System.EventHandler(this.listarLeilõesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // buscarNovosLeilõesToolStripMenuItem
            // 
            this.buscarNovosLeilõesToolStripMenuItem.Name = "buscarNovosLeilõesToolStripMenuItem";
            this.buscarNovosLeilõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarNovosLeilõesToolStripMenuItem.Text = "Buscar novos leilões";
            this.buscarNovosLeilõesToolStripMenuItem.Click += new System.EventHandler(this.buscarNovosLeilõesToolStripMenuItem_Click);
            // 
            // importarDoArquivoToolStripMenuItem
            // 
            this.importarDoArquivoToolStripMenuItem.Name = "importarDoArquivoToolStripMenuItem";
            this.importarDoArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarDoArquivoToolStripMenuItem.Text = "Importar do arquivo";
            this.importarDoArquivoToolStripMenuItem.Click += new System.EventHandler(this.importarDoArquivoToolStripMenuItem_Click);
            // 
            // correçãoToolStripMenuItem
            // 
            this.correçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preenchimentoDeCEPToolStripMenuItem});
            this.correçãoToolStripMenuItem.Name = "correçãoToolStripMenuItem";
            this.correçãoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.correçãoToolStripMenuItem.Text = "Correção";
            // 
            // preenchimentoDeCEPToolStripMenuItem
            // 
            this.preenchimentoDeCEPToolStripMenuItem.Name = "preenchimentoDeCEPToolStripMenuItem";
            this.preenchimentoDeCEPToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.preenchimentoDeCEPToolStripMenuItem.Text = "Preenchimento de CEP";
            this.preenchimentoDeCEPToolStripMenuItem.Click += new System.EventHandler(this.preenchimentoDeCEPToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 365);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Utilitãrio de automação - Extração de leilões";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem leilõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLeilõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarNovosLeilõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preenchimentoDeCEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDoArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
    }
}

