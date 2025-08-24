using System;
using System.Collections.Generic;
using System.IO;

public class IniReader

{
    private readonly Dictionary<string, Dictionary<string, string>> iniData;
    public IniReader(string filePath)
	{

        iniData = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
        LoadIniFile(filePath);
    }

    private void LoadIniFile(string filePath)
    {
        if (!File.Exists(filePath)) { 
            MessageBox.Show("Arquivo .ini não encontrado. " + filePath, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }

        string currentSection = "";

        foreach (var line in File.ReadAllLines(filePath))
        {
            var trimmed = line.Trim();

            if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith(";") || trimmed.StartsWith("#"))
                continue;

            if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
            {
                currentSection = trimmed.Substring(1, trimmed.Length - 2).Trim();
                if (!iniData.ContainsKey(currentSection))
                {
                    iniData[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                }
            }
            else if (currentSection != null && trimmed.Contains("="))
            {
                var parts = trimmed.Split(new[] { '=' }, 2);
                var key = parts[0].Trim();
                var value = parts[1].Trim();
                iniData[currentSection][key] = value;
            }
        }
    }

    public string GetValue(string section, string key)
    {
        if (iniData.TryGetValue(section, out var sectionData) &&
            sectionData.TryGetValue(key, out var value))
        {
            return value;
        }

        return "";
    }

    public string GetConnectionString()
    {
        var host = GetValue("Conexão", "HOST");
        var port = GetValue("Conexão", "PORT");
        var user = GetValue("Conexão", "USER");
        var password = GetValue("Conexão", "PASSWORD");
        var database = GetValue("Conexão", "DATABASE");

        if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(port) ||
            string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) ||
            string.IsNullOrEmpty(database))
        {
            MessageBox.Show("Dados de conexão incompletos no arquivo .ini", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //throw new InvalidOperationException("Dados de conexão incompletos no arquivo .ini");
            return string.Empty;

        }

        return $"Host={host};Port={port};Username={user};Password={password};Database={database}";
    }

    public (int inicial, int salto) GetPortConfig()
    {
        var inicialStr = GetValue("Configuração", "INICIAL");
        var saltoStr = GetValue("Configuração", "SALTO");

        if (string.IsNullOrEmpty(inicialStr) || string.IsNullOrEmpty(saltoStr))
        {
            // valores padrão
            return (9030, 5);
        }

        if (!int.TryParse(inicialStr, out int inicial))
            inicial = 9030;

        if (!int.TryParse(saltoStr, out int salto))
            salto = 5;

        return (inicial, salto);
    }

}
