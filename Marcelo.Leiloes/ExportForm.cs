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
                StringBuilder sb = new StringBuilder("SITE;LINK EDITAL/LOTE;DATA LEILÃO;LOTE;ENTIDADE;VALOR;UF;MUNICIPIO;BAIRRO;ENDEREÇO;NUM;COMPLEMENTO;CEP;COMPLETA\n");

                progressProgressBar.Maximum = ItemRepository.GetInstance().Count;
                progressProgressBar.Minimum = 0;
                progressProgressBar.Value = 0;

                foreach (var info in ItemRepository.GetInstance())
                {
                    decimal valor;
                    if(decimal.TryParse(info.Valor.Replace("R$", "").Replace(" ", "").Replace(".", ""), out valor))
                    {
                        info.Valor = valor.ToString("N2");
                    }
                    else
                    {
                        info.Valor = "";
                    }

                    sb.AppendLine($@"{info.Site};{info.Url};{info.DtInicio};{info.Cod};{info.Entidade};{(String.IsNullOrEmpty(info.Valor) ? "" : "R$" + info.Valor)};{info.UF};{info.Cidade};{info.Bairro};{info.Endereco};{info.Numero};{info.Complemento};{(String.IsNullOrEmpty(info.CEP) ? "" : Util.Clear(info.CEP).Insert(5, " - "))};{info.InformacoesAdicionais};");

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
