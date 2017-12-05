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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filmes f1 = new Filmes();
            f1.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locacoes locacao = new Locacoes();
            locacao.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucao devolucao = new Devolucao();
            devolucao.Show();
        }
    }
}
