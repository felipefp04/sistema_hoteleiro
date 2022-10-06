namespace Hotel_FFP.Cadastros
{
	partial class frUsuarios
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
			this.cbCargo = new System.Windows.Forms.ComboBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbBuscarNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbSenha = new System.Windows.Forms.TextBox();
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
			this.btExcluir.Location = new System.Drawing.Point(410, 323);
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
			this.btEditar.Location = new System.Drawing.Point(305, 323);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(70, 65);
			this.btEditar.TabIndex = 8;
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
			this.btSalvar.Location = new System.Drawing.Point(200, 323);
			this.btSalvar.Name = "btSalvar";
			this.btSalvar.Size = new System.Drawing.Size(70, 65);
			this.btSalvar.TabIndex = 7;
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
			this.btNovo.Location = new System.Drawing.Point(95, 323);
			this.btNovo.Name = "btNovo";
			this.btNovo.Size = new System.Drawing.Size(70, 65);
			this.btNovo.TabIndex = 6;
			this.btNovo.UseVisualStyleBackColor = true;
			this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
			// 
			// dgvLerDados
			// 
			this.dgvLerDados.AllowUserToAddRows = false;
			this.dgvLerDados.AllowUserToDeleteRows = false;
			this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.Location = new System.Drawing.Point(81, 167);
			this.dgvLerDados.Name = "dgvLerDados";
			this.dgvLerDados.ReadOnly = true;
			this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLerDados.Size = new System.Drawing.Size(415, 150);
			this.dgvLerDados.TabIndex = 5;
			this.dgvLerDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellClick);
			// 
			// cbCargo
			// 
			this.cbCargo.Enabled = false;
			this.cbCargo.FormattingEnabled = true;
			this.cbCargo.Location = new System.Drawing.Point(375, 93);
			this.cbCargo.Name = "cbCargo";
			this.cbCargo.Size = new System.Drawing.Size(121, 21);
			this.cbCargo.TabIndex = 2;
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(130, 93);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(100, 20);
			this.tbNome.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(331, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Cargo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nome:";
			// 
			// tbBuscarNome
			// 
			this.tbBuscarNome.Location = new System.Drawing.Point(257, 33);
			this.tbBuscarNome.Name = "tbBuscarNome";
			this.tbBuscarNome.Size = new System.Drawing.Size(100, 20);
			this.tbBuscarNome.TabIndex = 0;
			this.tbBuscarNome.TextChanged += new System.EventHandler(this.tbBuscarNome_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(208, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Buscar:";
			// 
			// tbUsuario
			// 
			this.tbUsuario.Enabled = false;
			this.tbUsuario.Location = new System.Drawing.Point(130, 140);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(100, 20);
			this.tbUsuario.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(78, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Usuário:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(349, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 36;
			this.label4.Text = "Senha:";
			// 
			// tbSenha
			// 
			this.tbSenha.Enabled = false;
			this.tbSenha.Location = new System.Drawing.Point(396, 140);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.Size = new System.Drawing.Size(100, 20);
			this.tbSenha.TabIndex = 4;
			// 
			// frUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(576, 429);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbUsuario);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btSalvar);
			this.Controls.Add(this.btNovo);
			this.Controls.Add(this.dgvLerDados);
			this.Controls.Add(this.cbCargo);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbBuscarNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE USUÁRIOS";
			this.Load += new System.EventHandler(this.frUsuarios_Load);
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
		private System.Windows.Forms.ComboBox cbCargo;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbBuscarNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbSenha;
	}
}