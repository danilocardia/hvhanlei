using Marcelo.Leiloes.Repository;
using Marcelo.Leiloes.Repository.Models;
using Marcelo.Leiloes.Search;
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
    public partial class SearchForm : Form
    {
        public List<AbstractSearch> searchList = new List<Search.AbstractSearch>();
        BackgroundWorker bg = new BackgroundWorker();

        public SearchForm()
        {
            InitializeComponent();

            Load += SearchForm_Load;
            bg.DoWork += Bg_DoWork;
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            statusLabel.Text = "Iniciando buscas...";
            
            ItemRepository.GetInstance().Clear();

            foreach (var search in searchList)
            {
                search.OnItemFinished += Search_OnItemFinished;

                search.Process();
            }

            ItemRepository.GetInstance().RemoveFromFile();
            ItemRepository.GetInstance().SaveToFile();

            this.Invoke(new MethodInvoker(delegate
            {
                if (MessageBox.Show(String.Format("{0} itens foram extraídos.\nDeseja exportá-los agora?", processedItems), "Exportação dos resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExportForm exportForm = new ExportForm();
                    exportForm.ShowDialog();
                }

                this.Close();
            }));
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            bg.RunWorkerAsync();
        }

        private int processedItems = 0;
        private void Search_OnItemFinished(ItemModel item)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                statusLabel.Text = String.Format("Processados {0} itens de {1} - {2}", ++processedItems, item.Site, DateTime.Now.ToString("HH:mm:ss"));
            }));

            item.Clear();
            ItemRepository.GetInstance().Add(item);
        }
    }
}
