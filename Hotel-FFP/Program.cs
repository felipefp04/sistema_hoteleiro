using System;
using System.Windows.Forms;

namespace Hotel_FFP
{
	static class Program
	{
		public static string nomeUsuario;
		public static string cargoUsuario;

		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frLogin());
		}
	}
}
