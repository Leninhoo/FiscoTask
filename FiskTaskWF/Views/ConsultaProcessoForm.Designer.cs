namespace FiscoTask.Views
{
    partial class ConsultaProcessoForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgProcessos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            TipoProcesso = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            Andamento = new DataGridViewTextBoxColumn();
            Filtro = new DataGridViewTextBoxColumn();
            DtRegistro = new DataGridViewTextBoxColumn();
            DataModificacao = new DataGridViewTextBoxColumn();
            dbProcessosBindingSource = new BindingSource(components);
            txtPesquisa = new TextBox();
            Pesquisar = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            cbTipo = new ComboBox();
            label8 = new Label();
            cbAndamento = new ComboBox();
            label6 = new Label();
            cbSituacao = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            lblQuantidade = new Label();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProcessos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbProcessosBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgProcessos
            // 
            dgProcessos.AllowUserToAddRows = false;
            dgProcessos.AllowUserToDeleteRows = false;
            dgProcessos.AutoGenerateColumns = false;
            dgProcessos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProcessos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Empresa, Nome, Cidade, TipoProcesso, Situacao, Andamento, Filtro, DtRegistro, DataModificacao });
            dgProcessos.DataSource = dbProcessosBindingSource;
            dgProcessos.Location = new Point(12, 219);
            dgProcessos.Name = "dgProcessos";
            dgProcessos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgProcessos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgProcessos.Size = new Size(989, 298);
            dgProcessos.TabIndex = 0;
            dgProcessos.CellDoubleClick += dgProcessos_CellDoubleClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 71;
            // 
            // Empresa
            // 
            Empresa.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Empresa.DataPropertyName = "Empresa";
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            Empresa.Width = 77;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nome.DataPropertyName = "NOME";
            Nome.HeaderText = "NOME";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 67;
            // 
            // Cidade
            // 
            Cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Cidade.DataPropertyName = "CIDADE";
            Cidade.HeaderText = "CIDADE";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Width = 73;
            // 
            // TipoProcesso
            // 
            TipoProcesso.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TipoProcesso.DataPropertyName = "TipoProcesso";
            TipoProcesso.HeaderText = "Tipo Processo";
            TipoProcesso.Name = "TipoProcesso";
            TipoProcesso.ReadOnly = true;
            TipoProcesso.Width = 97;
            // 
            // Situacao
            // 
            Situacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Situacao.DataPropertyName = "Situacao";
            Situacao.HeaderText = "Situacao";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            Situacao.Width = 77;
            // 
            // Andamento
            // 
            Andamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Andamento.DataPropertyName = "Andamento";
            Andamento.HeaderText = "Andamento";
            Andamento.Name = "Andamento";
            Andamento.ReadOnly = true;
            Andamento.Width = 95;
            // 
            // Filtro
            // 
            Filtro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Filtro.DataPropertyName = "Filtro";
            Filtro.HeaderText = "Filtro";
            Filtro.Name = "Filtro";
            Filtro.ReadOnly = true;
            Filtro.Width = 59;
            // 
            // DtRegistro
            // 
            DtRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DtRegistro.DataPropertyName = "Dtregistro";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            DtRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            DtRegistro.HeaderText = "Data de Registro";
            DtRegistro.Name = "DtRegistro";
            DtRegistro.ReadOnly = true;
            DtRegistro.Width = 108;
            // 
            // DataModificacao
            // 
            DataModificacao.DataPropertyName = "DataModificacao";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            DataModificacao.DefaultCellStyle = dataGridViewCellStyle2;
            DataModificacao.HeaderText = "Data de Modificação";
            DataModificacao.Name = "DataModificacao";
            DataModificacao.ReadOnly = true;
            // 
            // dbProcessosBindingSource
            // 
            dbProcessosBindingSource.DataSource = typeof(DataBase.DbProcessos);
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(75, 149);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(405, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.Location = new Point(12, 152);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(57, 15);
            Pesquisar.TabIndex = 2;
            Pesquisar.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbAndamento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbSituacao);
            groupBox1.Location = new Point(734, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 132);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 94);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 28;
            label9.Text = "Tipo Processo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(99, 91);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(230, 23);
            cbTipo.TabIndex = 27;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 65);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 26;
            label8.Text = "Andamento";
            // 
            // cbAndamento
            // 
            cbAndamento.FormattingEnabled = true;
            cbAndamento.Location = new Point(88, 62);
            cbAndamento.Name = "cbAndamento";
            cbAndamento.Size = new Size(224, 23);
            cbAndamento.TabIndex = 25;
            cbAndamento.SelectedIndexChanged += cbAndamento_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 36);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 24;
            label6.Text = "Situação";
            // 
            // cbSituacao
            // 
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(71, 33);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(224, 23);
            cbSituacao.TabIndex = 23;
            cbSituacao.SelectedIndexChanged += cbSituacao_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(208, 30);
            label1.TabIndex = 6;
            label1.Text = "Consultar Processos";
            // 
            // button1
            // 
            button1.Location = new Point(40, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblQuantidade);
            groupBox2.Location = new Point(265, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações processos";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(6, 32);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(214, 15);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "A quantidade de processos ativos é de: ";
            // 
            // btnExcel
            // 
            btnExcel.Image = Properties.Resources.file_type_excel_icon_130611__1_;
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(667, 164);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(182, 36);
            btnExcel.TabIndex = 9;
            btnExcel.Text = "Exportar dados para Excel";
            btnExcel.TextAlign = ContentAlignment.MiddleRight;
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // ConsultaProcessoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 546);
            Controls.Add(btnExcel);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(Pesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(dgProcessos);
            Name = "ConsultaProcessoForm";
            Text = "Consultar Processos";
            ((System.ComponentModel.ISupportInitialize)dgProcessos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbProcessosBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProcessos;
        private TextBox txtPesquisa;
        private Label Pesquisar;
        private BindingSource dbProcessosBindingSource;
        private GroupBox groupBox1;
        private Label label9;
        private ComboBox cbTipo;
        private Label label8;
        private ComboBox cbAndamento;
        private Label label6;
        private ComboBox cbSituacao;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn TipoProcesso;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn Andamento;
        private DataGridViewTextBoxColumn Filtro;
        private DataGridViewTextBoxColumn DtRegistro;
        private DataGridViewTextBoxColumn DataModificacao;
        private GroupBox groupBox2;
        private Label lblQuantidade;
        private Button btnExcel;
    }
}