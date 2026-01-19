namespace Gestor_de_Habitos_Saudaveis
{
    partial class Form1
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
            TB_habitos = new TextBox();
            CB_regularidades = new ComboBox();
            LB_listhabitos = new ListBox();
            BT_aplica = new Button();
            BT_limpar = new Button();
            BT_marcar = new Button();
            SuspendLayout();
            // 
            // TB_habitos
            // 
            TB_habitos.Location = new Point(51, 45);
            TB_habitos.Margin = new Padding(3, 4, 3, 4);
            TB_habitos.Name = "TB_habitos";
            TB_habitos.Size = new Size(139, 27);
            TB_habitos.TabIndex = 0;
            // 
            // CB_regularidades
            // 
            CB_regularidades.FormattingEnabled = true;
            CB_regularidades.Items.AddRange(new object[] { "Diario", "Semanal", "Mensal" });
            CB_regularidades.Location = new Point(196, 46);
            CB_regularidades.Margin = new Padding(3, 4, 3, 4);
            CB_regularidades.Name = "CB_regularidades";
            CB_regularidades.Size = new Size(139, 28);
            CB_regularidades.TabIndex = 1;
            // 
            // LB_listhabitos
            // 
            LB_listhabitos.FormattingEnabled = true;
            LB_listhabitos.Location = new Point(51, 82);
            LB_listhabitos.Margin = new Padding(3, 4, 3, 4);
            LB_listhabitos.Name = "LB_listhabitos";
            LB_listhabitos.Size = new Size(284, 184);
            LB_listhabitos.TabIndex = 4;
            // 
            // BT_aplica
            // 
            BT_aplica.Location = new Point(341, 45);
            BT_aplica.Margin = new Padding(3, 4, 3, 4);
            BT_aplica.Name = "BT_aplica";
            BT_aplica.Size = new Size(80, 28);
            BT_aplica.TabIndex = 2;
            BT_aplica.Text = "Aplicar";
            BT_aplica.UseVisualStyleBackColor = true;
            BT_aplica.Click += BT_aplica_Click;
            // 
            // BT_limpar
            // 
            BT_limpar.Location = new Point(341, 118);
            BT_limpar.Margin = new Padding(3, 4, 3, 4);
            BT_limpar.Name = "BT_limpar";
            BT_limpar.Size = new Size(80, 28);
            BT_limpar.TabIndex = 3;
            BT_limpar.Text = "Limpar";
            BT_limpar.UseVisualStyleBackColor = true;
            BT_limpar.Click += bt_limpar_Click;
            // 
            // BT_marcar
            // 
            BT_marcar.Location = new Point(341, 82);
            BT_marcar.Margin = new Padding(3, 4, 3, 4);
            BT_marcar.Name = "BT_marcar";
            BT_marcar.Size = new Size(80, 28);
            BT_marcar.TabIndex = 3;
            BT_marcar.Text = "Marcar";
            BT_marcar.UseVisualStyleBackColor = true;
            BT_marcar.Click += bt_marcar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 304);
            Controls.Add(BT_marcar);
            Controls.Add(BT_limpar);
            Controls.Add(BT_aplica);
            Controls.Add(LB_listhabitos);
            Controls.Add(CB_regularidades);
            Controls.Add(TB_habitos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Teste-diagonostico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_habitos;
        private ComboBox CB_regularidades;
        private ListBox LB_listhabitos;
        private Button BT_aplica;
        private Button BT_limpar;
        private Button BT_marcar;
    }
}
