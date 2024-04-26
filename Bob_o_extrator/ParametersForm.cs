using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bob_o_extrator
{
    public partial class ParametersForm : Form
    {
        public bool confirmado = false;
        private List<string> ocorrencias;
        public string query;
        public ParametersForm(string query)
        {
            InitializeComponent();
            this.query = query;
        }

        private void ParametersFrm_Load(object sender, EventArgs e)
        {
            ocorrencias = Sql.GetParameters(query);
            if (ocorrencias.Count < 1)
            {
                confirmado = true;
                Close();
            }
            AdicionarTextBoxes();
        }

        private void AdicionarTextBoxes()
        {
            foreach (string ocorrencia in ocorrencias)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;

                Label label = new Label();
                label.Text = ocorrencia;
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Width = 150;
                panel.Height = 50;
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                flowLayoutPanel.Controls.Add(panel);

            }
        }

        private void bt_pronto_Click(object sender, EventArgs e)
        {
            List<string> substitutos = new List<string>();
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is FlowLayoutPanel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is TextBox)
                        {
                            substitutos.Add(((TextBox)innerControl).Text);
                        }
                    }
                }
            }

            query = Sql.ReplaceParameters(query, ocorrencias, substitutos);
            confirmado = true;

            this.Close();
        }
    }
}
