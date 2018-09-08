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

            this.Load += SiteSelectionForm_Load;
        }

        private void SiteSelectionForm_Load(object sender, EventArgs e)
        {
            dtPicker.MinDate = DateTime.Now;
            dtPicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm search = new Leiloes.SearchForm();

            if(chkMegaLeiloes.Checked)
                search.searchList.Add(new MegaLeiloesSearch());

            if (chkLeiloesVIP.Checked)
                search.searchList.Add(new VipLeiloesSearch());


            if (chkZuckermanSP.Checked)
                search.searchList.Add(new ZuckermanSearch(new[] { "SP" }, (int)txtZuckermanLimit.Value));

            if (chkZuckermanSul.Checked)
                search.searchList.Add(new ZuckermanSearch(new[] { "RS", "PR", "SC" }, (int)txtZuckermanLimit.Value));

            if (chkZuckermanRJMGES.Checked)
                search.searchList.Add(new ZuckermanSearch(new[] { "RJ", "MG", "ES" }, (int)txtZuckermanLimit.Value));

            if (chkZuckermanCentroOeste.Checked)
                search.searchList.Add(new ZuckermanSearch(new[] { "MT", "GO", "DF", "MS" }, (int)txtZuckermanLimit.Value));

            if (chkZuckermanNorte.Checked)
                search.searchList.Add(new ZuckermanSearch(new[] { "AC", "RO", "AM", "RR", "PA", "AP", "TO" }, (int)txtZuckermanLimit.Value));

            if (chkZuckermanNordeste.Checked)
                search.searchList.Add(new ZuckermanSearch(new[] { "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA" }, (int)txtZuckermanLimit.Value));


            if (chkMilan.Checked)
                search.searchList.Add(new MilanLeiloesSearch());

            if (chkFreitas.Checked)
                search.searchList.Add(new FreitasSearch());

            if (chkSodre.Checked)
                search.searchList.Add(new SodreSantoroSearch());

            if (chkCaixaSP.Checked)
                search.searchList.Add(new CaixaSearch(new[] { "SP" }, dtPicker.Value));

            if (chkCaixaSul.Checked)
                search.searchList.Add(new CaixaSearch(new[] { "RS", "PR", "SC" }, dtPicker.Value));

            if (chkCaixaRJMGES.Checked)
                search.searchList.Add(new CaixaSearch(new[] { "RJ", "MG", "ES" }, dtPicker.Value));

            if (chkCaixaCentroOeste.Checked)
                search.searchList.Add(new CaixaSearch(new[] { "MT", "GO", "DF", "MS" }, dtPicker.Value));

            if (chkCaixaNorte.Checked)
                search.searchList.Add(new CaixaSearch(new[] { "AC", "RO", "AM", "RR", "PA", "AP", "TO" }, dtPicker.Value));

            if (chkCaixaNordeste.Checked)
                search.searchList.Add(new CaixaSearch(new[] { "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA" }, dtPicker.Value));

            this.Close();

            search.ShowDialog();
        }

        private void chkSodre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
