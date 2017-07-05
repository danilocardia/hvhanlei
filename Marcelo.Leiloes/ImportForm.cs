using Marcelo.Leiloes.Repository;
using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcelo.Leiloes
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Salvar arquivo de extração";
            dialog.DefaultExt = "csv";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = dialog.FileName;
            }
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os leilões armazenados atualmente serão removidos.\nVocê tem certeza que deseja proceguir com a importação?", "Confirmação para remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var sr = new StreamReader(label1.Text, Encoding.UTF8))
                {
                    ItemRepository.GetInstance().RemoveFromFile();
                    ItemRepository.GetInstance().Clear();

                    string data = sr.ReadToEnd();

                    foreach (string line in data.Split('\n'))
                    {
                        var item = ItemModel.FromString(line);

                        if (item != null)
                            ItemRepository.GetInstance().Add(item);
                    }

                    ItemRepository.GetInstance().SaveToFile();
                }

                MessageBox.Show("Leilões importados com sucesso", "Importação finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
