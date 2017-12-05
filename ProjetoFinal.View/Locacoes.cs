using ProjetoFinal.Business;
using ProjetoFinal.Entidades;
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
        LocacaoBusiness locasaoService = new LocacaoBusiness();

        ClienteBusiness clienteBusiness = new ClienteBusiness();

        public Locacoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroLocacao cadLocacao = new CadastroLocacao(this);
            cadLocacao.Show();
        }

        private void Locacoes_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        public void refreshGrid()
        {
            this.dataGridView1.DataSource = locasaoService.GetItens(false);
            ajustarGrid();
            percorrerResultadoGridView();
        }

        private void ajustarGrid()
        {
            if (!this.dataGridView1.Columns.Contains("btnVerFilmes"))
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "btnVerFilmes";
                    button.HeaderText = "Filmes";
                    button.Text = "Gerenciar Filmes";
                    button.UseColumnTextForButtonValue = true;
                    this.dataGridView1.Columns.Add(button);
                }
            }
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[5].ReadOnly = true;

        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                chamarViewFilmesLocacao(e);
            }
        }

        private void chamarViewFilmesLocacao(DataGridViewCellEventArgs e)
        {
            String codigo = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (codigo.Length != 0)
            {
                FilmesLocacao filmesView = new FilmesLocacao(this);
                filmesView.codigoLocacao = codigo;
                filmesView.Show();
            }
        }

        private void updateValueGridView(object sender, DataGridViewCellEventArgs e)
        {
            String codigo = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            String value = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
       
            if(e.ColumnIndex == 1)
            {
                buscarPreencherCliente(e, value);
            }
        }

        private void buscarPreencherCliente(DataGridViewCellEventArgs e, string value)
        {
            Cliente c = this.clienteBusiness.buscarCliente(value);
            if (c != null)
            {
                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = c.nome;
            }
            else
            {
                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = "";
            }
        }

        private void percorrerResultadoGridView()
        {
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                preencherColunaStatus(this.dataGridView1.Rows[i]);
            }
        }

        private void preencherColunaStatus(DataGridViewRow linha)
        {
            if(linha.Cells[4].Value != null)
            {
                if(linha.Cells[4].Value.ToString() == "0")
                {
                    linha.Cells[4].ToolTipText = "Em Aberto";
                }
                else
                {
                    linha.Cells[4].ToolTipText = "Entregue";
                }
            }
        }

        private void linhaSelecionada(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count != 0)
            {
                this.btnExcluir.Enabled = true;
            }
        }

        private void excluirLocacao(object sender, EventArgs e)
        {
            List<String> lista = new List<string>(0);
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                lista.Add(row.Cells[0].Value.ToString());
            }
            try
            {
                this.locasaoService.excluirLocacao(lista);
                MessageBox.Show("Locação excluida");
                refreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
