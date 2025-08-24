using System;
using System.IO;
using System.Windows.Forms;

public class IniConfigWriter
{
    private readonly string iniFilePath;

    public IniConfigWriter(string filePath)
    {
        iniFilePath = filePath;
    }

    public void SaveConnectionConfig(string host, string port, string user, string password, string database)
    {
        SaveIniFile(iniFilePath, writer =>
        {
            writer.WriteLine("[Conexão]");
            writer.WriteLine($"HOST = {host.Trim()}");
            writer.WriteLine($"PORT = {port.Trim()}");
            writer.WriteLine($"USER = {user.Trim()}");
            writer.WriteLine($"PASSWORD = {password.Trim()}");
            writer.WriteLine($"DATABASE = {database.Trim()}");
        });
    }

    public void SavePortConfig(int inicial, int salto)
    {
        SaveIniFile("config_port.ini", writer =>
        {
            writer.WriteLine("[Configuração]");
            writer.WriteLine($"INICIAL = {inicial}");
            writer.WriteLine($"SALTO = {salto}");
        });
    }
    private void SaveIniFile(string path, Action<StreamWriter> writeAction)
    {
        try
        {
            using (var writer = new StreamWriter(path, false)) // false = sobrescreve o arquivo
            {
                writeAction(writer);
            }

            MessageBox.Show("Configuração salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar a configuração: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
