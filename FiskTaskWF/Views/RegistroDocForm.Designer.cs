namespace FiscoTask
{
    partial class RegistroDocForm
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
            txtLivro = new TextBox();
            dgEmpresas = new DataGridView();
            eMPRESADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cNPJDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOMEFANTASIADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cIDADEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empresaViewBindingSource = new BindingSource(components);
            txtPesquisa = new TextBox();
            label6 = new Label();
            label16 = new Label();
            label17 = new Label();
            cbTipoDoc = new ComboBox();
            bDdoctypeBindingSource = new BindingSource(components);
            dtpVencimento = new DateTimePicker();
            rtbObs = new RichTextBox();
            label3 = new Label();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bDdoctypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Documentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 293);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Livro";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(74, 290);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(109, 23);
            txtLivro.TabIndex = 2;
            // 
            // dgEmpresas
            // 
            dgEmpresas.AutoGenerateColumns = false;
            dgEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpresas.Columns.AddRange(new DataGridViewColumn[] { eMPRESADataGridViewTextBoxColumn, nOMEDataGridViewTextBoxColumn, cNPJDataGridViewTextBoxColumn, nOMEFANTASIADataGridViewTextBoxColumn, cIDADEDataGridViewTextBoxColumn });
            dgEmpresas.DataSource = empresaViewBindingSource;
            dgEmpresas.Location = new Point(12, 75);
            dgEmpresas.Name = "dgEmpresas";
            dgEmpresas.Size = new Size(881, 150);
            dgEmpresas.TabIndex = 3;
            dgEmpresas.CellDoubleClick += dgEmpresas_CellDoubleClick;
            // 
            // eMPRESADataGridViewTextBoxColumn
            // 
            eMPRESADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            eMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA";
            eMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA";
            eMPRESADataGridViewTextBoxColumn.Name = "eMPRESADataGridViewTextBoxColumn";
            eMPRESADataGridViewTextBoxColumn.Width = 83;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            nOMEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            nOMEDataGridViewTextBoxColumn.Width = 67;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // nOMEFANTASIADataGridViewTextBoxColumn
            // 
            nOMEFANTASIADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEFANTASIADataGridViewTextBoxColumn.DataPropertyName = "NOMEFANTASIA";
            nOMEFANTASIADataGridViewTextBoxColumn.HeaderText = "NOMEFANTASIA";
            nOMEFANTASIADataGridViewTextBoxColumn.Name = "nOMEFANTASIADataGridViewTextBoxColumn";
            nOMEFANTASIADataGridViewTextBoxColumn.Width = 119;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            cIDADEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            cIDADEDataGridViewTextBoxColumn.Width = 73;
            // 
            // empresaViewBindingSource
            // 
            empresaViewBindingSource.DataSource = typeof(EmpresaView);
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(122, 46);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(503, 23);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 380);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 11;
            label6.Text = "Obs";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(35, 352);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 31;
            label16.Text = "Vencimento";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(35, 322);
            label17.Name = "label17";
            label17.Size = new Size(112, 15);
            label17.TabIndex = 33;
            label17.Text = "Tipo de Documento";
            // 
            // cbTipoDoc
            // 
            cbTipoDoc.DataSource = bDdoctypeBindingSource;
            cbTipoDoc.FormattingEnabled = true;
            cbTipoDoc.Location = new Point(153, 319);
            cbTipoDoc.Name = "cbTipoDoc";
            cbTipoDoc.Size = new Size(210, 23);
            cbTipoDoc.TabIndex = 34;
            // 
            // bDdoctypeBindingSource
            // 
            bDdoctypeBindingSource.DataMember = "BDdoctype";
            // 
            // dtpVencimento
            // 
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.Location = new Point(109, 348);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(227, 23);
            dtpVencimento.TabIndex = 35;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(74, 380);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(289, 168);
            rtbObs.TabIndex = 36;
            rtbObs.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 37;
            label3.Text = "Nome da Empresa";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(457, 293);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 38;
            btnInsert.Text = "Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // RegistroDocForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 631);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(rtbObs);
            Controls.Add(dtpVencimento);
            Controls.Add(cbTipoDoc);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(txtPesquisa);
            Controls.Add(dgEmpresas);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroDocForm";
            Text = "Cadastro de Documentos";
            FormClosing += RegistroDocForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bDdoctypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLivro;
        private DataGridView dgEmpresas;
        private DataGridViewTextBoxColumn eMPRESADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEFANTASIADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private BindingSource empresaViewBindingSource;
        private TextBox txtPesquisa;
        private Label label6;
        private Label label16;
        private Label label17;
        private ComboBox cbTipoDoc;
        private DateTimePicker dtpVencimento;
        private RichTextBox rtbObs;
        private Label label3;
        private BindingSource bDdoctypeBindingSource;
        private Button btnInsert;
    }
}