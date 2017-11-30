namespace ProjetoFinal.View
{
    partial class FilmesLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloPagina = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloPagina
            // 
            this.tituloPagina.AutoSize = true;
            this.tituloPagina.Font = new System.Drawing.Font("MV Boli", 22F);
            this.tituloPagina.Location = new System.Drawing.Point(12, 9);
            this.tituloPagina.Name = "tituloPagina";
            this.tituloPagina.Size = new System.Drawing.Size(270, 40);
            this.tituloPagina.TabIndex = 2;
            this.tituloPagina.Text = "Filmes da Locação";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 214);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // FilmesLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tituloPagina);
            this.Name = "FilmesLocacao";
            this.Text = "FilmesLocacao";
            this.Load += new System.EventHandler(this.FilmesLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPagina;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}