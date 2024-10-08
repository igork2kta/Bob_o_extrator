﻿using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bob_o_extrator
{
    public partial class MainForm : Form
    {
        bool extracting = false;
        readonly string pathScriptTemporario = AppDomain.CurrentDomain.BaseDirectory + "Temp\\scriptTemporario.txt";
        bool BobOExecutor = false;
        public MainForm()
        {
            InitializeComponent();
            Import(Properties.Settings.Default.LastImportPath);
            tb_scriptPath.Text = Properties.Settings.Default.LastScriptPath;
            tb_outputPath.Text = Properties.Settings.Default.LastOutputPath;
            setLblHelp();
            ApagarScriptTemp();
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            RemoveDgvEmptyLines();
            CsvClass.WriteDataTableToCsv(ExtractDataTableFromDataGridView(dataGridView), CsvClass.SaveAs());
        }

        private void setLblHelp()
        {
            ToolTip toolTip = new ToolTip();
            // Obter a data de criação do arquivo do assembly
            DateTime creationDate = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);

            string helpText = "Bob o Extrator: Execute uma extração de dados em várias bases de uma só vez!";
            helpText += "\nBob o Executor: Execute vários scripts em sequência separados por ';' em várias bases ao mesmo tempo!";
            //Versão, está no Program.cs
            helpText += $"\nVersão {Assembly.GetEntryAssembly().GetName().Version} \nData de compilação: {creationDate}";
            toolTip.SetToolTip(lbl_help, helpText);
        }

        static DataTable ExtractDataTableFromDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Adicionar colunas ao DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
                dataTable.Columns.Add(column.HeaderText);

            // Adicionar linhas ao DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                    dataRow[i] = row.Cells[i].Value;

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        private void bt_importar_Click(object sender, EventArgs e)
        {
            //Se a coluna banco da primeira linha estiver vazia, provavelmente esta tudo vazio então nem pergunta
            if (!string.IsNullOrEmpty(Convert.ToString(dataGridView.Rows[0].Cells[1].Value)))
            {
                DialogResult result = MessageBox.Show("Os dados atuais serão apagados, prosseguir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;
            }
            Import(CsvClass.OpenFile());
        }

        private void Import(string path)
        {
            DataTable dataTable = CsvClass.ReadCsvToDataTable(path);

            if (dataTable == null) return;

            dataGridView.Rows.Clear();

            Properties.Settings.Default.LastImportPath = path;
            Properties.Settings.Default.Save();

            bool executar;
            string banco, usuario, senha, schema, pathExtracao;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //Se o banco for nulo, retorna pois provavelmente a linha toda esta nula
                if (string.IsNullOrEmpty(dataTable.Rows[i][1].ToString())) return;

                string value = dataTable.Rows[i][0].ToString();
                if (value.ToUpper() == "S" || value.ToUpper() == "SIM" || value.ToUpper() == "T" || value.ToUpper() == "TRUE")
                    executar = true;
                else
                    executar = false;
                banco = dataTable.Rows[i][1].ToString();
                usuario = dataTable.Rows[i][2].ToString();
                senha = dataTable.Rows[i][3].ToString();
                schema = dataTable.Rows[i][4].ToString();
                pathExtracao = dataTable.Rows[i][5].ToString();
                dataGridView.Rows.Add(executar, banco, usuario, senha, schema, pathExtracao);
            }
        }

        private void bt_aplicarUsuarioSenha_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index == dataGridView.RowCount - 1) return;
                row.Cells[2].Value = tb_usuario.Text;
                row.Cells[3].Value = tb_senha.Text;
            }
        }

        private void bt_aplicarNomeArquivos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index == dataGridView.RowCount - 1) return;
                row.Cells[5].Value += tb_nomeArquivos.Text;
            }


        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja limpar os dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) dataGridView.Rows.Clear();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CsvClass.SaveAs();
                dataGridView.RefreshEdit();
            }
        }

        private void RemoveDgvEmptyLines()
        {
            dataGridView.EndEdit();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool isEmpty = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() != "")
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty && !row.IsNewRow)
                    dataGridView.Rows.Remove(row);

            }
        }

        private void dataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool marcar = !Convert.ToBoolean(dataGridView.Rows[0].Cells[0].Value);

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows[i].Cells[0].Value = marcar;
            }
        }

        private void bt_scriptPath_Click(object sender, EventArgs e)
        {
            tb_scriptPath.Text = CsvClass.OpenFile();
            Properties.Settings.Default.LastScriptPath = tb_scriptPath.Text;
            Properties.Settings.Default.Save();
        }

        private void bt_outputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                tb_outputPath.Text = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.LastOutputPath = tb_outputPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void tb_outputPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastOutputPath = tb_outputPath.Text;
            Properties.Settings.Default.Save();
        }

        private async void bt_executar_Click(object sender, EventArgs e)
        {
            //Chama o método em forma de task para que a interface continue respondendo durante a extração
            await Task.Run(() => { Executar_Extracao(); });
        }

        private void Executar_Extracao()
        {
            if (extracting)
            {
                MessageBox.Show("Já existe uma extração em andamento, favor aguardar.", "Aguarde...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string query;
            string[] queryMulti;

            if (cb_script_temporario.Checked)
                query = File.ReadAllText(pathScriptTemporario);

            else
            {
                if (!File.Exists(tb_scriptPath.Text))
                {
                    MessageBox.Show($"Script {tb_scriptPath.Text} não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                query = File.ReadAllText(tb_scriptPath.Text);
            }

            //Bob o executor, pode execultar multiplas querys
            queryMulti = Sql.SplitSql(query);

            //Remove o ponto e vírgula do final se tiver
            Sql.CleanQuery(ref query);

            //Exibe o formulario de parâmetros, caso hajam
            ParametersForm parametersForm = new ParametersForm(query);
            parametersForm.ShowDialog();
            if (!parametersForm.confirmado) return;

            query = parametersForm.query;

            int count = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
                if (Convert.ToBoolean(row.Cells[0].Value)) count++;

            Task[] tasks = new Task[count];
            SetStatus("Executando, por favor aguarde...");
            extracting = true;

            for (int i = 0, j = 0; i < dataGridView.Rows.Count; i++)
            {
                if (!Convert.ToBoolean(dataGridView.Rows[i].Cells[0].Value)) continue;

                string serviceName = dataGridView.Rows[i].Cells[1].Value.ToString();
                string user = dataGridView.Rows[i].Cells[2].Value.ToString();
                string password = dataGridView.Rows[i].Cells[3].Value.ToString();
                string session = dataGridView.Rows[i].Cells[4].Value.ToString();

                if (BobOExecutor)
                {
                    tasks[j] = Task.Run(() => DataAcess.Execute(serviceName, user, password, session, queryMulti));
                }
                else
                {
                    string path = tb_outputPath.Text + "\\" + dataGridView.Rows[i].Cells[5].Value.ToString();
                    tasks[j] = Task.Run(() => DataAcess.Export(serviceName, user, password, session, path, query));
                }

                j++;

            }

            Task.WaitAll(tasks);

            MessageBox.Show("Extração Finalizada!", "Pronto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus("Pronto!");
            extracting = false;
        }


        //Método para alterar o status mesmo fora da thread principal
        private void SetStatus(string text)
        {
            if (lbl_status.InvokeRequired)
            {
                Action safeWrite = delegate { SetStatus(text); };
                lbl_status.Invoke(safeWrite);
            }
            else
                lbl_status.Text = text;
        }

        private void tb_outputPath_DoubleClick(object sender, EventArgs e)
            => Process.Start("explorer.exe", tb_outputPath.Text);


        private void tb_scriptPath_DoubleClick(object sender, EventArgs e)
            => Process.Start("explorer.exe", tb_scriptPath.Text);



        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula atual é uma célula de texto
            if (dataGridView[e.ColumnIndex, e.RowIndex] is DataGridViewTextBoxCell)
            {
                // Desmarca a seleção do texto na célula para não selecionar todo o texto sempre que entrar no campo
                dataGridView.BeginEdit(false);
                ((TextBox)dataGridView.EditingControl).SelectionLength = 0;
            }
        }


        private void ApagarScriptTemp()
        {
            if (File.Exists(pathScriptTemporario))
                File.Delete(pathScriptTemporario);
        }

        private void cb_script_temporario_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_script_temporario.Checked)
            {
                if (!Directory.Exists(Path.GetDirectoryName(pathScriptTemporario)))
                    Directory.CreateDirectory(Path.GetDirectoryName(pathScriptTemporario));


                if (!File.Exists(pathScriptTemporario))
                    File.Create(pathScriptTemporario).Close();

                Process.Start("explorer.exe", pathScriptTemporario);
            }
        }

        private void bt_altera_modo_Click(object sender, EventArgs e)
        {
            if (!BobOExecutor)
            {
                bt_altera_modo.Text = "Bob o EXECUTOR";
                BobOExecutor = true;
                this.Text = "Bob o EXECUTOR";

            }
            else
            {
                bt_altera_modo.Text = "Bob o Extrator";
                BobOExecutor = false;
                this.Text = "Bob o Extrator";
            }
        }


    }
}
