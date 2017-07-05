using Marcelo.Leiloes.Repository;
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
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Salvar arquivo de extração";
            dialog.DefaultExt = "csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = dialog.FileName;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerAsync();

            MessageBox.Show("Exportação concluída!", "Resultado da exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                StringBuilder sb = new StringBuilder("SITE;LINK EDITAL;DATA LEILÃO;ENTIDADE;VALOR;UF;MUNICIPIO;ENDEREÇO;CEP;FALHA\n");

                progressProgressBar.Maximum = ItemRepository.GetInstance().Count;
                progressProgressBar.Minimum = 0;
                progressProgressBar.Value = 0;

                foreach (var info in ItemRepository.GetInstance())
                {
                    sb.AppendLine(String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};",
                        info.Site,
                        info.Url,
                        Util.Clean(info.DtInicio),
                        Util.Clean(info.Entidade),
                        Util.Clean(info.Valor),
                        Util.Clean(info.UF),
                        Util.Clean(info.Cidade),
                        Util.Clean(info.Endereco),
                        String.IsNullOrEmpty(info.CEP) ? "" : Util.Clean(info.CEP).Insert(5, "-"),
                        info.Falha ? "FALHA" : ""));

                    progressProgressBar.Value++;
                }

                using (StreamWriter outputFile = new StreamWriter(label1.Text, false, Encoding.UTF8))
                {
                    outputFile.Write(sb.ToString());
                }
            }));
        }        
    }
}
