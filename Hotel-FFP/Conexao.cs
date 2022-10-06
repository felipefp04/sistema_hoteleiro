using System;
using System.Data.OleDb;

namespace Hotel_FFP
{
	class Conexao
	{
		string conexaoUS = (@"Provider = SQLOLEDB; Data Source = Comp14L2\SQLEXPRESS; Initial Catalog = hotel-ffp; User ID = sa; Password = sa;");

		public OleDbConnection conec = null;

		public void AbrirCon()
		{
			try
			{
				conec = new OleDbConnection(conexaoUS);
				conec.Open();
	}
			catch (Exception erro)
			{
				throw erro; 
			}

			}

		public void FecharCon()
		{
			try
			{
				conec = new OleDbConnection();
				conec.Close();
			}
			catch (Exception erro)
			{

				throw erro;
			}
		}
	}
}
