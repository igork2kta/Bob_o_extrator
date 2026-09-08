using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bob_o_extrator
{

    public static class Config
    {
        public static readonly string PathArquivoTemporario = @"C:\Temp\TaxZone";

        // Propriedades salvas no JSON
        public static string LastImportPath { get; set; }
        public static string LastScriptPath { get; set; }
        public static string LastOutputPath { get; set; }
        public static string Versao { get; set; }

        // Propriedade mantida só em memória (ignorada pelo atributo [JsonIgnore])
        [JsonIgnore]
        public static string Cookie { get; set; }

        private static string GetAppFolder() =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Assembly.GetExecutingAssembly().GetName().Name);

        private static string GetFilePath() =>
            Path.Combine(GetAppFolder(), "config.json");

        public static void Load()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath)) return;

            string json = File.ReadAllText(filePath);
            var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
            if (dict == null) return;

            // Preenche automaticamente as propriedades estáticas com base no JSON
            foreach (var prop in typeof(Config).GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (!prop.CanWrite || prop.GetCustomAttribute<JsonIgnoreAttribute>() != null) continue;

                if (dict.TryGetValue(prop.Name, out var element))
                {
                    var value = JsonSerializer.Deserialize(element.GetRawText(), prop.PropertyType);
                    prop.SetValue(null, value);
                }
            }
        }

        public static void Save()
        {
            Versao = Assembly.GetEntryAssembly()?.GetName().Version?.ToString();

            // Monta um dicionário com os valores das propriedades estáticas
            var dict = new Dictionary<string, object>();
            foreach (var prop in typeof(Config).GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (prop.GetCustomAttribute<JsonIgnoreAttribute>() != null) continue;

                dict[prop.Name] = prop.GetValue(null);
            }

            string directory = GetAppFolder();
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(dict, options);
            File.WriteAllText(GetFilePath(), json);
        }
    }

}
