namespace Hotel_FFP.Cadastros
{
	partial class frFornecedores
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
			this.btExcluir = new System.Windows.Forms.Button();
			this.btEditar = new System.Windows.Forms.Button();
			this.btSalvar = new System.Windows.Forms.Button();
			this.btNovo = new System.Windows.Forms.Button();
			this.dgvLerDados = new System.Windows.Forms.DataGridView();
			this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbBuscarNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btExcluir
			// 
			this.btExcluir.BackgroundImage = global::Hotel_FFP.Properties.Resources.cancel2;
			this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btExcluir.Enabled = false;
			this.btExcluir.FlatAppearance.BorderSize = 0;
			this.btExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btExcluir.Location = new System.Drawing.Point(438, 412);
			this.btExcluir.Name = "btExcluir";
			this.btExcluir.Size = new System.Drawing.Size(70, 65);
			this.btExcluir.TabIndex = 9;
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
			this.btEditar.Location = new System.Drawing.Point(333, 412);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(70, 65);
			this.btEditar.TabIndex = 8;
			this.btEditar.UseVisualStyleBackColor = true;
			this.btEditar.Click += new System.EventHandler(this.btEditar_Click_1);
			// 
			// btSalvar
			// 
			this.btSalvar.BackgroundImage = global::Hotel_FFP.Properties.Resources._103408_text_book_icon;
			this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btSalvar.Enabled = false;
			this.btSalvar.FlatAppearance.BorderSize = 0;
			this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSalvar.Location = new System.Drawing.Point(228, 412);
			this.btSalvar.Name = "btSalvar";
			this.btSalvar.Size = new System.Drawing.Size(70, 65);
			this.btSalvar.TabIndex = 7;
			this.btSalvar.UseVisualStyleBackColor = true;
			this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click_1);
			// 
			// btNovo
			// 
			this.btNovo.BackgroundImage = global::Hotel_FFP.Properties.Resources.plus;
			this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btNovo.FlatAppearance.BorderSize = 0;
			this.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNovo.Location = new System.Drawing.Point(123, 412);
			this.btNovo.Name = "btNovo";
			this.btNovo.Size = new System.Drawing.Size(70, 65);
			this.btNovo.TabIndex = 6;
			this.btNovo.UseVisualStyleBackColor = true;
			this.btNovo.Click += new System.EventHandler(this.btNovo_Click_1);
			// 
			// dgvLerDados
			// 
			this.dgvLerDados.AllowUserToAddRows = false;
			this.dgvLerDados.AllowUserToDeleteRows = false;
			this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.Location = new System.Drawing.Point(109, 256);
			this.dgvLerDados.Name = "dgvLerDados";
			this.dgvLerDados.ReadOnly = true;
			this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLerDados.Size = new System.Drawing.Size(415, 150);
			this.dgvLerDados.TabIndex = 5;
			this.dgvLerDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellContentClick);
			// 
			// mtbTelefone
			// 
			this.mtbTelefone.Enabled = false;
			this.mtbTelefone.Location = new System.Drawing.Point(390, 218);
			this.mtbTelefone.Mask = "(99) 00000-0000";
			this.mtbTelefone.Name = "mtbTelefone";
			this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
			this.mtbTelefone.TabIndex = 3;
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(198, 173);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(100, 20);
			this.tbNome.TabIndex = 0;
			// 
			// tbEndereco
			// 
			this.tbEndereco.Enabled = false;
			this.tbEndereco.Location = new System.Drawing.Point(198, 218);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(100, 20);
			this.tbEndereco.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(320, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Telefone:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(136, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "Endereço:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nome:";
			// 
			// tbBuscarNome
			// 
			this.tbBuscarNome.Location = new System.Drawing.Point(390, 173);
			this.tbBuscarNome.Name = "tbBuscarNome";
			this.tbBuscarNome.Size = new System.Drawing.Size(100, 20);
			this.tbBuscarNome.TabIndex = 10;
			this.tbBuscarNome.TextChanged += new System.EventHandler(this.tbBuscarNome_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(341, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Buscar:";
			// 
			// frFornecedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 501);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btSalvar);
			this.Controls.Add(this.btNovo);
			this.Controls.Add(this.dgvLerDados);
			this.Controls.Add(this.mtbTelefone);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbEndereco);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbBuscarNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frFornecedores";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.Load += new System.EventHandler(this.frFornecedores_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btExcluir;
		private System.Windows.Forms.Button btEditar;
		private System.Windows.Forms.Button btSalvar;
		private System.Windows.Forms.Button btNovo;
		private System.Windows.Forms.DataGridView dgvLerDados;
		private System.Windows.Forms.MaskedTextBox mtbTelefone;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.TextBox tbEndereco;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbBuscarNome;
		private System.Windows.Forms.Label label1;
	}
}