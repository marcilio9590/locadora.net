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
    public partial class Filmes : Form
    {

        private Int32 catchRowIndex;
        public Filmes()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        /// <summary>
        /// Método responsável em atualizar o Grid View da tela
        /// </summary>
        private void RefreshDataGrid()
        {
            FilmesBusiness objIB = new FilmesBusiness();
            dataGridView1.DataSource = objIB.GetItens();
        }

        /// <summary>
        ///Método que será executado quando o usuário clicar no botão atualizar
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Método que será executado quando usuário clicar no botão adicionar
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria o objeto item e adiciona as informações dos campos de textos no novo objeto
                Entidades.Filmes it = new Entidades.Filmes();
                it.codigo = txb_cod_item.Text;
                it.descricao = txb_item_descricao.Text;
                it.preco = Double.Parse(txb_item_preco.Text);

                //Cria um objeto de Item Bussines para chamar o método de inserção do item na camada de negócios
                FilmesBusiness ib = new FilmesBusiness();
                ib.SetItem(it);

                //Limpa os campos de texto da tela
                txb_cod_item.Clear();
                txb_item_descricao.Clear();
                txb_item_preco.Clear();

                //Atualiza o grid view
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        /// <summary>
        /// Método que será executado quando o usuário clicar no botão refrescar
        /// </summary>
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        /// <summary>
        /// Método que será executado quando o usuário clicar em uma linha do grid view
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pega a linha que foi selecionada no grid view
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //Pega as informações da linha selecionada e coloca nos campos de texto da tela
                txb_num_item.Text = row.Cells[0].Value.ToString();
                txb_cod_item.Text = row.Cells[1].Value.ToString();
                txb_item_descricao.Text = row.Cells[2].Value.ToString();
                txb_item_preco.Text = row.Cells[3].Value.ToString();
            }

            //Habilita os botões de atualizar e Remover
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
