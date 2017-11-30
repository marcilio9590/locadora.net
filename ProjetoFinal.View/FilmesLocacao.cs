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
        }

        private void montarTitulo()
        {
            this.tituloPagina.Text += " " + this.codigoLocacao;
        }

        private void refreshGrid()
        {
            LocacaoBusiness locasaoService = new LocacaoBusiness();
            this.dataGridView2.DataSource = locasaoService.getFilmesLocacao(codigoLocacao);
            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //{
            //    button.Name = "btnVerFilmes";
            //    button.HeaderText = "Filmes";
            //    button.Text = "Gerenciar Filmes";
            //    button.UseColumnTextForButtonValue = true;
            //    this.dataGridView2.Columns.Add(button);
            //}

        }
    }
}
