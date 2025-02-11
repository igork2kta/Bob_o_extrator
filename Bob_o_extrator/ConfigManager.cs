using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Bob_o_extrator
{
    public class Config
    {
        public string LastImportPath { get; set; }
        public string LastScriptPath { get; set; }
        public string LastOutputPath { get; set; }
        public string Versao { get; set; }
    }

    public static class ConfigManager
    {
        public static string LastImportPath { get; set; }
        public static string LastScriptPath { get; set; }
        public static string LastOutputPath { get; set; }
        public static string Versao { get; set; }


        private static string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GetAppName(), "config.json");

        private static string GetAppName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        public static void Load()
        {
            if (File.Exists(configFilePath))
            {
                string json = File.ReadAllText(configFilePath);
                var config = JsonSerializer.Deserialize<Config>(json);

                if (config != null)
                {
                    LastImportPath = config.LastImportPath;
                    LastScriptPath = config.LastScriptPath;
                    LastOutputPath = config.LastOutputPath;
                    Versao = config.Versao;
                }
            }
        }

        public static void Save()
        {
            Versao = Assembly.GetEntryAssembly().GetName().Version.ToString();
            var config = new Config
            {
                LastImportPath = LastImportPath,
                LastScriptPath = LastScriptPath,
                LastOutputPath = LastOutputPath,
                Versao = Versao
            };

            if(!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GetAppName())))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GetAppName()));
            }
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configFilePath, json);
        }
    }
}
