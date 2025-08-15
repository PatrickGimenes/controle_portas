using System;
using Npgsql;
using System.Windows.Forms;


namespace Winov.Helpers
{

	public static class PostgresHelper
	{

		public static bool TestConnection(string connString)
		{
			try
			{
				using (var conn = new NpgsqlConnection(connString))
				{
					conn.Open();
					conn.Close();
					return true;

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao testar conexão: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


	}
}