using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_FFP.Cadastros
{
	public partial class frUsuarios : Form
	{
		Conexao con = new Conexao();
		string sql;
		OleDbCommand cmd;
		string id;

		public frUsuarios()
		{
			InitializeComponent();
		}

		private void CarregarComboBox()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblCargos ORDER BY cargo ASC";
			cmd = new OleDbCommand(sql, con.conec);
			OleDbDataAdapter daLista = new OleDbDataAdapter();
			daLista.SelectCommand = cmd;
			DataTable dtLista = new DataTable();
			daLista.Fill(dtLista);
			cbCargo.DataSource = dtLista;

			cbCargo.DisplayMember = "Cargo";
			con.FecharCon();
		}

		private void Listar()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblUsuarios ORDER BY nome ASC";
			cmd = new OleDbCommand(sql, con.conec);
			OleDbDataAdapter daLista = new OleDbDataAdapter();
			daLista.SelectCommand = cmd;
			DataTable dtLista = new DataTable();
			daLista.Fill(dtLista);
			dgvLerDados.DataSource = dtLista;
			con.FecharCon();
			FormatarDGV();
		}

		private void BuscarPorNome()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblUsuarios WHERE nome LIKE '"
									+ tbBuscarNome.Text
									+ "%"
									+ "' ORDER BY nome ASC";
			cmd = new OleDbCommand(sql, con.conec);
			OleDbDataAdapter daLista = new OleDbDataAdapter();
			daLista.SelectCommand = cmd;
			DataTable dtLista = new DataTable();
			daLista.Fill(dtLista);
			dgvLerDados.DataSource = dtLista;
			con.FecharCon();
			FormatarDGV();
		}

		private void FormatarDGV()
		{
			dgvLerDados.Columns[0].HeaderText = "Código";
			dgvLerDados.Columns[1].HeaderText = "Nome";
			dgvLerDados.Columns[2].HeaderText = "Cargo";
			dgvLerDados.Columns[3].HeaderText = "Usuário";
			dgvLerDados.Columns[4].HeaderText = "Senha";
			dgvLerDados.Columns[5].HeaderText = "Data";

			dgvLerDados.Columns[0].Visible = false;

			dgvLerDados.Columns[1].Width = 200;
		}

		private void habilitarCampos()
		{
			tbNome.Enabled = true;
			tbUsuario.Enabled = true;
			tbSenha.Enabled = true;
			cbCargo.Enabled = true;

			tbNome.Focus();
		}

		private void desabilitarCampos()
		{
			tbNome.Enabled = false;
			tbUsuario.Enabled = false;
			tbSenha.Enabled = false;
			cbCargo.Enabled = false;
		}

		private void limparCampos()
		{
			tbNome.Text = "";
			tbUsuario.Text = "";
			tbSenha.Text = "";
		}

		private void frUsuarios_Load(object sender, EventArgs e)
		{
			Listar();
			CarregarComboBox();
		}

		private void btNovo_Click(object sender, EventArgs e)
		{
			//VALIDAÇÃO
			if (cbCargo.Text == "")
			{
				MessageBox.Show("Cadastre antes um cargo!");
				Close();
			}

			habilitarCampos();
			btSalvar.Enabled = true;
			tbNome.Focus();
			btNovo.Enabled = false;
			btEditar.Enabled = false;
			btExcluir.Enabled = false;
		}

		private void btSalvar_Click(object sender, EventArgs e)
		{
			if (tbNome.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Preencha o nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbNome.Focus();
				return;
			}

			//CÓDIGO DO BOTÃO SALVAR

			con.AbrirCon();

			sql = "INSERT INTO tblUsuarios VALUES('"
				+ tbNome.Text
				+ "', '" + cbCargo.Text
				+ "', '" + tbUsuario.Text
				+ "', '" + tbSenha.Text
				+ "', '" + DateTime.Now
				+ "')";

			cmd = new OleDbCommand(sql, con.conec);

			//VERIFICAR SE O NOME DE USUÁRIO JÁ EXISTE NO BANCO
			//OleDbCommand cmdVerificar;

			//cmdVerificar = new OleDbCommand("SELECT * FROM tblUsuarios WHERE usuario = '" + tbUsuario.Text + "'", con.conec);
			//OleDbDataAdapter daLista = new OleDbDataAdapter();
			//daLista.SelectCommand = cmdVerificar;
			//DataTable dtLista = new DataTable();
			//daLista.Fill(dtLista);

			//if (dtLista.Rows.Count > 0)
			//{
			//	MessageBox.Show("Usuário já registrado!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	tbUsuario.Text = "";
			//	tbUsuario.Focus();
			//	return;
			//}

			try
			{
				cmd.ExecuteNonQuery();

				MessageBox.Show("Registro Salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btNovo.Enabled = true;
				btSalvar.Enabled = false;
				limparCampos();
				desabilitarCampos();
				Listar();
			}
			catch (Exception)
			{

				MessageBox.Show("Usuário já registrado!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.FecharCon();
		}

		private void btEditar_Click(object sender, EventArgs e)
		{
			if (tbNome.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Preencha o nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbNome.Focus();
				tbNome.Text = "";
				return;
			}

			//CÓDIGO DO BOTÃO EDITAR

			con.AbrirCon();

			sql = "UPDATE tblUsuarios SET nome = '"
								+ tbNome.Text
								+ "', usuario = '"
								+ tbUsuario.Text
								+ "', senha = '"
								+ tbSenha.Text
								+ "', cargo = '"
								+ cbCargo.Text
								+ "' WHERE idUsuario = " + id;

			cmd = new OleDbCommand(sql, con.conec);

			//VERIFICAR SE O NOME DE USUÁRIO JÁ EXISTE NO BANCO

			cmd.ExecuteNonQuery();
			con.FecharCon();

			MessageBox.Show("Registro editado com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btNovo.Enabled = true;
			btEditar.Enabled = false;
			btExcluir.Enabled = false;
			limparCampos();
			desabilitarCampos();
			Listar();


		}

		private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btEditar.Enabled = true;
			btExcluir.Enabled = true;
			btSalvar.Enabled = false;
			habilitarCampos();

			id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
			tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
			cbCargo.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
			tbUsuario.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
			tbSenha.Text = dgvLerDados.CurrentRow.Cells[4].Value.ToString();
			
			
		}

		private void btExcluir_Click(object sender, EventArgs e)
		{
			var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				//MessageBox.Show("Clicou em sim!"); //Para testar o código.

				//CÓDIGO DO BOTÃO PARA EXCLUIR

				con.AbrirCon();

				sql = "DELETE FROM tblUsuarios WHERE idUsuario = " + id;

				cmd = new OleDbCommand(sql, con.conec);

				cmd.ExecuteNonQuery();
				con.FecharCon();

				MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btNovo.Enabled = true;
				btEditar.Enabled = false;
				btExcluir.Enabled = false;
				limparCampos();
				desabilitarCampos();
				Listar();
			}
		}

		private void tbBuscarNome_TextChanged(object sender, EventArgs e)
		{
			BuscarPorNome();
		}
	}
}
