using System.IO;
using System.Text.Json;

namespace HexereiKatepnha.Services;

public abstract class ConfigManagerBase<TConfig> : IConfigManager where TConfig : class, new()
{
    protected abstract string ConfigFileName { get; set; }

    public TConfig Configuration { get; private set; } = new();

    public void Load()
    {
        if (File.Exists(ConfigFileName))
        {
            // Console.WriteLine($"{ConfigFileName} 这个config要读取配置了~");
            try
            {
                string json = File.ReadAllText(ConfigFileName);
                var loaded = JsonSerializer.Deserialize<TConfig>(json);
                if (loaded != null)
                {
                    Configuration = loaded;
                }
            }
            catch
            {
            }
        }
        else
        {
            Save();
        }

        OnLoaded();
    }

    public void Save()
    {
        // Console.WriteLine($"{ConfigFileName} 这个config要保存配置了~");
        var directory = Path.GetDirectoryName(ConfigFileName);
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        string json = JsonSerializer.Serialize(Configuration, options);
        File.WriteAllText(ConfigFileName, json);
    }

    protected virtual void OnLoaded()
    {
    }
}