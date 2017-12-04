using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Business;

namespace ProjetoFinal.View
{
    public partial class FilmesLocacao : Form
    {
        public String codigoLocacao { get; set; }

        LocacaoBusiness locacaoBusiness = new LocacaoBusiness();

        FilmesBusiness filmesBusiness = new FilmesBusiness();

        Locacoes locacaoView;


        public FilmesLocacao(Locacoes loc)
        {
            InitializeComponent();
            locacaoView = loc;
        }

        private void FilmesLocacao_Load(object sender, EventArgs e)
        {
            refreshGrid();
            montarTitulo();
            bloquearCampos();
        }

        private void bloquearCampos()
        {
            this.dataGridView2.Columns[0].ReadOnly = true;
            this.dataGridView2.Columns[1].ReadOnly = true;
            this.dataGridView2.Columns[2].ReadOnly = true;
            this.dataGridView2.Columns[3].ReadOnly = true;
            this.dataGridView2.Columns[4].ReadOnly = true;
        }

        private void montarTitulo()
        {
            this.tituloPagina.Text += " - " + this.codigoLocacao;
        }

        private void refreshGrid()
        {
            this.dataGridView2.DataSource = locacaoBusiness.getFilmesLocacao(codigoLocacao);
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            {
                btnExcluir.Name = "btnExcluirFilme";
                btnExcluir.HeaderText = "Remover";
                btnExcluir.Text = "Remover Filme";
                btnExcluir.UseColumnTextForButtonValue = true;
                this.dataGridView2.Columns.Add(btnExcluir);
            }

        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if(this.dataGridView2.Rows.Count == 2)
                {
                    DialogResult confirm = MessageBox.Show("A locação será excluida. Deseja Continuar?", "Exclusão da Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        List<String> lista = new List<string>(0);
                        lista.Add(this.codigoLocacao);
                        try
                        {
                            this.locacaoBusiness.excluirLocacao(lista);
                            MessageBox.Show("Locação Excluida");
                            this.locacaoView.refreshGrid();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                else
                {
                    String codigoLocacao = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    String codigoItem = this.dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    String codigoFilme = this.dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if (codigoLocacao.Length != 0 && codigoItem.Length != 0 && codigoFilme.Length != 0)
                    {
                        excluirFilmeLocacao(codigoLocacao, codigoItem, codigoFilme);
                    }
                }
            }
        }

        public void excluirFilmeLocacao(String codigoLocacao, String codigoItem, String codigoFilme)
        {
            try
            {
                locacaoBusiness.excluirFilmeLocacao(codigoLocacao, codigoItem, codigoFilme);
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void adicionarFilme(object sender, EventArgs e)
        {
            List<Entidades.Filmes> lista = new List<Entidades.Filmes>(0);
            Entidades.Filmes f = new Entidades.Filmes();
            f.codigo = this.tbCodigoFilme.Text;
            lista.Add(f);
            long codigo = long.Parse(this.codigoLocacao);
            try
            {
                Entidades.Filmes filme = this.filmesBusiness.buscarFilme(this.tbCodigoFilme.Text);
                if(filme != null)
                {
                    if (filme.status == "Disponível")
                    {
                        if (verificarSeFilmeJaExiste(filme))
                        {
                            MessageBox.Show("Filmes já consta na locação");
                        }
                        else
                        {
                            this.locacaoBusiness.inserirFilmesLocacao(codigo,lista);
                            this.locacaoBusiness.atualizarTotal(this.codigoLocacao, codigo.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este Filme já encontra-se alugado.");
                    }
                }
                else
                {
                    MessageBox.Show("Código inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool verificarSeFilmeJaExiste(Entidades.Filmes f)
        {
            bool retorno = false;
            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {
                if (row.Cells[2].Value != null && f.codigo.Equals(row.Cells[2].Value.ToString())){
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
