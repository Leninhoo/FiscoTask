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
            txtCNPJ = new TextBox();
            label6 = new Label();
            txtEmpresa = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            txtCidade = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            txtResponsavel = new TextBox();
            label11 = new Label();
            txtDataRegistro = new TextBox();
            label10 = new Label();
            btnSalvar = new Button();
            btnApagar = new Button();
            btnCancelar = new Button();
            cbBombeiro = new CheckBox();
            cbVigilanciaSanitaria = new CheckBox();
            cbTaxaAlvaraPgto = new CheckBox();
            groupBox2 = new GroupBox();
            cbEntregaTaxaAlvara = new CheckBox();
            cbAtivo = new CheckBox();
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
            dgBombeiro = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Livro = new DataGridViewTextBoxColumn();
            PROCESSO = new DataGridViewTextBoxColumn();
            OBS = new DataGridViewTextBoxColumn();
            DATA_REGISTRO = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            dbBombeirosBindingSource = new BindingSource(components);
            label12 = new Label();
            label13 = new Label();
            dgDocumentos = new DataGridView();
            IdDoc = new DataGridViewTextBoxColumn();
            Livro1 = new DataGridViewTextBoxColumn();
            DtRegistro = new DataGridViewTextBoxColumn();
            Vencimentodoc = new DataGridViewTextBoxColumn();
            Obs1 = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            NOME1 = new DataGridViewTextBoxColumn();
            dbDocumentsBindingSource = new BindingSource(components);
            label14 = new Label();
            recNotas = new RecControl();
            btnCarimbo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBombeiro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbBombeirosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).BeginInit();
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
            rtbObs.Location = new Point(1128, 537);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(515, 294);
            rtbObs.TabIndex = 1;
            rtbObs.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 498);
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
            cbFase.Location = new Point(69, 133);
            cbFase.Name = "cbFase";
            cbFase.Size = new Size(248, 23);
            cbFase.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 136);
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
            CbSituacao.Location = new Point(69, 104);
            CbSituacao.Name = "CbSituacao";
            CbSituacao.Size = new Size(248, 23);
            CbSituacao.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 107);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 20;
            label3.Text = "Situação";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(69, 75);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(94, 23);
            txtLivro.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 19;
            label2.Text = "Livro";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(60, 89);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(283, 23);
            txtCNPJ.TabIndex = 9;
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
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(60, 60);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ReadOnly = true;
            txtEmpresa.Size = new Size(283, 23);
            txtEmpresa.TabIndex = 8;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 28;
            label8.Text = "Id";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(60, 118);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(283, 23);
            txtCidade.TabIndex = 10;
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
            groupBox1.Location = new Point(1128, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 222);
            groupBox1.TabIndex = 31;
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
            // btnSalvar
            // 
            btnSalvar.Location = new Point(15, 945);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(96, 945);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 3;
            btnApagar.Text = "Excluir";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 945);
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
            groupBox2.Location = new Point(893, 21);
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
            cbAtivo.Location = new Point(899, 167);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(123, 19);
            cbAtivo.TabIndex = 36;
            cbAtivo.Text = "Alvará em análise?";
            cbAtivo.UseVisualStyleBackColor = false;
            cbAtivo.CheckedChanged += cbAtivo_CheckedChanged;
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
            groupBox3.Location = new Point(1128, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(515, 244);
            groupBox3.TabIndex = 37;
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
            // dgBombeiro
            // 
            dgBombeiro.AllowUserToAddRows = false;
            dgBombeiro.AllowUserToDeleteRows = false;
            dgBombeiro.AutoGenerateColumns = false;
            dgBombeiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBombeiro.Columns.AddRange(new DataGridViewColumn[] { Id, Livro, PROCESSO, OBS, DATA_REGISTRO, NOME });
            dgBombeiro.DataSource = dbBombeirosBindingSource;
            dgBombeiro.Location = new Point(12, 200);
            dgBombeiro.Name = "dgBombeiro";
            dgBombeiro.ReadOnly = true;
            dgBombeiro.Size = new Size(1081, 121);
            dgBombeiro.TabIndex = 38;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Livro
            // 
            Livro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Livro.DataPropertyName = "Livro";
            Livro.HeaderText = "Livro";
            Livro.Name = "Livro";
            Livro.ReadOnly = true;
            Livro.Width = 58;
            // 
            // PROCESSO
            // 
            PROCESSO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PROCESSO.DataPropertyName = "PROCESSO";
            PROCESSO.HeaderText = "PROCESSO";
            PROCESSO.Name = "PROCESSO";
            PROCESSO.ReadOnly = true;
            PROCESSO.Width = 90;
            // 
            // OBS
            // 
            OBS.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            OBS.DataPropertyName = "OBS";
            OBS.HeaderText = "OBS";
            OBS.Name = "OBS";
            OBS.ReadOnly = true;
            OBS.Width = 54;
            // 
            // DATA_REGISTRO
            // 
            DATA_REGISTRO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DATA_REGISTRO.DataPropertyName = "DATA_REGISTRO";
            DATA_REGISTRO.HeaderText = "DATA_REGISTRO";
            DATA_REGISTRO.Name = "DATA_REGISTRO";
            DATA_REGISTRO.ReadOnly = true;
            DATA_REGISTRO.Width = 119;
            // 
            // NOME
            // 
            NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NOME.DataPropertyName = "NOME";
            NOME.HeaderText = "NOME";
            NOME.Name = "NOME";
            NOME.ReadOnly = true;
            NOME.Width = 67;
            // 
            // dbBombeirosBindingSource
            // 
            dbBombeirosBindingSource.DataSource = typeof(DbBombeiros);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 182);
            label12.Name = "label12";
            label12.Size = new Size(169, 15);
            label12.TabIndex = 39;
            label12.Text = "Processos bombeiro vinculado";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 334);
            label13.Name = "label13";
            label13.Size = new Size(135, 15);
            label13.TabIndex = 41;
            label13.Text = "Documentos vinculados";
            // 
            // dgDocumentos
            // 
            dgDocumentos.AllowUserToAddRows = false;
            dgDocumentos.AllowUserToDeleteRows = false;
            dgDocumentos.AutoGenerateColumns = false;
            dgDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDocumentos.Columns.AddRange(new DataGridViewColumn[] { IdDoc, Livro1, DtRegistro, Vencimentodoc, Obs1, Tipo, NOME1 });
            dgDocumentos.DataSource = dbDocumentsBindingSource;
            dgDocumentos.Location = new Point(12, 352);
            dgDocumentos.Name = "dgDocumentos";
            dgDocumentos.ReadOnly = true;
            dgDocumentos.Size = new Size(1081, 121);
            dgDocumentos.TabIndex = 40;
            // 
            // IdDoc
            // 
            IdDoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IdDoc.DataPropertyName = "IdDoc";
            IdDoc.HeaderText = "IdDoc";
            IdDoc.Name = "IdDoc";
            IdDoc.ReadOnly = true;
            IdDoc.Width = 63;
            // 
            // Livro1
            // 
            Livro1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Livro1.DataPropertyName = "Livro";
            Livro1.HeaderText = "Livro";
            Livro1.Name = "Livro1";
            Livro1.ReadOnly = true;
            Livro1.Width = 58;
            // 
            // DtRegistro
            // 
            DtRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DtRegistro.DataPropertyName = "DtRegistro";
            DtRegistro.HeaderText = "DtRegistro";
            DtRegistro.Name = "DtRegistro";
            DtRegistro.ReadOnly = true;
            DtRegistro.Width = 87;
            // 
            // Vencimentodoc
            // 
            Vencimentodoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Vencimentodoc.DataPropertyName = "Vencimentodoc";
            Vencimentodoc.HeaderText = "Vencimentodoc";
            Vencimentodoc.Name = "Vencimentodoc";
            Vencimentodoc.ReadOnly = true;
            Vencimentodoc.Width = 115;
            // 
            // Obs1
            // 
            Obs1.DataPropertyName = "Obs";
            Obs1.HeaderText = "Obs";
            Obs1.Name = "Obs1";
            Obs1.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 56;
            // 
            // NOME1
            // 
            NOME1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NOME1.DataPropertyName = "NOME";
            NOME1.HeaderText = "NOME";
            NOME1.Name = "NOME1";
            NOME1.ReadOnly = true;
            NOME1.Width = 67;
            // 
            // dbDocumentsBindingSource
            // 
            dbDocumentsBindingSource.DataSource = typeof(DbDocuments);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1128, 519);
            label14.Name = "label14";
            label14.Size = new Size(119, 15);
            label14.TabIndex = 42;
            label14.Text = "Comentários legados";
            // 
            // recNotas
            // 
            recNotas.BorderStyle = BorderStyle.Fixed3D;
            recNotas.Location = new Point(11, 516);
            recNotas.Name = "recNotas";
            recNotas.Size = new Size(1082, 423);
            recNotas.TabIndex = 43;
            // 
            // btnCarimbo
            // 
            btnCarimbo.Location = new Point(258, 945);
            btnCarimbo.Name = "btnCarimbo";
            btnCarimbo.Size = new Size(75, 23);
            btnCarimbo.TabIndex = 44;
            btnCarimbo.Text = "Inserir data";
            btnCarimbo.UseVisualStyleBackColor = true;
            btnCarimbo.Click += btnCarimbo_Click;
            // 
            // ModTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 978);
            Controls.Add(btnCarimbo);
            Controls.Add(recNotas);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dgDocumentos);
            Controls.Add(label12);
            Controls.Add(dgBombeiro);
            Controls.Add(groupBox3);
            Controls.Add(cbAtivo);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnApagar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgBombeiro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbBombeirosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).EndInit();
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
        private TextBox txtCNPJ;
        private Label label6;
        private TextBox txtEmpresa;
        private Label label7;
        private TextBox txtId;
        private Label label8;
        private TextBox txtCidade;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox txtDataRegistro;
        private Label label10;
        private Button btnSalvar;
        private Button btnApagar;
        private Button btnCancelar;
        private CheckBox cbBombeiro;
        private CheckBox cbVigilanciaSanitaria;
        private CheckBox cbTaxaAlvaraPgto;
        private GroupBox groupBox2;
        private CheckBox cbEntregaTaxaAlvara;
        private CheckBox cbAtivo;
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
        private TextBox txtResponsavel;
        private Label label11;
        private DataGridView dgBombeiro;
        private Label label12;
        private Label label13;
        private DataGridView dgDocumentos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn PROCESSO;
        private DataGridViewTextBoxColumn OBS;
        private DataGridViewTextBoxColumn DATA_REGISTRO;
        private DataGridViewTextBoxColumn NOME;
        private BindingSource dbBombeirosBindingSource;
        private DataGridViewTextBoxColumn IdDoc;
        private DataGridViewTextBoxColumn Livro1;
        private DataGridViewTextBoxColumn DtRegistro;
        private DataGridViewTextBoxColumn Vencimentodoc;
        private DataGridViewTextBoxColumn Obs1;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn NOME1;
        private BindingSource dbDocumentsBindingSource;
        private Label label14;
        private RecControl recNotas;
        private Button btnCarimbo;
    }
}