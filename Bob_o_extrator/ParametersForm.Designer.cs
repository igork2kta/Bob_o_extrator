namespace Bob_o_extrator
{
    partial class ParametersForm
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
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            bt_pronto = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new System.Drawing.Size(262, 281);
            flowLayoutPanel.TabIndex = 0;
            // 
            // bt_pronto
            // 
            bt_pronto.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bt_pronto.Location = new System.Drawing.Point(199, 303);
            bt_pronto.Name = "bt_pronto";
            bt_pronto.Size = new System.Drawing.Size(75, 23);
            bt_pronto.TabIndex = 1;
            bt_pronto.Text = "Pronto";
            bt_pronto.UseVisualStyleBackColor = true;
            bt_pronto.Click += bt_pronto_Click;
            // 
            // ParametersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(287, 338);
            Controls.Add(bt_pronto);
            Controls.Add(flowLayoutPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParametersForm";
            ShowIcon = false;
            Text = "Parâmetros";
            Load += ParametersFrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bt_pronto;
    }
}