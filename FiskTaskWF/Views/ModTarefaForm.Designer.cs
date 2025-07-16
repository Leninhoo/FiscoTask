namespace FiscoTask
{
    partial class ModTarefaForm
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
            rtbObs = new RichTextBox();
            label5 = new Label();
            cbFase = new ComboBox();
            label4 = new Label();
            CbSituacao = new ComboBox();
            label3 = new Label();
            txtLivro = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            btnApagar = new Button();
            btnCancelar = new Button();
            cbBombeiro = new CheckBox();
            cbVigilanciaSanitaria = new CheckBox();
            cbTaxaAlvaraPgto = new CheckBox();
            groupBox2 = new GroupBox();
            cbEntregaTaxaAlvara = new CheckBox();
            cbAtivo = new CheckBox();
            label14 = new Label();
            btnCarimbo = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label13 = new Label();
            dgDocumentos = new DataGridView();
            idDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            livroDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nOMEDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dtRegistroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vencimentodocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exercicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dbDocumentsBindingSource1 = new BindingSource(components);
            label12 = new Label();
            dgBombeiro = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            livroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pROCESSODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dATAREGISTRODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dbBombeirosBindingSource1 = new BindingSource(components);
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            txtCEP = new TextBox();
            label15 = new Label();
            txtEstado = new TextBox();
            label16 = new Label();
            txtCidade1 = new TextBox();
            label17 = new Label();
            txtComplemento = new TextBox();
            label18 = new Label();
            txtBairro = new TextBox();
            label19 = new Label();
            txtNumero = new TextBox();
            label20 = new Label();
            txtEndereco = new TextBox();
            label21 = new Label();
            groupBox1 = new GroupBox();
            txtResponsavel = new TextBox();
            label11 = new Label();
            txtDataRegistro = new TextBox();
            label10 = new Label();
            txtCNPJ = new TextBox();
            txtCidade = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            txtEmpresa = new TextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            registrarBombeiroControl1 = new RegistrarBombeiroControl();
            tabPage4 = new TabPage();
            registroDocumentoControl1 = new RegistroDocumentoControl();
            recControl1 = new RecControl();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgBombeiro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbBombeirosBindingSource1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 4;
            label1.Text = "Atualizar Status de Tarefas";
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(1140, 294);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(515, 294);
            rtbObs.TabIndex = 1;
            rtbObs.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 397);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 22;
            label5.Text = "Histórico e Comentários";
            // 
            // cbFase
            // 
            cbFase.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFase.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFase.FormattingEnabled = true;
            cbFase.ItemHeight = 15;
            cbFase.Items.AddRange(new object[] { "Aguardando terceiro", "Pendência empresa", "Para avaliar", "Aguardando prefeitura", "Solicitar Vigilância", "Aguardando redação do PGPCD", "Fazer redação do PGPCD", "Levar na vigilância", "Vigilância solicitada", "Solicitar Bombeiro", "Aguardando pagamento bombeiro", "Aguardando baixa bombeiro", "Emissão taxa de alvará", "Ag. pagamento taxa de alvará", "Solicitar alvará", "Ag. prefeitura emitir alvará", "Pegar alvará físico na prefeitura", "Pronto" });
            cbFase.Location = new Point(1407, 70);
            cbFase.Name = "cbFase";
            cbFase.Size = new Size(248, 23);
            cbFase.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1353, 73);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 21;
            label4.Text = "Fase";
            // 
            // CbSituacao
            // 
            CbSituacao.AllowDrop = true;
            CbSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbSituacao.FormattingEnabled = true;
            CbSituacao.ItemHeight = 15;
            CbSituacao.Items.AddRange(new object[] { "Em andamento", "Encerrado" });
            CbSituacao.Location = new Point(1407, 41);
            CbSituacao.Name = "CbSituacao";
            CbSituacao.Size = new Size(248, 23);
            CbSituacao.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1353, 44);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 20;
            label3.Text = "Situação";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(1407, 12);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(94, 23);
            txtLivro.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1353, 15);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 19;
            label2.Text = "Livro";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1140, 594);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(1221, 594);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 3;
            btnApagar.Text = "Excluir";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1302, 594);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbBombeiro
            // 
            cbBombeiro.AutoSize = true;
            cbBombeiro.Location = new Point(6, 22);
            cbBombeiro.Name = "cbBombeiro";
            cbBombeiro.Size = new Size(78, 19);
            cbBombeiro.TabIndex = 32;
            cbBombeiro.Text = "Bombeiro";
            cbBombeiro.UseVisualStyleBackColor = true;
            // 
            // cbVigilanciaSanitaria
            // 
            cbVigilanciaSanitaria.AutoSize = true;
            cbVigilanciaSanitaria.Location = new Point(6, 47);
            cbVigilanciaSanitaria.Name = "cbVigilanciaSanitaria";
            cbVigilanciaSanitaria.Size = new Size(125, 19);
            cbVigilanciaSanitaria.TabIndex = 33;
            cbVigilanciaSanitaria.Text = "Vigilância Sanitária";
            cbVigilanciaSanitaria.UseVisualStyleBackColor = true;
            // 
            // cbTaxaAlvaraPgto
            // 
            cbTaxaAlvaraPgto.AutoSize = true;
            cbTaxaAlvaraPgto.Location = new Point(6, 72);
            cbTaxaAlvaraPgto.Name = "cbTaxaAlvaraPgto";
            cbTaxaAlvaraPgto.Size = new Size(130, 19);
            cbTaxaAlvaraPgto.TabIndex = 34;
            cbTaxaAlvaraPgto.Text = "Taxa de Alvará Paga";
            cbTaxaAlvaraPgto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbEntregaTaxaAlvara);
            groupBox2.Controls.Add(cbBombeiro);
            groupBox2.Controls.Add(cbTaxaAlvaraPgto);
            groupBox2.Controls.Add(cbVigilanciaSanitaria);
            groupBox2.Location = new Point(1407, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 125);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Situação Documentos";
            // 
            // cbEntregaTaxaAlvara
            // 
            cbEntregaTaxaAlvara.AutoSize = true;
            cbEntregaTaxaAlvara.Location = new Point(6, 97);
            cbEntregaTaxaAlvara.Name = "cbEntregaTaxaAlvara";
            cbEntregaTaxaAlvara.Size = new Size(151, 19);
            cbEntregaTaxaAlvara.TabIndex = 35;
            cbEntregaTaxaAlvara.Text = "Taxa de Alvará Entregue";
            cbEntregaTaxaAlvara.UseVisualStyleBackColor = true;
            // 
            // cbAtivo
            // 
            cbAtivo.AutoSize = true;
            cbAtivo.BackColor = Color.Transparent;
            cbAtivo.Location = new Point(1413, 118);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(123, 19);
            cbAtivo.TabIndex = 36;
            cbAtivo.Text = "Alvará em análise?";
            cbAtivo.UseVisualStyleBackColor = false;
            cbAtivo.CheckedChanged += cbAtivo_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1140, 276);
            label14.Name = "label14";
            label14.Size = new Size(119, 15);
            label14.TabIndex = 42;
            label14.Text = "Comentários legados";
            // 
            // btnCarimbo
            // 
            btnCarimbo.BackColor = Color.FromArgb(255, 192, 128);
            btnCarimbo.Location = new Point(157, 393);
            btnCarimbo.Name = "btnCarimbo";
            btnCarimbo.Size = new Size(75, 23);
            btnCarimbo.TabIndex = 44;
            btnCarimbo.Text = "Inserir data";
            btnCarimbo.UseVisualStyleBackColor = false;
            btnCarimbo.Click += btnCarimbo_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1111, 339);
            tabControl1.TabIndex = 45;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(dgDocumentos);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(dgBombeiro);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1103, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Documentos e processos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(961, 25);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 46;
            button1.Text = "Atualizar documentos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 159);
            label13.Name = "label13";
            label13.Size = new Size(135, 15);
            label13.TabIndex = 45;
            label13.Text = "Documentos vinculados";
            // 
            // dgDocumentos
            // 
            dgDocumentos.AllowUserToAddRows = false;
            dgDocumentos.AllowUserToDeleteRows = false;
            dgDocumentos.AutoGenerateColumns = false;
            dgDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDocumentos.Columns.AddRange(new DataGridViewColumn[] { idDocDataGridViewTextBoxColumn, livroDataGridViewTextBoxColumn1, nOMEDataGridViewTextBoxColumn1, dtRegistroDataGridViewTextBoxColumn, vencimentodocDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, exercicioDataGridViewTextBoxColumn });
            dgDocumentos.DataSource = dbDocumentsBindingSource1;
            dgDocumentos.Location = new Point(11, 177);
            dgDocumentos.Name = "dgDocumentos";
            dgDocumentos.ReadOnly = true;
            dgDocumentos.Size = new Size(1081, 121);
            dgDocumentos.TabIndex = 44;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            idDocDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            idDocDataGridViewTextBoxColumn.DataPropertyName = "IdDoc";
            idDocDataGridViewTextBoxColumn.HeaderText = "IdDoc";
            idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            idDocDataGridViewTextBoxColumn.ReadOnly = true;
            idDocDataGridViewTextBoxColumn.Width = 63;
            // 
            // livroDataGridViewTextBoxColumn1
            // 
            livroDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            livroDataGridViewTextBoxColumn1.DataPropertyName = "Livro";
            livroDataGridViewTextBoxColumn1.HeaderText = "Livro";
            livroDataGridViewTextBoxColumn1.Name = "livroDataGridViewTextBoxColumn1";
            livroDataGridViewTextBoxColumn1.ReadOnly = true;
            livroDataGridViewTextBoxColumn1.Width = 58;
            // 
            // nOMEDataGridViewTextBoxColumn1
            // 
            nOMEDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEDataGridViewTextBoxColumn1.DataPropertyName = "NOME";
            nOMEDataGridViewTextBoxColumn1.HeaderText = "NOME";
            nOMEDataGridViewTextBoxColumn1.Name = "nOMEDataGridViewTextBoxColumn1";
            nOMEDataGridViewTextBoxColumn1.ReadOnly = true;
            nOMEDataGridViewTextBoxColumn1.Width = 67;
            // 
            // dtRegistroDataGridViewTextBoxColumn
            // 
            dtRegistroDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtRegistroDataGridViewTextBoxColumn.DataPropertyName = "DtRegistro";
            dtRegistroDataGridViewTextBoxColumn.HeaderText = "DtRegistro";
            dtRegistroDataGridViewTextBoxColumn.Name = "dtRegistroDataGridViewTextBoxColumn";
            dtRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            dtRegistroDataGridViewTextBoxColumn.Width = 87;
            // 
            // vencimentodocDataGridViewTextBoxColumn
            // 
            vencimentodocDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            vencimentodocDataGridViewTextBoxColumn.DataPropertyName = "Vencimentodoc";
            vencimentodocDataGridViewTextBoxColumn.HeaderText = "Vencimentodoc";
            vencimentodocDataGridViewTextBoxColumn.Name = "vencimentodocDataGridViewTextBoxColumn";
            vencimentodocDataGridViewTextBoxColumn.ReadOnly = true;
            vencimentodocDataGridViewTextBoxColumn.Width = 115;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Width = 56;
            // 
            // exercicioDataGridViewTextBoxColumn
            // 
            exercicioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            exercicioDataGridViewTextBoxColumn.DataPropertyName = "Exercicio";
            exercicioDataGridViewTextBoxColumn.HeaderText = "Exercicio";
            exercicioDataGridViewTextBoxColumn.Name = "exercicioDataGridViewTextBoxColumn";
            exercicioDataGridViewTextBoxColumn.ReadOnly = true;
            exercicioDataGridViewTextBoxColumn.Width = 78;
            // 
            // dbDocumentsBindingSource1
            // 
            dbDocumentsBindingSource1.DataSource = typeof(DbDocuments);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 7);
            label12.Name = "label12";
            label12.Size = new Size(169, 15);
            label12.TabIndex = 43;
            label12.Text = "Processos bombeiro vinculado";
            // 
            // dgBombeiro
            // 
            dgBombeiro.AllowUserToAddRows = false;
            dgBombeiro.AllowUserToDeleteRows = false;
            dgBombeiro.AutoGenerateColumns = false;
            dgBombeiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBombeiro.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, livroDataGridViewTextBoxColumn, nOMEDataGridViewTextBoxColumn, pROCESSODataGridViewTextBoxColumn, dATAREGISTRODataGridViewTextBoxColumn });
            dgBombeiro.DataSource = dbBombeirosBindingSource1;
            dgBombeiro.Location = new Point(11, 25);
            dgBombeiro.Name = "dgBombeiro";
            dgBombeiro.ReadOnly = true;
            dgBombeiro.Size = new Size(772, 121);
            dgBombeiro.TabIndex = 42;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // livroDataGridViewTextBoxColumn
            // 
            livroDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            livroDataGridViewTextBoxColumn.DataPropertyName = "Livro";
            livroDataGridViewTextBoxColumn.HeaderText = "Livro";
            livroDataGridViewTextBoxColumn.Name = "livroDataGridViewTextBoxColumn";
            livroDataGridViewTextBoxColumn.ReadOnly = true;
            livroDataGridViewTextBoxColumn.Width = 58;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            nOMEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            nOMEDataGridViewTextBoxColumn.Width = 67;
            // 
            // pROCESSODataGridViewTextBoxColumn
            // 
            pROCESSODataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pROCESSODataGridViewTextBoxColumn.DataPropertyName = "PROCESSO";
            pROCESSODataGridViewTextBoxColumn.HeaderText = "PROCESSO";
            pROCESSODataGridViewTextBoxColumn.Name = "pROCESSODataGridViewTextBoxColumn";
            pROCESSODataGridViewTextBoxColumn.ReadOnly = true;
            pROCESSODataGridViewTextBoxColumn.Width = 90;
            // 
            // dATAREGISTRODataGridViewTextBoxColumn
            // 
            dATAREGISTRODataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dATAREGISTRODataGridViewTextBoxColumn.DataPropertyName = "DATA_REGISTRO";
            dATAREGISTRODataGridViewTextBoxColumn.HeaderText = "DATA_REGISTRO";
            dATAREGISTRODataGridViewTextBoxColumn.Name = "dATAREGISTRODataGridViewTextBoxColumn";
            dATAREGISTRODataGridViewTextBoxColumn.ReadOnly = true;
            dATAREGISTRODataGridViewTextBoxColumn.Width = 119;
            // 
            // dbBombeirosBindingSource1
            // 
            dbBombeirosBindingSource1.DataSource = typeof(DbBombeiros);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1103, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informações da Empresa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCEP);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtEstado);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtCidade1);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtComplemento);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtBairro);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(txtNumero);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(txtEndereco);
            groupBox3.Controls.Add(label21);
            groupBox3.Location = new Point(361, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(515, 244);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Endereço Empresa";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(95, 196);
            txtCEP.Name = "txtCEP";
            txtCEP.ReadOnly = true;
            txtCEP.Size = new Size(394, 23);
            txtCEP.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 200);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 12;
            label15.Text = "CEP";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(95, 167);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(394, 23);
            txtEstado.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 171);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 10;
            label16.Text = "Estado";
            // 
            // txtCidade1
            // 
            txtCidade1.Location = new Point(95, 138);
            txtCidade1.Name = "txtCidade1";
            txtCidade1.ReadOnly = true;
            txtCidade1.Size = new Size(394, 23);
            txtCidade1.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 142);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 8;
            label17.Text = "Cidade";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(95, 109);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.ReadOnly = true;
            txtComplemento.Size = new Size(394, 23);
            txtComplemento.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 113);
            label18.Name = "label18";
            label18.Size = new Size(84, 15);
            label18.TabIndex = 6;
            label18.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(95, 80);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(394, 23);
            txtBairro.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 84);
            label19.Name = "label19";
            label19.Size = new Size(38, 15);
            label19.TabIndex = 4;
            label19.Text = "Bairro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(95, 51);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(394, 23);
            txtNumero.TabIndex = 14;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 55);
            label20.Name = "label20";
            label20.Size = new Size(51, 15);
            label20.TabIndex = 2;
            label20.Text = "Número";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(95, 22);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ReadOnly = true;
            txtEndereco.Size = new Size(394, 23);
            txtEndereco.TabIndex = 13;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 26);
            label21.Name = "label21";
            label21.Size = new Size(81, 15);
            label21.TabIndex = 0;
            label21.Text = "Endereço/Rua";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtResponsavel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDataRegistro);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(6, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 222);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Registro";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(60, 176);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.ReadOnly = true;
            txtResponsavel.Size = new Size(283, 23);
            txtResponsavel.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 179);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 34;
            label11.Text = "Resp.";
            // 
            // txtDataRegistro
            // 
            txtDataRegistro.Location = new Point(60, 147);
            txtDataRegistro.Name = "txtDataRegistro";
            txtDataRegistro.ReadOnly = true;
            txtDataRegistro.Size = new Size(283, 23);
            txtDataRegistro.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 150);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 32;
            label10.Text = "Registro";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(60, 89);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(283, 23);
            txtCNPJ.TabIndex = 9;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(60, 118);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(283, 23);
            txtCidade.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 92);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 24;
            label6.Text = "CNPJ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 121);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 30;
            label9.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 26;
            label7.Text = "Empresa";
            // 
            // txtId
            // 
            txtId.Location = new Point(60, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(94, 23);
            txtId.TabIndex = 7;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(60, 60);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ReadOnly = true;
            txtEmpresa.Size = new Size(283, 23);
            txtEmpresa.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 28;
            label8.Text = "Id";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(registrarBombeiroControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1103, 311);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Registrar Bombeiro";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // registrarBombeiroControl1
            // 
            registrarBombeiroControl1.Location = new Point(8, 6);
            registrarBombeiroControl1.Name = "registrarBombeiroControl1";
            registrarBombeiroControl1.Size = new Size(1092, 305);
            registrarBombeiroControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(registroDocumentoControl1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1103, 311);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Registrar Documento";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // registroDocumentoControl1
            // 
            registroDocumentoControl1.Location = new Point(1, 2);
            registroDocumentoControl1.Name = "registroDocumentoControl1";
            registroDocumentoControl1.Size = new Size(458, 298);
            registroDocumentoControl1.TabIndex = 0;
            // 
            // recControl1
            // 
            recControl1.BorderStyle = BorderStyle.Fixed3D;
            recControl1.Location = new Point(16, 425);
            recControl1.Name = "recControl1";
            recControl1.Size = new Size(942, 493);
            recControl1.TabIndex = 46;
            // 
            // ModTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 930);
            Controls.Add(recControl1);
            Controls.Add(tabControl1);
            Controls.Add(btnCarimbo);
            Controls.Add(label14);
            Controls.Add(cbAtivo);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnApagar);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
            Controls.Add(label5);
            Controls.Add(cbFase);
            Controls.Add(label4);
            Controls.Add(CbSituacao);
            Controls.Add(label3);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModTarefaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Tarefa";
            Load += ModTarefaForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgBombeiro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbBombeirosBindingSource1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbObs;
        private Label label5;
        private ComboBox cbFase;
        private Label label4;
        private ComboBox CbSituacao;
        private Label label3;
        private TextBox txtLivro;
        private Label label2;
        private Button btnSalvar;
        private Button btnApagar;
        private Button btnCancelar;
        private CheckBox cbBombeiro;
        private CheckBox cbVigilanciaSanitaria;
        private CheckBox cbTaxaAlvaraPgto;
        private GroupBox groupBox2;
        private CheckBox cbEntregaTaxaAlvara;
        private CheckBox cbAtivo;
        private Label label14;
        private RecControl recNotas;
        private Button btnCarimbo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label13;
        private DataGridView dgDocumentos;
        private DataGridViewTextBoxColumn IdDoc;
        private DataGridViewTextBoxColumn Livro1;
        private DataGridViewTextBoxColumn DtRegistro;
        private DataGridViewTextBoxColumn Vencimentodoc;
        private DataGridViewTextBoxColumn Obs1;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn NOME1;
        private Label label12;
        private DataGridView dgBombeiro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn PROCESSO;
        private DataGridViewTextBoxColumn OBS;
        private DataGridViewTextBoxColumn DATA_REGISTRO;
        private DataGridViewTextBoxColumn NOME;
        private GroupBox groupBox3;
        private TextBox txtCEP;
        private Label label15;
        private TextBox txtEstado;
        private Label label16;
        private TextBox txtCidade1;
        private Label label17;
        private TextBox txtComplemento;
        private Label label18;
        private TextBox txtBairro;
        private Label label19;
        private TextBox txtNumero;
        private Label label20;
        private TextBox txtEndereco;
        private Label label21;
        private GroupBox groupBox1;
        private TextBox txtResponsavel;
        private Label label11;
        private TextBox txtDataRegistro;
        private Label label10;
        private TextBox txtCNPJ;
        private TextBox txtCidade;
        private Label label6;
        private Label label9;
        private Label label7;
        private TextBox txtId;
        private TextBox txtEmpresa;
        private Label label8;
        private TabPage tabPage3;
        private RecControl recControl1;
        private BindingSource dbDocumentsBindingSource1;
        private BindingSource dbBombeirosBindingSource1;
        private DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dtRegistroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vencimentodocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exercicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pROCESSODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATAREGISTRODataGridViewTextBoxColumn;
        private RegistrarBombeiroControl registrarBombeiroControl1;
        private TabPage tabPage4;
        private RegistroDocumentoControl registroDocumentoControl1;
        private Button button1;
    }
}