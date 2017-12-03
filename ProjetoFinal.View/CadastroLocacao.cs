using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Entidades;

namespace ProjetoFinal.View
{
    public partial class CadastroLocacao : Form
    {
        Business.ClienteBusiness clienteBusiness = new Business.ClienteBusiness();

        Business.FuncionarioBusiness funcionarioBusiness = new Business.FuncionarioBusiness();

        Business.FilmesBusiness filmesBusiness = new Business.FilmesBusiness();

        Business.LocacaoBusiness locacaoBusiness = new Business.LocacaoBusiness();

        List<Entidades.Filmes> filmesAdicionados = new List<Entidades.Filmes>(0);

        public CadastroLocacao()
        {
            InitializeComponent();
        }

        private void pesquisarCliente(object sender, EventArgs e)
        {
            Entidades.Cliente c = new Entidades.Cliente();
            String codigo = tbCodCliente.Text;
            try
            {
                c = clienteBusiness.buscarCliente(codigo);
                if(c != null)
                {
                    tbCodCliente.Enabled = false;
                    tbNomeCliente.Text = c.nome;
                    ativarBotaoCadastrar();
                }
                else
                {
                    MessageBox.Show("Código inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisarFuncionario(object sender, EventArgs e)
        {
            Entidades.Funcionario c = new Entidades.Funcionario();
            String codigo = tbCodFuncionario.Text;
            try
            {
                c = funcionarioBusiness.buscarFuncionario(codigo);
                if (c != null)
                {
                    tbCodFuncionario.Enabled = false;
                    tbNomeFuncionario.Text = c.nome;
                    ativarBotaoCadastrar();
                }
                else
                {
                    MessageBox.Show("Código inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adicionarFilme(object sender, EventArgs e)
        {
            Entidades.Filmes f = new Entidades.Filmes();
            String codigoFilme = tbCodFilme.Text;
                try
            {
                f = filmesBusiness.buscarFilme(codigoFilme);
                if (f != null)
                {
                    if (verificarSeFilmeJaExiste(f))
                    {
                        MessageBox.Show("Filme já adicionado.");
                    }
                    else
                    {
                        var source = new BindingSource();
                        tbCodFilme.Text = "";
                        this.filmesAdicionados.Add(f);
                        source.DataSource = this.filmesAdicionados;
                        this.gridFilmes.DataSource = source;
                        desativarColunasGridFilmes();
                        ativarBotaoCadastrar();
                        atualizarTotal(f);
                    }
                }
                else
                {
                    MessageBox.Show("Código inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void atualizarTotal(Entidades.Filmes f)
        {
            if(this.tbTotal.Text != String.Empty)
            {
                Double result = Double.Parse(this.tbTotal.Text) + f.preco;
                this.tbTotal.Text = result.ToString();
            }
            else
            {
                this.tbTotal.Text = f.preco.ToString();
            }
        }

        private void ativarBotaoCadastrar()
        {
            if (this.tbCodCliente.Text != String.Empty && this.tbNomeCliente.Text != String.Empty
                && this.tbCodFuncionario.Text != String.Empty && this.tbCodFuncionario.Text != String.Empty
                && this.filmesAdicionados.Any())
            {
                this.btnCadastrarLocacao.Enabled = true;
            }
        }

        private bool verificarSeFilmeJaExiste(Entidades.Filmes f)
        {
            bool retorno = false;
            foreach (Entidades.Filmes item in this.filmesAdicionados)
            {
                if (item.codigo.Equals(f.codigo))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        private void desativarColunasGridFilmes()
        {
            this.gridFilmes.Columns[0].ReadOnly = true;
            this.gridFilmes.Columns[1].ReadOnly = true;
            this.gridFilmes.Columns[2].ReadOnly = true;
            this.gridFilmes.Columns[3].ReadOnly = true;
            this.gridFilmes.Columns[4].ReadOnly = true;
        }

        private void cadastrarLocacao(object sender, EventArgs e)
        {
            Entidades.Locacao locacao = new Locacao();
            locacao.cliente.codigoCliente = long.Parse(this.tbCodCliente.Text);
            locacao.funcionario.codigoFuncionario = long.Parse(this.tbCodFuncionario.Text);
            locacao.total = Double.Parse(this.tbTotal.Text);
            locacao.data = new TimeSpan();
            locacao.filmes = this.filmesAdicionados;
            try
            {
                this.locacaoBusiness.cadastrarLocacao(locacao);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
