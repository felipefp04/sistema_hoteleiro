namespace Hotel_FFP.Cadastros
{
	partial class frFuncionarios
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
			this.label1 = new System.Windows.Forms.Label();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.rbCPF = new System.Windows.Forms.RadioButton();
			this.tbBuscarNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.cbCargo = new System.Windows.Forms.ComboBox();
			this.mtbBuscarCPF = new System.Windows.Forms.MaskedTextBox();
			this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
			this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
			this.dgvLerDados = new System.Windows.Forms.DataGridView();
			this.btExcluir = new System.Windows.Forms.Button();
			this.btEditar = new System.Windows.Forms.Button();
			this.btSalvar = new System.Windows.Forms.Button();
			this.btNovo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscar:";
			// 
			// rbNome
			// 
			this.rbNome.AutoSize = true;
			this.rbNome.Location = new System.Drawing.Point(248, 26);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(53, 17);
			this.rbNome.TabIndex = 1;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
			// 
			// rbCPF
			// 
			this.rbCPF.AutoSize = true;
			this.rbCPF.Location = new System.Drawing.Point(331, 26);
			this.rbCPF.Name = "rbCPF";
			this.rbCPF.Size = new System.Drawing.Size(45, 17);
			this.rbCPF.TabIndex = 2;
			this.rbCPF.TabStop = true;
			this.rbCPF.Text = "CPF";
			this.rbCPF.UseVisualStyleBackColor = true;
			this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
			// 
			// tbBuscarNome
			// 
			this.tbBuscarNome.Location = new System.Drawing.Point(402, 25);
			this.tbBuscarNome.Name = "tbBuscarNome";
			this.tbBuscarNome.Size = new System.Drawing.Size(100, 20);
			this.tbBuscarNome.TabIndex = 10;
			this.tbBuscarNome.TextChanged += new System.EventHandler(this.tbBuscarNome_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(84, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Endereço:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(244, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "CPF:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(252, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Telefone:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(84, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Cargo:";
			// 
			// tbEndereco
			// 
			this.tbEndereco.Enabled = false;
			this.tbEndereco.Location = new System.Drawing.Point(146, 171);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(100, 20);
			this.tbEndereco.TabIndex = 2;
			// 
			// tbNome
			// 
			this.tbNome.Enabled = false;
			this.tbNome.Location = new System.Drawing.Point(128, 117);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(100, 20);
			this.tbNome.TabIndex = 0;
			// 
			// cbCargo
			// 
			this.cbCargo.Enabled = false;
			this.cbCargo.FormattingEnabled = true;
			this.cbCargo.Location = new System.Drawing.Point(128, 228);
			this.cbCargo.Name = "cbCargo";
			this.cbCargo.Size = new System.Drawing.Size(121, 21);
			this.cbCargo.TabIndex = 4;
			this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
			// 
			// mtbBuscarCPF
			// 
			this.mtbBuscarCPF.Location = new System.Drawing.Point(402, 51);
			this.mtbBuscarCPF.Mask = "000,000,000-00";
			this.mtbBuscarCPF.Name = "mtbBuscarCPF";
			this.mtbBuscarCPF.Size = new System.Drawing.Size(100, 20);
			this.mtbBuscarCPF.TabIndex = 11;
			this.mtbBuscarCPF.Visible = false;
			this.mtbBuscarCPF.TextChanged += new System.EventHandler(this.mtbBuscarCPF_TextChanged);
			// 
			// mtbTelefone
			// 
			this.mtbTelefone.Enabled = false;
			this.mtbTelefone.Location = new System.Drawing.Point(310, 171);
			this.mtbTelefone.Mask = "(99) 00000-0000";
			this.mtbTelefone.Name = "mtbTelefone";
			this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
			this.mtbTelefone.TabIndex = 3;
			// 
			// mtbCPF
			// 
			this.mtbCPF.Enabled = false;
			this.mtbCPF.Location = new System.Drawing.Point(280, 117);
			this.mtbCPF.Mask = "000,000,000-00";
			this.mtbCPF.Name = "mtbCPF";
			this.mtbCPF.Size = new System.Drawing.Size(100, 20);
			this.mtbCPF.TabIndex = 1;
			this.mtbCPF.TextChanged += new System.EventHandler(this.mtbCPF_TextChanged);
			// 
			// dgvLerDados
			// 
			this.dgvLerDados.AllowUserToAddRows = false;
			this.dgvLerDados.AllowUserToDeleteRows = false;
			this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvLerDados.Location = new System.Drawing.Point(87, 255);
			this.dgvLerDados.Name = "dgvLerDados";
			this.dgvLerDados.ReadOnly = true;
			this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLerDados.Size = new System.Drawing.Size(415, 150);
			this.dgvLerDados.TabIndex = 5;
			this.dgvLerDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellClick);
			// 
			// btExcluir
			// 
			this.btExcluir.BackgroundImage = global::Hotel_FFP.Properties.Resources.cancel2;
			this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btExcluir.Enabled = false;
			this.btExcluir.FlatAppearance.BorderSize = 0;
			this.btExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btExcluir.Location = new System.Drawing.Point(416, 411);
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
			this.btEditar.Location = new System.Drawing.Point(311, 411);
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
			this.btSalvar.Location = new System.Drawing.Point(206, 411);
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
			this.btNovo.Location = new System.Drawing.Point(101, 411);
			this.btNovo.Name = "btNovo";
			this.btNovo.Size = new System.Drawing.Size(70, 65);
			this.btNovo.TabIndex = 6;
			this.btNovo.UseVisualStyleBackColor = true;
			this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
			// 
			// frFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 482);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btSalvar);
			this.Controls.Add(this.btNovo);
			this.Controls.Add(this.dgvLerDados);
			this.Controls.Add(this.mtbCPF);
			this.Controls.Add(this.mtbTelefone);
			this.Controls.Add(this.mtbBuscarCPF);
			this.Controls.Add(this.cbCargo);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbEndereco);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbBuscarNome);
			this.Controls.Add(this.rbCPF);
			this.Controls.Add(this.rbNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frFuncionarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE FUNCIONÁRIOS";
			this.Load += new System.EventHandler(this.frFuncionarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbNome;
		private System.Windows.Forms.RadioButton rbCPF;
		private System.Windows.Forms.TextBox tbBuscarNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbEndereco;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.ComboBox cbCargo;
		private System.Windows.Forms.MaskedTextBox mtbBuscarCPF;
		private System.Windows.Forms.MaskedTextBox mtbTelefone;
		private System.Windows.Forms.MaskedTextBox mtbCPF;
		private System.Windows.Forms.DataGridView dgvLerDados;
		private System.Windows.Forms.Button btNovo;
		private System.Windows.Forms.Button btSalvar;
		private System.Windows.Forms.Button btEditar;
		private System.Windows.Forms.Button btExcluir;
	}
}