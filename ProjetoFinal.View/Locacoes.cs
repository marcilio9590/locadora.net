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
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btnVerFilmes";
                button.HeaderText = "Filmes";
                button.Text = "Gerenciar Filmes";
                button.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(button);
            }

        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                String codigo = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (codigo.Length != 0)
                {
                    FilmesLocacao filmesView = new FilmesLocacao();
                    filmesView.codigoLocacao = codigo;
                    filmesView.Show();
    }
            }
        }
    }
}
