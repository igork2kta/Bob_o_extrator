namespace Bob_o_extrator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tb_usuario = new System.Windows.Forms.TextBox();
            tb_senha = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dataGridView = new System.Windows.Forms.DataGridView();
            dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            schema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            exportar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            executar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            bt_exportar = new System.Windows.Forms.Button();
            bt_importar = new System.Windows.Forms.Button();
            bt_aplicarUsuarioSenha = new System.Windows.Forms.Button();
            bt_limpar = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            tb_scriptPath = new System.Windows.Forms.TextBox();
            bt_scriptPath = new System.Windows.Forms.Button();
            bt_executar = new System.Windows.Forms.Button();
            lbl_status = new System.Windows.Forms.Label();
            lbl_help = new System.Windows.Forms.Label();
            bt_outputPath = new System.Windows.Forms.Button();
            tb_outputPath = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            cb_script_temporario = new System.Windows.Forms.CheckBox();
            bt_altera_modo = new System.Windows.Forms.Button();
            tb_nomeArquivos = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            bt_aplicarNomeArquivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new System.Drawing.Point(65, 12);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new System.Drawing.Size(100, 23);
            tb_usuario.TabIndex = 0;
            // 
            // tb_senha
            // 
            tb_senha.Location = new System.Drawing.Point(218, 12);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new System.Drawing.Size(106, 23);
            tb_senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(173, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewCheckBoxColumn1, banco, usuario, senha, schema, nomeArquivo });
            dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            dataGridView.Location = new System.Drawing.Point(12, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(943, 306);
            dataGridView.TabIndex = 4;
            dataGridView.CellEnter += dataGridView_CellEnter;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            dataGridView.ColumnHeaderMouseDoubleClick += dataGridView_ColumnHeaderMouseDoubleClick;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "EXECUTAR";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // banco
            // 
            banco.HeaderText = "BANCO";
            banco.Name = "banco";
            banco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // usuario
            // 
            usuario.HeaderText = "USUARIO";
            usuario.Name = "usuario";
            // 
            // senha
            // 
            senha.HeaderText = "SENHA";
            senha.Name = "senha";
            // 
            // schema
            // 
            schema.HeaderText = "SCHEMA";
            schema.Name = "schema";
            // 
            // nomeArquivo
            // 
            nomeArquivo.HeaderText = "NOME ARQUIVO";
            nomeArquivo.Name = "nomeArquivo";
            nomeArquivo.Width = 370;
            // 
            // exportar
            // 
            exportar.HeaderText = "Exportar";
            exportar.Name = "exportar";
            // 
            // executar
            // 
            executar.HeaderText = "Executar";
            executar.Name = "executar";
            // 
            // bt_exportar
            // 
            bt_exportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_exportar.Location = new System.Drawing.Point(800, 435);
            bt_exportar.Name = "bt_exportar";
            bt_exportar.Size = new System.Drawing.Size(75, 23);
            bt_exportar.TabIndex = 5;
            bt_exportar.Text = "Exportar";
            bt_exportar.UseVisualStyleBackColor = true;
            bt_exportar.Click += bt_exportar_Click;
            // 
            // bt_importar
            // 
            bt_importar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_importar.Location = new System.Drawing.Point(881, 435);
            bt_importar.Name = "bt_importar";
            bt_importar.Size = new System.Drawing.Size(75, 23);
            bt_importar.TabIndex = 6;
            bt_importar.Text = "Importar";
            bt_importar.UseVisualStyleBackColor = true;
            bt_importar.Click += bt_importar_Click;
            // 
            // bt_aplicarUsuarioSenha
            // 
            bt_aplicarUsuarioSenha.Location = new System.Drawing.Point(333, 12);
            bt_aplicarUsuarioSenha.Name = "bt_aplicarUsuarioSenha";
            bt_aplicarUsuarioSenha.Size = new System.Drawing.Size(112, 23);
            bt_aplicarUsuarioSenha.TabIndex = 7;
            bt_aplicarUsuarioSenha.Text = "Aplicar em todos";
            bt_aplicarUsuarioSenha.UseVisualStyleBackColor = true;
            bt_aplicarUsuarioSenha.Click += bt_aplicarUsuarioSenha_Click;
            // 
            // bt_limpar
            // 
            bt_limpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_limpar.Location = new System.Drawing.Point(719, 435);
            bt_limpar.Name = "bt_limpar";
            bt_limpar.Size = new System.Drawing.Size(75, 23);
            bt_limpar.TabIndex = 8;
            bt_limpar.Text = "Limpar";
            bt_limpar.UseVisualStyleBackColor = true;
            bt_limpar.Click += bt_limpar_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 401);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "Script Path:";
            // 
            // tb_scriptPath
            // 
            tb_scriptPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_scriptPath.Location = new System.Drawing.Point(82, 398);
            tb_scriptPath.Name = "tb_scriptPath";
            tb_scriptPath.Size = new System.Drawing.Size(840, 23);
            tb_scriptPath.TabIndex = 10;
            tb_scriptPath.DoubleClick += tb_scriptPath_DoubleClick;
            // 
            // bt_scriptPath
            // 
            bt_scriptPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_scriptPath.Location = new System.Drawing.Point(928, 398);
            bt_scriptPath.Name = "bt_scriptPath";
            bt_scriptPath.Size = new System.Drawing.Size(27, 23);
            bt_scriptPath.TabIndex = 11;
            bt_scriptPath.Text = "...";
            bt_scriptPath.UseVisualStyleBackColor = true;
            bt_scriptPath.Click += bt_scriptPath_Click;
            // 
            // bt_executar
            // 
            bt_executar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bt_executar.Location = new System.Drawing.Point(12, 435);
            bt_executar.Name = "bt_executar";
            bt_executar.Size = new System.Drawing.Size(75, 23);
            bt_executar.TabIndex = 12;
            bt_executar.Text = "Executar";
            bt_executar.UseVisualStyleBackColor = true;
            bt_executar.Click += bt_executar_Click;
            // 
            // lbl_status
            // 
            lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lbl_status.AutoSize = true;
            lbl_status.Location = new System.Drawing.Point(93, 439);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new System.Drawing.Size(46, 15);
            lbl_status.TabIndex = 13;
            lbl_status.Text = "Pronto!";
            // 
            // lbl_help
            // 
            lbl_help.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbl_help.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_help.Image = Properties.Resources.HelpTableOfContents;
            lbl_help.Location = new System.Drawing.Point(945, 3);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new System.Drawing.Size(20, 18);
            lbl_help.TabIndex = 20;
            // 
            // bt_outputPath
            // 
            bt_outputPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_outputPath.Location = new System.Drawing.Point(928, 369);
            bt_outputPath.Name = "bt_outputPath";
            bt_outputPath.Size = new System.Drawing.Size(26, 23);
            bt_outputPath.TabIndex = 23;
            bt_outputPath.Text = "...";
            bt_outputPath.UseVisualStyleBackColor = true;
            bt_outputPath.Click += bt_outputPath_Click;
            // 
            // tb_outputPath
            // 
            tb_outputPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_outputPath.Location = new System.Drawing.Point(82, 369);
            tb_outputPath.Name = "tb_outputPath";
            tb_outputPath.Size = new System.Drawing.Size(839, 23);
            tb_outputPath.TabIndex = 22;
            tb_outputPath.TextChanged += tb_outputPath_TextChanged;
            tb_outputPath.DoubleClick += tb_outputPath_DoubleClick;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 372);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 21;
            label4.Text = "Path saída:";
            // 
            // cb_script_temporario
            // 
            cb_script_temporario.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cb_script_temporario.AutoSize = true;
            cb_script_temporario.Location = new System.Drawing.Point(594, 438);
            cb_script_temporario.Name = "cb_script_temporario";
            cb_script_temporario.Size = new System.Drawing.Size(119, 19);
            cb_script_temporario.TabIndex = 25;
            cb_script_temporario.Text = "Script Temporário";
            cb_script_temporario.UseVisualStyleBackColor = true;
            cb_script_temporario.CheckedChanged += cb_script_temporario_CheckedChanged;
            // 
            // bt_altera_modo
            // 
            bt_altera_modo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bt_altera_modo.Location = new System.Drawing.Point(832, 3);
            bt_altera_modo.Name = "bt_altera_modo";
            bt_altera_modo.Size = new System.Drawing.Size(107, 23);
            bt_altera_modo.TabIndex = 26;
            bt_altera_modo.Text = "Bob o extrator";
            bt_altera_modo.UseVisualStyleBackColor = true;
            bt_altera_modo.Click += bt_altera_modo_Click;
            // 
            // tb_nomeArquivos
            // 
            tb_nomeArquivos.Location = new System.Drawing.Point(576, 12);
            tb_nomeArquivos.Name = "tb_nomeArquivos";
            tb_nomeArquivos.Size = new System.Drawing.Size(106, 23);
            tb_nomeArquivos.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(480, 16);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 15);
            label5.TabIndex = 28;
            label5.Text = "Nome Arquivos";
            // 
            // bt_aplicarNomeArquivos
            // 
            bt_aplicarNomeArquivos.Location = new System.Drawing.Point(688, 11);
            bt_aplicarNomeArquivos.Name = "bt_aplicarNomeArquivos";
            bt_aplicarNomeArquivos.Size = new System.Drawing.Size(112, 23);
            bt_aplicarNomeArquivos.TabIndex = 29;
            bt_aplicarNomeArquivos.Text = "Aplicar em todos";
            bt_aplicarNomeArquivos.UseVisualStyleBackColor = true;
            bt_aplicarNomeArquivos.Click += bt_aplicarNomeArquivos_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(968, 470);
            Controls.Add(bt_aplicarNomeArquivos);
            Controls.Add(label5);
            Controls.Add(tb_nomeArquivos);
            Controls.Add(bt_altera_modo);
            Controls.Add(cb_script_temporario);
            Controls.Add(bt_outputPath);
            Controls.Add(tb_outputPath);
            Controls.Add(label4);
            Controls.Add(lbl_help);
            Controls.Add(lbl_status);
            Controls.Add(bt_executar);
            Controls.Add(bt_scriptPath);
            Controls.Add(tb_scriptPath);
            Controls.Add(label3);
            Controls.Add(bt_limpar);
            Controls.Add(bt_aplicarUsuarioSenha);
            Controls.Add(bt_importar);
            Controls.Add(bt_exportar);
            Controls.Add(dataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_senha);
            Controls.Add(tb_usuario);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Bob o Extrator";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exportar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn executar;
        private System.Windows.Forms.Button bt_exportar;
        private System.Windows.Forms.Button bt_importar;
        private System.Windows.Forms.Button bt_aplicarUsuarioSenha;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_scriptPath;
        private System.Windows.Forms.Button bt_scriptPath;
        private System.Windows.Forms.Button bt_executar;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Button bt_outputPath;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn schema;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeArquivo;
        private System.Windows.Forms.CheckBox cb_script_temporario;
        private System.Windows.Forms.Button bt_altera_modo;
        private System.Windows.Forms.TextBox tb_nomeArquivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_aplicarNomeArquivos;
    }
}
