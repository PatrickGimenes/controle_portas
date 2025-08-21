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

    public void SaveConfig(TextBox txtHost, TextBox txtPort, TextBox txtUser, TextBox txtPwd, TextBox txtDb)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(iniFilePath, false)) // false = sobrescreve o arquivo
            {
                writer.WriteLine("[Conexão]");
                writer.WriteLine("HOST = " + txtHost.Text.Trim());
                writer.WriteLine("PORT = " + txtPort.Text.Trim());
                writer.WriteLine("USER = " + txtUser.Text.Trim());
                writer.WriteLine("PASSWORD = " + txtPwd.Text.Trim());
                writer.WriteLine("DATABASE = " + txtDb.Text.Trim());
            }

            MessageBox.Show("Configuração salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar a configuração: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}