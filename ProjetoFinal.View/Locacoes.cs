using ProjetoFinal.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.View
{
    public partial class Locacoes : Form
    {
        public Locacoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroLocacao cadLocacao = new CadastroLocacao();
            cadLocacao.Show();
        }

        private void Locacoes_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            LocacaoBusiness locasaoService = new LocacaoBusiness();
            this.dataGridView1.DataSource = locasaoService.GetItens();
        }
    }
}
