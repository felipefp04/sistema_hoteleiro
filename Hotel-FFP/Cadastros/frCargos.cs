using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_FFP.Cadastros
{
	public partial class frCargos : Form
	{
		Conexao con = new Conexao();
		string sql;
		OleDbCommand cmd;
		string id;

		public frCargos()
		{
			InitializeComponent();
		}

		private void FormatarDGV()
		{
			dgvLerDados.Columns[0].HeaderText = "Código";
			dgvLerDados.Columns[1].HeaderText = "Cargo";

			dgvLerDados.Columns[0].Visible = false;

			dgvLerDados.Columns[1].Width = 200;
		}

		private void Listar()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblCargos ORDER BY cargo ASC";
			cmd = new OleDbCommand(sql, con.conec);
			OleDbDataAdapter daLista = new OleDbDataAdapter();
			daLista.SelectCommand = cmd;
			DataTable dtLista = new DataTable();
			daLista.Fill(dtLista);
			dgvLerDados.DataSource = dtLista;
			con.FecharCon();
			FormatarDGV();
		}

		private void frCargos_Load(object sender, EventArgs e)
		{
			Listar();
		}

		private void btNovo_Click(object sender, EventArgs e)
		{
			tbCargo.Enabled = true;
			btSalvar.Enabled = true;
			btNovo.Enabled = false;
			btEditar.Enabled = false;
			btExcluir.Enabled = false;
			tbCargo.Focus();
		}

		private void btSalvar_Click(object sender, EventArgs e)
		{
			if (tbCargo.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Preencha o cargo!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbCargo.Focus();
				tbCargo.Text = "";
				return;
			}

			//CÓDIGO DO BOTÃO SALVAR

			con.AbrirCon();

			sql = "INSERT INTO tblCargos(cargo) VALUES('" + tbCargo.Text + "')";

			cmd = new OleDbCommand(sql, con.conec);

			cmd.ExecuteNonQuery();
			con.FecharCon();

			MessageBox.Show("Registro Salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btNovo.Enabled = true;
			btSalvar.Enabled = false;
			tbCargo.Text = "";
			tbCargo.Enabled = false;
			Listar();
		}

		private void btEditar_Click(object sender, EventArgs e)
		{
			if (tbCargo.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Preencha o nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbCargo.Focus();
				tbCargo.Text = "";
				return;
			}

			//CÓDIGO DO BOTÃO EDITAR

			con.AbrirCon();

			sql = "UPDATE tblCargos SET cargo = '" + tbCargo.Text + "' WHERE idCargo = " + id;

			cmd = new OleDbCommand(sql, con.conec);

			cmd.ExecuteNonQuery();
			con.FecharCon();

			MessageBox.Show("Registro editado com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btNovo.Enabled = true;
			btEditar.Enabled = false;
			btExcluir.Enabled = false;
			tbCargo.Text = "";
			tbCargo.Enabled = false;
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

				sql = "DELETE FROM tblCargos WHERE idCargo = " + id;

				cmd = new OleDbCommand(sql, con.conec);

				cmd.ExecuteNonQuery();
				con.FecharCon();

				MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btNovo.Enabled = true;
				btEditar.Enabled = false;
				btExcluir.Enabled = false;
				tbCargo.Text = "";
				tbCargo.Enabled = false;
				Listar();
			}
		}

		private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btEditar.Enabled = true;
			btExcluir.Enabled = true;
			btSalvar.Enabled = false;
			tbCargo.Enabled = true;

			id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
			//MessageBox.Show(id);

			tbCargo.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
		}
	}
}
