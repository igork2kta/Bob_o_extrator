namespace Bob_o_extrator
{
    partial class ExecucaoEmLoopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            sufixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btDefinirParametros = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            bt_pronto = new System.Windows.Forms.Button();
            bt_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { sufixo, btDefinirParametros });
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(293, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // sufixo
            // 
            sufixo.HeaderText = "Sufixo Arquivo";
            sufixo.Name = "sufixo";
            sufixo.Width = 125;
            // 
            // btDefinirParametros
            // 
            btDefinirParametros.HeaderText = "Definir Parâmetros";
            btDefinirParametros.Name = "btDefinirParametros";
            btDefinirParametros.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            btDefinirParametros.Width = 125;
            // 
            // bt_pronto
            // 
            bt_pronto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bt_pronto.Location = new System.Drawing.Point(12, 280);
            bt_pronto.Name = "bt_pronto";
            bt_pronto.Size = new System.Drawing.Size(75, 23);
            bt_pronto.TabIndex = 1;
            bt_pronto.Text = "Pronto!";
            bt_pronto.UseVisualStyleBackColor = true;
            bt_pronto.Click += bt_pronto_Click;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bt_cancelar.Location = new System.Drawing.Point(93, 280);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new System.Drawing.Size(75, 23);
            bt_cancelar.TabIndex = 2;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // ExecucaoEmLoopForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(317, 306);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_pronto);
            Controls.Add(dataGridView1);
            Name = "ExecucaoEmLoopForm";
            ShowIcon = false;
            Text = "ExecucaoEmLoopForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_pronto;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sufixo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btDefinirParametros;
    }
}