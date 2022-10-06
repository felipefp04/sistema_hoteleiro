namespace Hotel_FFP.Cadastros
{
	partial class frProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frProdutos));
			this.dgvLerDados = new System.Windows.Forms.DataGridView();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbEstoque = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbBuscarNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbDescricao = new System.Windows.Forms.TextBox();
			this.tbValor = new System.Windows.Forms.TextBox();
			this.cbFornecedor = new System.Windows.Forms.ComboBox();
			this.btAdicionarImg = new System.Windows.Forms.Button();
			this.pbImagem = new System.Windows.Forms.PictureBox();
			this.btExcluir = new System.Windows.Forms.Button();
			this.btEditar = new System.Windows.Forms.Button();
			this.btSalvar = new System.Windows.Forms.Button();
			this.btNovo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLerDados
			// 
			this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.Location = new System.Drawing.Point(26, 222);
			this.dgvLerDados.Name = "dgvLerDados";
			this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLerDados.Size = new System.Drawing.Size(716, 150);
			this.dgvLerDados.TabIndex = 22;
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(86, 116);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(100, 20);
			this.tbNome.TabIndex = 14;
			// 
			// tbEstoque
			// 
			this.tbEstoque.Enabled = false;
			this.tbEstoque.Location = new System.Drawing.Point(97, 170);
			this.tbEstoque.Name = "tbEstoque";
			this.tbEstoque.Size = new System.Drawing.Size(100, 20);
			this.tbEstoque.TabIndex = 18;
			this.tbEstoque.TextChanged += new System.EventHandler(this.tbEstoque_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(210, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Fornecedor:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(202, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Descrição:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "Estoque:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nome:";
			// 
			// tbBuscarNome
			// 
			this.tbBuscarNome.Location = new System.Drawing.Point(422, 59);
			this.tbBuscarNome.Name = "tbBuscarNome";
			this.tbBuscarNome.Size = new System.Drawing.Size(100, 20);
			this.tbBuscarNome.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(373, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Buscar:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(382, 119);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 34;
			this.label7.Text = "Valor:";
			// 
			// tbDescricao
			// 
			this.tbDescricao.Enabled = false;
			this.tbDescricao.Location = new System.Drawing.Point(263, 116);
			this.tbDescricao.Name = "tbDescricao";
			this.tbDescricao.Size = new System.Drawing.Size(100, 20);
			this.tbDescricao.TabIndex = 35;
			this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged);
			// 
			// tbValor
			// 
			this.tbValor.Enabled = false;
			this.tbValor.Location = new System.Drawing.Point(422, 116);
			this.tbValor.Name = "tbValor";
			this.tbValor.Size = new System.Drawing.Size(100, 20);
			this.tbValor.TabIndex = 36;
			this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
			// 
			// cbFornecedor
			// 
			this.cbFornecedor.Enabled = false;
			this.cbFornecedor.FormattingEnabled = true;
			this.cbFornecedor.Location = new System.Drawing.Point(280, 169);
			this.cbFornecedor.Name = "cbFornecedor";
			this.cbFornecedor.Size = new System.Drawing.Size(121, 21);
			this.cbFornecedor.TabIndex = 37;
			this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged);
			// 
			// btAdicionarImg
			// 
			this.btAdicionarImg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAdicionarImg.Enabled = false;
			this.btAdicionarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdicionarImg.Location = new System.Drawing.Point(717, 197);
			this.btAdicionarImg.Name = "btAdicionarImg";
			this.btAdicionarImg.Size = new System.Drawing.Size(25, 23);
			this.btAdicionarImg.TabIndex = 39;
			this.btAdicionarImg.Text = "+";
			this.btAdicionarImg.UseVisualStyleBackColor = true;
			this.btAdicionarImg.Click += new System.EventHandler(this.btAdicionarImg_Click);
			// 
			// pbImagem
			// 
			this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
			this.pbImagem.Location = new System.Drawing.Point(555, 59);
			this.pbImagem.Name = "pbImagem";
			this.pbImagem.Size = new System.Drawing.Size(154, 161);
			this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagem.TabIndex = 38;
			this.pbImagem.TabStop = false;
			// 
			// btExcluir
			// 
			this.btExcluir.BackgroundImage = global::Hotel_FFP.Properties.Resources.cancel2;
			this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btExcluir.Enabled = false;
			this.btExcluir.FlatAppearance.BorderSize = 0;
			this.btExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btExcluir.Location = new System.Drawing.Point(527, 390);
			this.btExcluir.Name = "btExcluir";
			this.btExcluir.Size = new System.Drawing.Size(70, 65);
			this.btExcluir.TabIndex = 29;
			this.btExcluir.UseVisualStyleBackColor = true;
			this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
			// 
			// btEditar
			// 
			this.btEditar.BackgroundImage = global::Hotel_FFP.Properties.Resources._353430_checkbox_pen_edit_pencil_icon;
			this.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btEditar.Enabled = false;
			this.btEditar.FlatAppearance.BorderSize = 0;
			this.btEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEditar.Location = new System.Drawing.Point(422, 390);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(70, 65);
			this.btEditar.TabIndex = 27;
			this.btEditar.UseVisualStyleBackColor = true;
			this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
			// 
			// btSalvar
			// 
			this.btSalvar.BackgroundImage = global::Hotel_FFP.Properties.Resources._103408_text_book_icon;
			this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btSalvar.Enabled = false;
			this.btSalvar.FlatAppearance.BorderSize = 0;
			this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSalvar.Location = new System.Drawing.Point(317, 390);
			this.btSalvar.Name = "btSalvar";
			this.btSalvar.Size = new System.Drawing.Size(70, 65);
			this.btSalvar.TabIndex = 26;
			this.btSalvar.UseVisualStyleBackColor = true;
			this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
			// 
			// btNovo
			// 
			this.btNovo.BackgroundImage = global::Hotel_FFP.Properties.Resources.plus;
			this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btNovo.FlatAppearance.BorderSize = 0;
			this.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNovo.Location = new System.Drawing.Point(212, 390);
			this.btNovo.Name = "btNovo";
			this.btNovo.Size = new System.Drawing.Size(70, 65);
			this.btNovo.TabIndex = 24;
			this.btNovo.UseVisualStyleBackColor = true;
			this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
			// 
			// frProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 481);
			this.Controls.Add(this.btAdicionarImg);
			this.Controls.Add(this.pbImagem);
			this.Controls.Add(this.cbFornecedor);
			this.Controls.Add(this.tbValor);
			this.Controls.Add(this.tbDescricao);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btSalvar);
			this.Controls.Add(this.btNovo);
			this.Controls.Add(this.dgvLerDados);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbEstoque);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbBuscarNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frProdutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE PRODUTOS";
			this.Load += new System.EventHandler(this.frProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btExcluir;
		private System.Windows.Forms.Button btEditar;
		private System.Windows.Forms.Button btSalvar;
		private System.Windows.Forms.Button btNovo;
		private System.Windows.Forms.DataGridView dgvLerDados;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.TextBox tbEstoque;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbBuscarNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbDescricao;
		private System.Windows.Forms.TextBox tbValor;
		private System.Windows.Forms.ComboBox cbFornecedor;
		private System.Windows.Forms.PictureBox pbImagem;
		private System.Windows.Forms.Button btAdicionarImg;
	}
}