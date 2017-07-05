namespace Marcelo.Leiloes
{
    partial class ItemsListForm
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
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarAlteraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGridView.Location = new System.Drawing.Point(0, 24);
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.Size = new System.Drawing.Size(565, 437);
            this.ItemsGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarAlteraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarAlteraçõesToolStripMenuItem
            // 
            this.salvarAlteraçõesToolStripMenuItem.Name = "salvarAlteraçõesToolStripMenuItem";
            this.salvarAlteraçõesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.salvarAlteraçõesToolStripMenuItem.Text = "Salvar e sair";
            this.salvarAlteraçõesToolStripMenuItem.Click += new System.EventHandler(this.salvarAlteraçõesToolStripMenuItem_Click);
            // 
            // ItemsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 461);
            this.Controls.Add(this.ItemsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ItemsListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listagem dos leilões armazenados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarAlteraçõesToolStripMenuItem;
    }
}