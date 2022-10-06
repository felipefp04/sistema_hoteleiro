namespace Hotel_FFP
{
	partial class frLogin
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.btLogin = new System.Windows.Forms.Button();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.eprSistema = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnlLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.eprSistema)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlLogin
			// 
			this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
			this.pnlLogin.Controls.Add(this.btLogin);
			this.pnlLogin.Controls.Add(this.tbSenha);
			this.pnlLogin.Controls.Add(this.tbUsuario);
			this.pnlLogin.Location = new System.Drawing.Point(100, 100);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(340, 334);
			this.pnlLogin.TabIndex = 0;
			// 
			// btLogin
			// 
			this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLogin.FlatAppearance.BorderSize = 0;
			this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
			this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogin.Location = new System.Drawing.Point(27, 268);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(285, 33);
			this.btLogin.TabIndex = 3;
			this.btLogin.Text = "&Login";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// tbSenha
			// 
			this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSenha.Location = new System.Drawing.Point(27, 227);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.PasswordChar = '*';
			this.tbSenha.Size = new System.Drawing.Size(285, 35);
			this.tbSenha.TabIndex = 2;
			this.tbSenha.Text = "1234";
			this.tbSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// tbUsuario
			// 
			this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsuario.Location = new System.Drawing.Point(27, 192);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(285, 29);
			this.tbUsuario.TabIndex = 1;
			this.tbUsuario.Tag = "alu";
			this.tbUsuario.Text = "car";
			this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
			// 
			// eprSistema
			// 
			this.eprSistema.ContainerControl = this;
			// 
			// frLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(717, 473);
			this.Controls.Add(this.pnlLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frLogin_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frLogin_KeyDown);
			this.Resize += new System.EventHandler(this.frLogin_Resize);
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.eprSistema)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.TextBox tbSenha;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.ErrorProvider eprSistema;
	}
}

