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






        public static void EnsureTableExists(string connString)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"
                CREATE TABLE IF NOT EXISTS clientes (
                    id SERIAL PRIMARY KEY,
                    nome VARCHAR(20) NOT NULL,
                    ws VARCHAR(6) NOT NULL,
                    api VARCHAR(6) NOT NULL,
                    ambiente VARCHAR(20) NOT NULL
                );
            ";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar/verificar tabela: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void InsertClient(string connString, string client, int ws, int api, string type)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO clientes (nome, ws, api, ambiente) 
                                   VALUES (@client, @ws, @api, @type);";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("client", client);
                        cmd.Parameters.AddWithValue("ws", ws);
                        cmd.Parameters.AddWithValue("api", api);
                        cmd.Parameters.AddWithValue("type", type);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void UpdateClient(string connString, int id, string client, int ws, int api, string type)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = @"UPDATE clientes 
                                   SET nome = @client, ws = @ws, api = @api, ambiente = @type
                                   WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.Parameters.AddWithValue("client", client);
                        cmd.Parameters.AddWithValue("ws", ws);
                        cmd.Parameters.AddWithValue("api", api);
                        cmd.Parameters.AddWithValue("type", type);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar no banco: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteClient(string connString, int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = @"DELETE FROM clientes 
                                   WHERE id = @id;";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir no banco: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SelectAll(string connString, DataGridView table)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM clientes ORDER BY id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);
                        table.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}