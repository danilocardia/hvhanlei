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
    public partial class SiteSelectionForm : Form
    {
        public SiteSelectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm search = new Leiloes.SearchForm();

            if(chkMegaLeiloes.Checked)
                search.searchList.Add(new MegaLeiloesSearch());

            if(chkLeiloesVIP.Checked)
                search.searchList.Add(new VipLeiloesSearch());

            if(chkMilan.Checked)
                search.searchList.Add(new MilanLeiloesSearch());

            this.Close();

            search.ShowDialog();
        }
    }
}
