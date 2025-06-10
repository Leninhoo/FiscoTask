namespace FiscoTask
{
    partial class ConsultaAtosEmpresariaisForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtPesquisa = new TextBox();
            dgAtosEmpresariais = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DATA = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            RAZAO = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            LIVRO = new DataGridViewTextBoxColumn();
            ESCRITORIO = new DataGridViewTextBoxColumn();
            RESPONSAVEL_INTERNO = new DataGridViewTextBoxColumn();
            PROTOCOLO_EMPRESAFACIL = new DataGridViewTextBoxColumn();
            OBS = new DataGridViewTextBoxColumn();
            dbAtosEmpresariaisBindingSource = new BindingSource(components);
            btnAtualizar = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAtosEmpresariais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbAtosEmpresariaisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 30);
            label1.TabIndex = 6;
            label1.Text = "Consultar atos empresariais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 7;
            label2.Text = "Pesquisa por empresa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(140, 137);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(532, 23);
            txtPesquisa.TabIndex = 8;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // dgAtosEmpresariais
            // 
            dgAtosEmpresariais.AllowUserToAddRows = false;
            dgAtosEmpresariais.AllowUserToDeleteRows = false;
            dgAtosEmpresariais.AutoGenerateColumns = false;
            dgAtosEmpresariais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAtosEmpresariais.Columns.AddRange(new DataGridViewColumn[] { ID, DATA, TIPO, RAZAO, CNPJ, LIVRO, ESCRITORIO, RESPONSAVEL_INTERNO, PROTOCOLO_EMPRESAFACIL, OBS });
            dgAtosEmpresariais.DataSource = dbAtosEmpresariaisBindingSource;
            dgAtosEmpresariais.Location = new Point(12, 183);
            dgAtosEmpresariais.Name = "dgAtosEmpresariais";
            dgAtosEmpresariais.ReadOnly = true;
            dgAtosEmpresariais.Size = new Size(1293, 290);
            dgAtosEmpresariais.TabIndex = 9;
            dgAtosEmpresariais.CellDoubleClick += dgAtosEmpresariais_CellDoubleClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 43;
            // 
            // DATA
            // 
            DATA.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DATA.DataPropertyName = "DATA";
            DATA.HeaderText = "DATA";
            DATA.Name = "DATA";
            DATA.ReadOnly = true;
            DATA.Width = 60;
            // 
            // TIPO
            // 
            TIPO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TIPO.DataPropertyName = "TIPO";
            TIPO.HeaderText = "TIPO";
            TIPO.Name = "TIPO";
            TIPO.ReadOnly = true;
            TIPO.Width = 57;
            // 
            // RAZAO
            // 
            RAZAO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RAZAO.DataPropertyName = "RAZAO";
            RAZAO.HeaderText = "RAZAO";
            RAZAO.Name = "RAZAO";
            RAZAO.ReadOnly = true;
            RAZAO.Width = 71;
            // 
            // CNPJ
            // 
            CNPJ.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CNPJ.DataPropertyName = "CNPJ";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.Name = "CNPJ";
            CNPJ.ReadOnly = true;
            CNPJ.Width = 59;
            // 
            // LIVRO
            // 
            LIVRO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            LIVRO.DataPropertyName = "LIVRO";
            LIVRO.HeaderText = "LIVRO";
            LIVRO.Name = "LIVRO";
            LIVRO.ReadOnly = true;
            LIVRO.Width = 64;
            // 
            // ESCRITORIO
            // 
            ESCRITORIO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ESCRITORIO.DataPropertyName = "ESCRITORIO";
            ESCRITORIO.HeaderText = "ESCRITORIO";
            ESCRITORIO.Name = "ESCRITORIO";
            ESCRITORIO.ReadOnly = true;
            ESCRITORIO.Width = 95;
            // 
            // RESPONSAVEL_INTERNO
            // 
            RESPONSAVEL_INTERNO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RESPONSAVEL_INTERNO.DataPropertyName = "RESPONSAVEL_INTERNO";
            RESPONSAVEL_INTERNO.HeaderText = "RESPONSAVEL_INTERNO";
            RESPONSAVEL_INTERNO.Name = "RESPONSAVEL_INTERNO";
            RESPONSAVEL_INTERNO.ReadOnly = true;
            RESPONSAVEL_INTERNO.Width = 162;
            // 
            // PROTOCOLO_EMPRESAFACIL
            // 
            PROTOCOLO_EMPRESAFACIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PROTOCOLO_EMPRESAFACIL.DataPropertyName = "PROTOCOLO_EMPRESAFACIL";
            PROTOCOLO_EMPRESAFACIL.HeaderText = "PROTOCOLO_EMPRESAFACIL";
            PROTOCOLO_EMPRESAFACIL.Name = "PROTOCOLO_EMPRESAFACIL";
            PROTOCOLO_EMPRESAFACIL.ReadOnly = true;
            PROTOCOLO_EMPRESAFACIL.Width = 186;
            // 
            // OBS
            // 
            OBS.DataPropertyName = "OBS";
            OBS.HeaderText = "OBS";
            OBS.Name = "OBS";
            OBS.ReadOnly = true;
            // 
            // dbAtosEmpresariaisBindingSource
            // 
            dbAtosEmpresariaisBindingSource.DataSource = typeof(dbAtosEmpresariais);
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(12, 90);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExport
            // 
            btnExport.Image = Properties.Resources.file_type_excel_icon_130611__1_;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(12, 479);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(93, 38);
            btnExport.TabIndex = 19;
            btnExport.Text = "Exportar";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // ConsultaAtosEmpresariaisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 635);
            Controls.Add(btnExport);
            Controls.Add(btnAtualizar);
            Controls.Add(dgAtosEmpresariais);
            Controls.Add(txtPesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaAtosEmpresariaisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atos Empresariais";
            ((System.ComponentModel.ISupportInitialize)dgAtosEmpresariais).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbAtosEmpresariaisBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPesquisa;
        private DataGridView dgAtosEmpresariais;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn RAZAO;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn LIVRO;
        private DataGridViewTextBoxColumn ESCRITORIO;
        private DataGridViewTextBoxColumn RESPONSAVEL_INTERNO;
        private DataGridViewTextBoxColumn PROTOCOLO_EMPRESAFACIL;
        private DataGridViewTextBoxColumn OBS;
        private BindingSource dbAtosEmpresariaisBindingSource;
        private Button btnAtualizar;
        private Button btnExport;
    }
}