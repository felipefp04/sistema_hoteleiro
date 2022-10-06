using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_FFP
{
	public partial class frMenuPrincipal : Form
	{
		public frMenuPrincipal()
		{
			InitializeComponent();
		}

		private void frMenuPrincipal_Resize(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frMenuPrincipal_Load(object sender, EventArgs e)
		{
			pnlTopo.BackColor = Color.FromArgb(255, 222, 206);
			pnlDireita.BackColor = Color.FromArgb(255, 197, 168);

			lbUsuario.Text = Program.nomeUsuario;
			lbCargo.Text = Program.cargoUsuario;
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cadastros.frFuncionarios frFunc = new Cadastros.frFuncionarios();
			frFunc.ShowDialog();
		}

		private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cadastros.frCargos frCargos = new Cadastros.frCargos();
			frCargos.ShowDialog();
		}

		private void MenuProdutos_Click(object sender, EventArgs e)
		{

		}

		private void btProduto_Click(object sender, EventArgs e)
		{
			Cadastros.frProdutos frProd = new Cadastros.frProdutos();
			frProd.ShowDialog();
		}

		private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btProduto_Click(sender, e); //Argumentos
		}

		private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cadastros.frUsuarios frUsu = new Cadastros.frUsuarios();
			frUsu.ShowDialog();
		}

		private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cadastros.frFornecedores frFornec = new Cadastros.frFornecedores();
			frFornec.ShowDialog();
		}
	}
}
