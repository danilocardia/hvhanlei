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
    public partial class CEPAdjustForm : Form
    {
        public CEPAdjustForm()
        {
            InitializeComponent();
        }

        private void CEPAdjustForm_Load(object sender, EventArgs e)
        {

        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerAsync();

            MessageBox.Show("Preenchimento dos CEPs concluido!", "Resultado do preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                var list = ItemRepository.GetInstance().Where(i => String.IsNullOrEmpty(i.CEP));
                progressProgressBar.Maximum = list.Count();
                progressProgressBar.Minimum = 0;
                progressProgressBar.Value = 0;

                foreach (var info in list)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        info.CEP = CEPRepository.GetBy(info.Endereco + info.Cidade, info.Cidade);
                        progressProgressBar.Value++;
                    }));
                }

                ItemRepository.GetInstance().SaveToFile();
            }));
        }
    }
}
