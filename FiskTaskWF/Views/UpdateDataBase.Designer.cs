namespace FiscoTask.Views
{
    partial class UpdateDataBase
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
            btnUpdate = new Button();
            rtbLog = new RichTextBox();
            btnAtualizarBanco = new Button();
            txtCaminho = new TextBox();
            label1 = new Label();
            btnSelecionar = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 26);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Teste de conexão";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(12, 304);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(776, 134);
            rtbLog.TabIndex = 1;
            rtbLog.Text = "log";
            // 
            // btnAtualizarBanco
            // 
            btnAtualizarBanco.Location = new Point(12, 12);
            btnAtualizarBanco.Name = "btnAtualizarBanco";
            btnAtualizarBanco.Size = new Size(175, 23);
            btnAtualizarBanco.TabIndex = 2;
            btnAtualizarBanco.Text = "Atualizar Banco de dados";
            btnAtualizarBanco.UseVisualStyleBackColor = true;
            btnAtualizarBanco.Click += btnAtualizarBanco_Click;
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(141, 47);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(528, 23);
            txtCaminho.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 50);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 4;
            label1.Text = "Caminho do Arquivo";
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(675, 47);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(46, 23);
            btnSelecionar.TabIndex = 5;
            btnSelecionar.Text = "Abrir";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // UpdateDataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelecionar);
            Controls.Add(label1);
            Controls.Add(txtCaminho);
            Controls.Add(btnAtualizarBanco);
            Controls.Add(rtbLog);
            Controls.Add(btnUpdate);
            Name = "UpdateDataBase";
            Text = "UpdateDataBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private RichTextBox rtbLog;
        private Button btnAtualizarBanco;
        private TextBox txtCaminho;
        private Label label1;
        private Button btnSelecionar;
    }
}