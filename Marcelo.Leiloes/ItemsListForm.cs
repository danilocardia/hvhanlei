using Marcelo.Leiloes.Repository;
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
    public partial class ItemsListForm : Form
    {
        public ItemsListForm()
        {
            InitializeComponent();
        }
       

        private void ItemsListForm_Load(object sender, EventArgs e)
        {
            ItemsGridView.DataSource = ItemRepository.GetInstance();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }

        private void salvarAlteraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemRepository.GetInstance().SaveToFile();
            this.Close();
        }
    }
}
