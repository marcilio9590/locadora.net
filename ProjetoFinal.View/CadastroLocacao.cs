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
    public partial class CadastroLocacao : Form
    {
        Business.ClienteBusiness clienteBusiness = new Business.ClienteBusiness();

        Business.FuncionarioBusiness funcionarioBusiness = new Business.FuncionarioBusiness();

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
    }
}
