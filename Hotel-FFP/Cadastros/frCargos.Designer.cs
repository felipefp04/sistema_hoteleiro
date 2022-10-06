namespace Hotel_FFP.Cadastros
{
	partial class frCargos
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
			this.tbCargo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
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
			this.btExcluir.Location = new System.Drawing.Point(491, 354);
			this.btExcluir.Name = "btExcluir";
			this.btExcluir.Size = new System.Drawing.Size(70, 65);
			this.btExcluir.TabIndex = 13;
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
			this.btEditar.Location = new System.Drawing.Point(491, 268);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(70, 65);
			this.btEditar.TabIndex = 12;
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
			this.btSalvar.Location = new System.Drawing.Point(491, 176);
			this.btSalvar.Name = "btSalvar";
			this.btSalvar.Size = new System.Drawing.Size(70, 65);
			this.btSalvar.TabIndex = 11;
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
			this.btNovo.Location = new System.Drawing.Point(491, 76);
			this.btNovo.Name = "btNovo";
			this.btNovo.Size = new System.Drawing.Size(70, 65);
			this.btNovo.TabIndex = 10;
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
			this.dgvLerDados.Location = new System.Drawing.Point(12, 76);
			this.dgvLerDados.Name = "dgvLerDados";
			this.dgvLerDados.ReadOnly = true;
			this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLerDados.Size = new System.Drawing.Size(459, 343);
			this.dgvLerDados.TabIndex = 14;
			this.dgvLerDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLerDados_CellClick);
			// 
			// tbCargo
			// 
			this.tbCargo.Enabled = false;
			this.tbCargo.Location = new System.Drawing.Point(56, 35);
			this.tbCargo.Name = "tbCargo";
			this.tbCargo.Size = new System.Drawing.Size(415, 20);
			this.tbCargo.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Cargo:";
			// 
			// frCargos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(606, 449);
			this.Controls.Add(this.tbCargo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvLerDados);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btSalvar);
			this.Controls.Add(this.btNovo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frCargos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE CARGOS";
			this.Load += new System.EventHandler(this.frCargos_Load);
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
		private System.Windows.Forms.TextBox tbCargo;
		private System.Windows.Forms.Label label2;
	}
}