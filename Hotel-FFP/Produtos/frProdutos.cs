using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_FFP.Cadastros
{
	public partial class frProdutos : Form
	{
		public frProdutos()
		{
			InitializeComponent();
		}

		private void LimparImagem()
		{
			pbImagem.Image = Properties.Resources.img_produ;
		}

		private void habilitarCampos()
		{
			tbNome.Enabled = true;
			tbDescricao.Enabled = true;
			tbValor.Enabled = true;
			tbEstoque.Enabled = true;
			cbFornecedor.Enabled = true;
			tbNome.Focus();
			btAdicionarImg.Enabled = true;
		}

		private void desabilitarCampos()
		{
			tbNome.Enabled = false;
			tbDescricao.Enabled = false;
			tbValor.Enabled = false;
			tbEstoque.Enabled = false;
			cbFornecedor.Enabled = false;
			btAdicionarImg.Enabled = false;
		}

		private void limparCampos()
		{
			tbNome.Text = "";
			tbDescricao.Text = "";
			tbValor.Text = "";
			tbEstoque.Text = "";
			LimparImagem();
		}

		private void tbDescricao_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbValor_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tbEstoque_TextChanged(object sender, EventArgs e)
		{

		}

		private void frProdutos_Load(object sender, EventArgs e)
		{
			LimparImagem();
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

			if (tbValor.Text == "")
			{
				MessageBox.Show("Preencha o Valor!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbValor.Focus();
				return;
			}

			//CÓDIGO DO BOTÃO SALVAR

			MessageBox.Show("Registro Salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btNovo.Enabled = true;
			btSalvar.Enabled = false;
			limparCampos();
			desabilitarCampos();
			LimparImagem();
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

			if (tbValor.Text == "")
			{
				MessageBox.Show("Preencha o Valor!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbValor.Focus();
				return;
			}

			//CÓDIGO DO BOTÃO EDITAR

			MessageBox.Show("Registro editado com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btNovo.Enabled = true;
			btEditar.Enabled = false;
			btExcluir.Enabled = false;
			limparCampos();
			desabilitarCampos();
			LimparImagem();
		}

		private void btExcluir_Click(object sender, EventArgs e)
		{
			var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				//MessageBox.Show("Clicou em sim!"); //Para testar o código.

				//CÓDIGO DO BOTÃO PARA EXCLUIR

				MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btNovo.Enabled = true;
				btEditar.Enabled = false;
				btExcluir.Enabled = false;
				limparCampos();
				desabilitarCampos();
				LimparImagem();
			}
		}

		private void btAdicionarImg_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialImg = new OpenFileDialog();

			//dialImg.Filter = "Arquivos de imagem JPG(*.jpg) |*.jpg|Arquivos PNG(*.png) |*.png|Todos os arquivos (*.*) |*.*";

			dialImg.Filter = "Arquivos de imagem (*.jpg;*.png) |*.jpg;*.png|Todos os arquivos (*.*) |*.*";


			if (dialImg.ShowDialog() == DialogResult.OK)
			{
				string foto = dialImg.FileName.ToString();
				//MessageBox.Show(foto);
				pbImagem.ImageLocation = foto;
			}
		}
	}
}
