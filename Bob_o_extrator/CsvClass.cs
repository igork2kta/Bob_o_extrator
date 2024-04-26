using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bob_o_extrator
{
    public static class CsvClass
    {
        public static void WriteDataTableToCsvOld(DataTable dataTable, string filePath)
        {
            try
            {

                string ext = Path.GetExtension(filePath);
                if (string.IsNullOrEmpty(ext)) filePath += ".csv";



                // Escrever os dados do DataTable no arquivo CSV usando StreamWriter
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    // Escrever cabeçalho (nomes das colunas)
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        streamWriter.Write('"' + column.ColumnName + '"' + ";");
                    }
                    streamWriter.WriteLine();

                    // Escrever dados
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            streamWriter.Write('"' + item.ToString() + '"' + ";");
                        }
                        streamWriter.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void WriteDataTableToCsv(DataTable dataTable, string filePath, string query = null)
        {
            if (string.IsNullOrEmpty(filePath)) return;

            if (!Directory.Exists(new FileInfo(filePath).Directory.FullName))
                Directory.CreateDirectory(new FileInfo(filePath).Directory.FullName);

            string ext = Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(ext)) filePath += ".csv";

            if (File.Exists(filePath))
            {
                DialogResult response = MessageBox.Show($"Arquivo {filePath} já existe! Deseja substituir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.No) return;
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();

                // Escrever cabeçalho (nomes das colunas)
                foreach (DataColumn column in dataTable.Columns)
                    sb.Append('"' + column.ColumnName + '"' + ";");

                sb.AppendLine();

                // Escrever dados
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                        sb.Append('"' + item.ToString() + '"' + ";");

                    sb.AppendLine();
                }
                if (!string.IsNullOrEmpty(query))
                {
                    sb.AppendLine();
                    sb.AppendLine('"' + query + '"' + ";");
                }

                streamWriter.Write(sb.ToString());
            }
        }

        public static DataTable ReadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(filePath)) return null;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.SetDelimiters(new string[] { ";" });
                    parser.HasFieldsEnclosedInQuotes = true;

                    // Assume a primeira linha como cabeçalho
                    string[] headers = parser.ReadFields();
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        dataTable.Rows.Add(fields);
                    }
                }

                return dataTable;
            }
            catch (Exception exception)
            {
                return null;
            }

        }


        /// <summary>
        /// Abre uma caixa de diálogo para salvamento de arquivo.
        /// </summary>
        /// <param name="nome_arquivo">Nome desejado. (Pode ser alterado na caixa de diálogo)</param>
        /// <param name="tipo_arquivo">Formato do arquivo a salvar. (Todos é o padrão)</param>
        /// <returns>Path completo do arquivo a ser salvo.</returns>
        public static string SaveAs(string nome_arquivo = "", string tipo_arquivo = "All files (*.*)|*.*")
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = tipo_arquivo,
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = nome_arquivo,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                return saveFileDialog.FileName;
            else
                return null;

        }

        public static string OpenFile(string nome_arquivo = "", string tipo_arquivo = "All files (*.*)|*.*")
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = tipo_arquivo,
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = nome_arquivo,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
            else
                return null;

        }



    }
}
