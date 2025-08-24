public static class PortHelper
{
    public static List<int> GetUsedPorts(string connString)
    {
        var usedPorts = new List<int>();

        try
        {
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT ws::int, api::int FROM clientes";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usedPorts.Add(reader.GetInt32(0)); // WS
                        usedPorts.Add(reader.GetInt32(1)); // API
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return usedPorts;
        }
        return usedPorts;
    }

    public static void SuggestPorts(string connString, string iniPath, out int suggestedWS, out int suggestedAPI)
    {
        // Lê configuração de portas
        var iniReader = new IniReader(iniPath);
        var (inicial, salto) = iniReader.GetPortConfig();

        // Pega portas já usadas
        var usedPorts = GetUsedPorts(connString);

        // Começa a busca
        suggestedWS = inicial;

        while (usedPorts.Contains(suggestedWS) || usedPorts.Contains(suggestedWS + salto))
        {
            suggestedWS+=5;
        }

        suggestedAPI = suggestedWS + salto;
    }
}