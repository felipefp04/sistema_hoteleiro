using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel_FFP
{
	public partial class frLogin : Form
	{
		Conexao con = new Conexao();

		public frLogin()
		{
			InitializeComponent();
			pnlLogin.Visible = false;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void frLogin_Load(object sender, EventArgs e)
		{
			//pnlLogin.Location = new Point(this.Width / 2, this.Height / 2);
			//pnlLogin.Location = new Point(this.Width / 2 - 170, this.Height / 2 - 167);
			pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Size.Width / 2, this.Height / 2 - pnlLogin.BackgroundImage.Size.Height / 2);
			pnlLogin.Visible = true;
		}

		private void btLogin_Click(object sender, EventArgs e)
		{
			//if (tbUsuario.Text == "" && tbSenha.Text == "")
			//{
			//	MessageBox.Show("Preencha os campos usuário e senha!");
			//	tbUsuario.Focus();
			//	return;
			//}
			//if (tbUsuario.Text == "" )
			//{
			//	MessageBox.Show("Preencha o campo usuário!");
			//	tbUsuario.Focus();
			//	return;
			//}
			//if (tbSenha.Text == "")
			//{
			//	MessageBox.Show("Preencha o campo senha!");
			//	tbSenha.Focus();
			//	return;
			//}

			ChamarLogin();

		}

		private void tbUsuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void ChamarLogin()
		{
			eprSistema.Clear();

			if (tbUsuario.Text.ToString().Trim() == "")
			{
				eprSistema.SetError(tbUsuario, "Preencha esse campo!");
				tbUsuario.Text = "";
				tbUsuario.Focus();
			}
			if (tbSenha.Text.ToString().Trim() == "")
			{
				eprSistema.SetError(tbSenha, "Preencha esse campo!");
				tbSenha.Focus();
			}
			//else if (true)
			//{
			//	frMenuPrincipal frMenuPrinc = new frMenuPrincipal();
			//	Limpar();
			//	frMenuPrinc.ShowDialog();
			//}
			//CÓDIGO LOGIN AQUI
			OleDbCommand cmdVerificar;
			OleDbDataReader drDados;

			con.AbrirCon();

			cmdVerificar = new OleDbCommand("SELECT * from tblUsuarios WHERE usuario = '" + tbUsuario.Text + "' and senha = '" + tbSenha.Text + "'", con.conec);

			drDados = cmdVerificar.ExecuteReader();

			if (drDados.HasRows)
			{
				while (drDados.Read())
				{
					Program.nomeUsuario = drDados["nome"].ToString();
					Program.cargoUsuario = drDados["cargo"].ToString();
				}
				//MessageBox.Show("con.nomeUsuario");

				MessageBox.Show("Bem-vindo " + Program.nomeUsuario + "!", "LOGIN EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frMenuPrincipal frPrinc = new frMenuPrincipal();
				Limpar();
				frPrinc.ShowDialog();
			}
			else
			{
				MessageBox.Show("Nome do usário ou senha incorreto!", "LOGIN NÃO EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbUsuario.Text = "";
				tbUsuario.Focus();

			}

			con.FecharCon();


		}

		private void Limpar()
		{
			//tbUsuario.Text = "";
			//tbSenha.Text = "";
			tbUsuario.Clear();
			tbSenha.Clear();
			tbUsuario.Focus();

		}

		private void frLogin_KeyDown(object sender, KeyEventArgs e)
		{
			//MessageBox.Show("Tecla pressionada!");

			if (e.KeyCode == Keys.Enter)
			{
				//MessageBox.Show("Tecla Enter");
				//btLogin_Click(sender, e); //Argumentos
				ChamarLogin();
			}
		}

		private void frLogin_Resize(object sender, EventArgs e)
		{
			pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Size.Width / 2, this.Height / 2 - pnlLogin.BackgroundImage.Size.Height / 2);
		}


	}
}

