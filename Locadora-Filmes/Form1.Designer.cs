namespace Locadora_Filmes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linkFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.linkClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.linkFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLocDev = new System.Windows.Forms.ToolStripMenuItem();
            this.linkHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkHome,
            this.linkFilmes,
            this.linkClientes,
            this.linkFuncionarios,
            this.linkLocDev});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // linkFilmes
            // 
            this.linkFilmes.Name = "linkFilmes";
            this.linkFilmes.Size = new System.Drawing.Size(53, 20);
            this.linkFilmes.Text = "Filmes";
            // 
            // linkClientes
            // 
            this.linkClientes.Name = "linkClientes";
            this.linkClientes.Size = new System.Drawing.Size(61, 20);
            this.linkClientes.Text = "Clientes";
            // 
            // linkFuncionarios
            // 
            this.linkFuncionarios.Name = "linkFuncionarios";
            this.linkFuncionarios.Size = new System.Drawing.Size(82, 20);
            this.linkFuncionarios.Text = "Funcionário";
            // 
            // linkLocDev
            // 
            this.linkLocDev.Name = "linkLocDev";
            this.linkLocDev.Size = new System.Drawing.Size(130, 20);
            this.linkLocDev.Text = "Locação / Devolução";
            // 
            // linkHome
            // 
            this.linkHome.Name = "linkHome";
            this.linkHome.Size = new System.Drawing.Size(52, 20);
            this.linkHome.Text = "Home";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 501);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestão de Locadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linkHome;
        private System.Windows.Forms.ToolStripMenuItem linkFilmes;
        private System.Windows.Forms.ToolStripMenuItem linkClientes;
        private System.Windows.Forms.ToolStripMenuItem linkFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem linkLocDev;
    }
}

