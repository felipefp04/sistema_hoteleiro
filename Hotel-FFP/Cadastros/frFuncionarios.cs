using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Hotel_FFP.Cadastros
{
	public partial class frFuncionarios : Form
	{
		Conexao con = new Conexao();
		string sql;
		OleDbCommand cmd;
		string id;

		public frFuncionarios()
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
			//cbCargo.DataSource = dtLista;

			#region TESTES DE VALIDAÇÃO 01 e 02
			if (dtLista.Rows.Count > 0)
			{
			cbCargo.DataSource = dtLista;
			}
			else
			{
			cbCargo.Text = "Cadastre um cargo";
			}

			//TESTE DE VALIDAÇÃO 02
			if (cbCargo.Text == "")
			{
				MessageBox.Show("Cadastre antes um cargo!");
				Close();

			}
			#endregion

			cbCargo.DisplayMember = "Cargo";
			con.FecharCon();
		}

		private void Listar()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblFuncionarios ORDER BY nome ASC";
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
			sql = "SELECT * FROM tblFuncionarios WHERE nome LIKE '" 
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

		private void BuscarPorCPF()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblFuncionarios WHERE cpf LIKE '"
									+ mtbBuscarCPF.Text
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
			dgvLerDados.Columns[2].HeaderText = "CPF";
			dgvLerDados.Columns[3].HeaderText = "Endereço";
			dgvLerDados.Columns[4].HeaderText = "Telefone";
			dgvLerDados.Columns[5].HeaderText = "Cargo";
			dgvLerDados.Columns[6].HeaderText = "Data";

			dgvLerDados.Columns[0].Visible = false;

			dgvLerDados.Columns[1].Width = 200;
		}

		private void habilitarCampos()
		{
			tbNome.Enabled = true;
			mtbCPF.Enabled = true;
			tbEndereco.Enabled = true;
			mtbTelefone.Enabled = true;
			cbCargo.Enabled = true;

			tbNome.Focus();
		}

		private void desabilitarCampos()
		{
			tbNome.Enabled = false;
			mtbCPF.Enabled = false;
			tbEndereco.Enabled = false;
			mtbTelefone.Enabled = false;
			cbCargo.Enabled = false;
		}

		private void limparCampos()
		{
			tbNome.Text = "";
			mtbCPF.Text = "";
			tbEndereco.Text = "";
			mtbTelefone.Text = "";
		}

		private void frFuncionarios_Load(object sender, EventArgs e)
		{
			Listar();
			rbNome.Checked = true;
			CarregarComboBox();
		}

		private void rbNome_CheckedChanged(object sender, EventArgs e)
		{
			tbBuscarNome.Visible = true;
			mtbBuscarCPF.Visible = false;

			tbBuscarNome.Text = "";
			tbBuscarNome.Focus();
			mtbBuscarCPF.Text = "";
		}

		private void rbCPF_CheckedChanged(object sender, EventArgs e)
		{
			tbBuscarNome.Visible = false;
			mtbBuscarCPF.Visible = true;

			tbBuscarNome.Text = "";
			mtbBuscarCPF.Focus();
			tbBuscarNome.Text = "";
		}

		private void btNovo_Click(object sender, EventArgs e)
		{
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

			if (mtbCPF.Text.ToString().Trim() == "   .   .   -")
			{
				MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mtbCPF.Focus();
				return;
			}

			//CÓDIGO DO BOTÃO SALVAR

			con.AbrirCon();

			sql = "INSERT INTO tblFuncionarios VALUES('" 
				+ tbNome.Text 
				+ "', '" + mtbCPF.Text
				+ "', '" + tbEndereco.Text
				+ "', '" + mtbTelefone.Text
				+ "', '" + cbCargo.Text
				+ "', '" + DateTime.Now
				+ "')";

			cmd = new OleDbCommand(sql, con.conec);

			//VERIFICAR SE O CPF DE FUNCIONÁRIO JÁ EXISTE NO BANCO
			//OleDbCommand cmdVerificar;

			//cmdVerificar = new OleDbCommand("SELECT * FROM tblFuncionarios WHERE cpf = '" + mtbCPF.Text + "'", con.conec);
			//OleDbDataAdapter daLista = new OleDbDataAdapter();
			//daLista.SelectCommand = cmdVerificar;
			//DataTable dtLista = new DataTable();
			//daLista.Fill(dtLista);

			//if (dtLista.Rows.Count > 0)
			//{
			//	MessageBox.Show("CPF já registrado!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	mtbCPF.Text = "";
			//	mtbCPF.Focus();
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
				MessageBox.Show("CPF já registrado!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mtbCPF.Text = "";
				mtbCPF.Focus();

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

			if (mtbCPF.Text == "   .   .   -")
			{
				MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mtbCPF.Focus();
				return;
			}

			//CÓDIGO DO BOTÃO EDITAR

			con.AbrirCon();

			sql = "UPDATE tblFuncionarios SET nome = '"
								+ tbNome.Text
								+ "', cpf = '"
								+ mtbCPF.Text
								+ "', endereco = '"
								+ tbEndereco.Text
								+ "', telefone = '"
								+ mtbTelefone.Text
								+ "', cargo = '"
								+ cbCargo.Text
								+ "' WHERE idFunc = " + id;

			cmd = new OleDbCommand(sql, con.conec);

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

		private void btExcluir_Click(object sender, EventArgs e)
		{
			var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				//MessageBox.Show("Clicou em sim!"); //Para testar o código.

				//CÓDIGO DO BOTÃO PARA EXCLUIR

				con.AbrirCon();

				sql = "DELETE FROM tblFuncionarios WHERE idFunc = " + id;

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

		private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btEditar.Enabled = true;
			btExcluir.Enabled = true;
			btSalvar.Enabled = false;
			habilitarCampos();

			id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
			tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
			mtbCPF.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
			tbEndereco.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
			mtbTelefone.Text = dgvLerDados.CurrentRow.Cells[4].Value.ToString();
			cbCargo.Text = dgvLerDados.CurrentRow.Cells[5].Value.ToString();
		}

		private void tbBuscarNome_TextChanged(object sender, EventArgs e)
		{
			BuscarPorNome();
		}

		private void mtbCPF_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void mtbBuscarCPF_TextChanged(object sender, EventArgs e)
		{
			if (mtbBuscarCPF.Text == "   .   .   -")
			{
				Listar();
			}
			else
			{
				BuscarPorCPF();
			}
		}
	}
}
