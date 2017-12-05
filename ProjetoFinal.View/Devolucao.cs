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
    public partial class Devolucao : Form
    {
        LocacaoBusiness locasaoService = new LocacaoBusiness();

        public Devolucao()
        {
            InitializeComponent();
        }
        
        private void Devolucao_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        public void refreshGrid()
        {
            this.dataGridView1.DataSource = locasaoService.GetItens(true);
            ajustarGrid();
            percorrerResultadoGridView();
        }

        private void ajustarGrid()
        {
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[5].ReadOnly = true;

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
            if (linha.Cells[4].Value != null)
            {
                if (linha.Cells[4].Value.ToString() == "0")
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
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                this.btnDevolver.Enabled = true;
            }
        }

        private void clickGrid(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                this.btnDevolver.Enabled = false;
            }
        }

        private void realizarDevolução(object sender, EventArgs e)
        {
            List<String> lista = new List<String>(0);
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                lista.Add(row.Cells[0].Value.ToString());
                MessageBox.Show("Locação Devolvida");
                refreshGrid();
            }
            try
            {
                this.locasaoService.realizarDevolucao(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
