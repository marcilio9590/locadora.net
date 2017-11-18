namespace ProjetoFinal.View
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_item_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_cod_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_num_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_item_preco = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_item_Sum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Preço";
            // 
            // txb_item_descricao
            // 
            this.txb_item_descricao.Location = new System.Drawing.Point(80, 269);
            this.txb_item_descricao.MaxLength = 50;
            this.txb_item_descricao.Name = "txb_item_descricao";
            this.txb_item_descricao.Size = new System.Drawing.Size(268, 20);
            this.txb_item_descricao.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição";
            // 
            // txb_cod_item
            // 
            this.txb_cod_item.Location = new System.Drawing.Point(80, 247);
            this.txb_cod_item.MaxLength = 20;
            this.txb_cod_item.Name = "txb_cod_item";
            this.txb_cod_item.Size = new System.Drawing.Size(100, 20);
            this.txb_cod_item.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cod. Item";
            // 
            // txb_num_item
            // 
            this.txb_num_item.Location = new System.Drawing.Point(80, 225);
            this.txb_num_item.MaxLength = 11;
            this.txb_num_item.Name = "txb_num_item";
            this.txb_num_item.ReadOnly = true;
            this.txb_num_item.Size = new System.Drawing.Size(100, 20);
            this.txb_num_item.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Item";
            // 
            // txb_item_preco
            // 
            this.txb_item_preco.Location = new System.Drawing.Point(80, 291);
            this.txb_item_preco.MaxLength = 20;
            this.txb_item_preco.Name = "txb_item_preco";
            this.txb_item_preco.Size = new System.Drawing.Size(100, 20);
            this.txb_item_preco.TabIndex = 17;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(635, 328);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(144, 21);
            this.btn_Refresh.TabIndex = 24;
            this.btn_Refresh.Text = "&Refrescar";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(635, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "&Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(635, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "&Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(635, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "&Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(635, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Preço Total :";
            // 
            // txb_item_Sum
            // 
            this.txb_item_Sum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_item_Sum.Location = new System.Drawing.Point(635, 221);
            this.txb_item_Sum.Name = "txb_item_Sum";
            this.txb_item_Sum.ReadOnly = true;
            this.txb_item_Sum.Size = new System.Drawing.Size(143, 23);
            this.txb_item_Sum.TabIndex = 18;
            this.txb_item_Sum.Text = "0.00";
            this.txb_item_Sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_item_Sum);
            this.Controls.Add(this.txb_item_preco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_item_descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_cod_item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_num_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Projeto Final - Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_item_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_cod_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_num_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_item_preco;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_item_Sum;
    }
}

