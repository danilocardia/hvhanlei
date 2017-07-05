using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcelo.Leiloes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buscarNovosLeilõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiteSelectionForm selection = new Leiloes.SiteSelectionForm();
            selection.ShowDialog();
        }

        private void importarDoArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
        }

        private void listarLeilõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsListForm listForm = new Leiloes.ItemsListForm();
            listForm.ShowDialog();
        }

        private void preenchimentoDeCEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEPAdjustForm adjustForm = new CEPAdjustForm();
            adjustForm.ShowDialog();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new Leiloes.ExportForm();
            exportForm.ShowDialog();
        }
    }
}