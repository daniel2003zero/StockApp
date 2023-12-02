namespace StockApp.WindowsForms.Cadastros
{
    partial class frmCategoria
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
            groupBox1 = new GroupBox();
            txtNome = new TextBox();
            chkStatus = new CheckBox();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(chkStatus);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar categoria";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 33);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "txtNome";
            txtNome.Size = new Size(100, 29);
            txtNome.TabIndex = 0;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(138, 37);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(160, 25);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Ativo (chkStatus)";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(244, 153);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(165, 43);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar (btnSalvar)";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkStatus;
        private TextBox txtNome;
        private Button btnSalvar;
    }
}