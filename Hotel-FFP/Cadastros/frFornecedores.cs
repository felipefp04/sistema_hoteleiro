using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_FFP.Cadastros
{
	public partial class frFornecedores : Form
	{
		Conexao con = new Conexao();
		string sql;
		OleDbCommand cmd;
		string id;

		public frFornecedores()
		{
			InitializeComponent();
		}

		private void frFornecedores_Load(object sender, EventArgs e)
		{
			Listar();
		}

		private void Listar()
		{
			con.AbrirCon();
			sql = "SELECT * FROM tblFornecedores ORDER BY nome ASC";
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
			sql = "SELECT * FROM tblFornecedores WHERE nome LIKE '"
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
			dgvLerDados.Columns[2].HeaderText = "Endereço";
			dgvLerDados.Columns[3].HeaderText = "Telefone";

			dgvLerDados.Columns[0].Visible = false;

			dgvLerDados.Columns[1].Width = 100;
		}

		private void habilitarCampos()
		{
			tbNome.Enabled = true;
			tbEndereco.Enabled = true;
			mtbTelefone.Enabled = true;

			tbNome.Focus();
		}

		private void desabilitarCampos()
		{
			tbNome.Enabled = false;
			tbEndereco.Enabled = false;
			mtbTelefone.Enabled = false;
		}

		private void limparCampos()
		{
			tbNome.Text = "";
			tbEndereco.Text = "";
			mtbTelefone.Text = "";
		}

		private void btNovo_Click_1(object sender, EventArgs e)
		{
			habilitarCampos();
			btSalvar.Enabled = true;
			tbNome.Focus();
			btNovo.Enabled = false;
			btEditar.Enabled = false;
			btExcluir.Enabled = false;
		}	

		private void btEditar_Click_1(object sender, EventArgs e)
		{
			if (tbNome.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Preencha o nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbNome.Focus();
				tbNome.Text = "";
				return;
			}

			con.AbrirCon();

			sql = "UPDATE tblFornecedores SET nome = '"
								+ tbNome.Text
								+ "', endereco = '"
								+ tbEndereco.Text
								+ "', telefone = '"
								+ mtbTelefone.Text
								+ "' WHERE idFornec = " + id;

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

				sql = "DELETE FROM tblFornecedores WHERE idFornec = " + id;

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

		private void btSalvar_Click_1(object sender, EventArgs e)
		{
			if (tbNome.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Preencha o nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbNome.Focus();
				return;
			}

			con.AbrirCon();

			sql = "INSERT INTO tblFornecedores VALUES('"
				+ tbNome.Text
				+ "', '" + tbEndereco.Text
				+ "', '" + mtbTelefone.Text
				+ "')";

			cmd = new OleDbCommand(sql, con.conec);

			cmd.ExecuteNonQuery();

			limparCampos();
			Listar();

			con.FecharCon();
		}

		private void dgvLerDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			btEditar.Enabled = true;
			btExcluir.Enabled = true;
			btSalvar.Enabled = false;
			habilitarCampos();

			id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
			tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
			tbEndereco.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
			mtbTelefone.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
		}

		private void tbBuscarNome_TextChanged(object sender, EventArgs e)
		{
			BuscarPorNome();
		}
	}
}

