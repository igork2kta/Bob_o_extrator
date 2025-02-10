using System.Collections.Generic;
using System.Windows.Forms;

namespace Bob_o_extrator
{
    public partial class ExecucaoEmLoopForm : Form
    {
        public bool confirmado = false;
        public Dictionary<string, string> querys = new Dictionary<string, string>();
        string queryOriginal;
        public ExecucaoEmLoopForm(string queryOriginal)
        {
            InitializeComponent();

            this.queryOriginal = queryOriginal;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == btDefinirParametros.Index)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[btDefinirParametros.Index].Value?.ToString() == "True") return;

                string sufixoArquivo = dataGridView1.Rows[e.RowIndex].Cells[sufixo.Index].Value?.ToString();

                if (string.IsNullOrEmpty(sufixoArquivo))
                {
                    MessageBox.Show("É necessário informar o sufixo do arquivo primeiro!", "Atenção!");
                    return;
                }

                ParametersForm parametersForm = new ParametersForm(queryOriginal);
                parametersForm.ShowDialog();
                if (!parametersForm.confirmado) return;

                querys.Add(dataGridView1.Rows[e.RowIndex].Cells[sufixo.Index].Value.ToString(), parametersForm.query);
                dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                dataGridView1.Rows[e.RowIndex].Cells[btDefinirParametros.Index].Value = true;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string sufixoArquivo = e.Row.Cells[sufixo.Index].Value?.ToString();
            querys.Remove(sufixoArquivo);
        }

        private void bt_pronto_Click(object sender, System.EventArgs e)
        {
            confirmado = true;

            this.Close();
        }

        private void bt_cancelar_Click(object sender, System.EventArgs e)
        {
            confirmado = false;

            this.Close();
        }
    }
}
