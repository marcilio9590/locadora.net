﻿using System;
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

        public FilmesLocacao()
        {
            InitializeComponent();
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
            LocacaoBusiness locasaoService = new LocacaoBusiness();
            this.dataGridView2.DataSource = locasaoService.getFilmesLocacao(codigoLocacao);
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
                //if(this.dataGridView2.Rows.Count == 2)
                //{
                //    DialogResult confirm = MessageBox.Show("A locação será excluida. Deseja Continuar?", "Exclusão da Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                //    if (confirm.ToString().ToUpper() == "YES")
                //    {
                //        // Chamar exclusao de locacao
                //    }
                //}
                //else
                //{
                    String codigoLocacao = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    String codigoItem = this.dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    String codigoFilme = this.dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if (codigoLocacao.Length != 0 && codigoItem.Length != 0 && codigoFilme.Length != 0)
                    {
                        excluirFilmeLocacao(codigoLocacao, codigoItem, codigoFilme);
                    }
                //}
            }
        }

        public void excluirFilmeLocacao(String codigoLocacao, String codigoItem, String codigoFilme)
        {
            LocacaoBusiness locasaoService = new LocacaoBusiness();
            try
            {
                locasaoService.excluirFilmeLocacao(codigoLocacao, codigoItem, codigoFilme);
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
