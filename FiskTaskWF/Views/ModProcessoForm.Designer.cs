namespace FiscoTask.Views
{
    partial class ModProcessoForm
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
            btnCarimbo = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            txtRazao = new TextBox();
            label4 = new Label();
            txtResponsavel = new TextBox();
            txtIdProcesso = new TextBox();
            label11 = new Label();
            label5 = new Label();
            txtDataRegistro = new TextBox();
            label10 = new Label();
            txtCNPJ = new TextBox();
            txtCidade = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtEmpresa = new TextBox();
            label9 = new Label();
            cbTipo = new ComboBox();
            label8 = new Label();
            cbAndamento = new ComboBox();
            label6 = new Label();
            cbSituacao = new ComboBox();
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
            btnCancelar = new Button();
            btnApagar = new Button();
            btnSalvar = new Button();
            rtfEditor = new FiscoTask.Controls.RtfEditor();
            txtCnpjFormatado = new TextBox();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCarimbo
            // 
            btnCarimbo.BackColor = Color.FromArgb(255, 128, 128);
            btnCarimbo.Location = new Point(21, 387);
            btnCarimbo.Name = "btnCarimbo";
            btnCarimbo.Size = new Size(101, 23);
            btnCarimbo.TabIndex = 28;
            btnCarimbo.Text = "Adicionar Data";
            btnCarimbo.UseVisualStyleBackColor = false;
            btnCarimbo.Click += btnCarimbo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 29;
            label1.Text = "Alterar Processo";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 334);
            tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(cbTipo);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(cbAndamento);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(cbSituacao);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(910, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Informações do Processo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtCnpjFormatado);
            groupBox2.Controls.Add(txtRazao);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtResponsavel);
            groupBox2.Controls.Add(txtIdProcesso);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDataRegistro);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCNPJ);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtEmpresa);
            groupBox2.Location = new Point(15, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 250);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações Registro";
            // 
            // txtRazao
            // 
            txtRazao.Location = new Point(60, 89);
            txtRazao.Name = "txtRazao";
            txtRazao.ReadOnly = true;
            txtRazao.Size = new Size(443, 23);
            txtRazao.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 51;
            label4.Text = "Razão";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(60, 202);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.ReadOnly = true;
            txtResponsavel.Size = new Size(283, 23);
            txtResponsavel.TabIndex = 33;
            // 
            // txtIdProcesso
            // 
            txtIdProcesso.Location = new Point(80, 29);
            txtIdProcesso.Name = "txtIdProcesso";
            txtIdProcesso.ReadOnly = true;
            txtIdProcesso.Size = new Size(105, 23);
            txtIdProcesso.TabIndex = 49;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 205);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 34;
            label11.Text = "Resp.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 32);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 48;
            label5.Text = "ID Processo";
            // 
            // txtDataRegistro
            // 
            txtDataRegistro.Location = new Point(60, 173);
            txtDataRegistro.Name = "txtDataRegistro";
            txtDataRegistro.ReadOnly = true;
            txtDataRegistro.Size = new Size(443, 23);
            txtDataRegistro.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 176);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 32;
            label10.Text = "Registro";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(60, 115);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(203, 23);
            txtCNPJ.TabIndex = 9;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(60, 144);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(443, 23);
            txtCidade.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 118);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 24;
            label2.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 147);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 30;
            label3.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 26;
            label7.Text = "Livro";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(60, 60);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ReadOnly = true;
            txtEmpresa.Size = new Size(86, 23);
            txtEmpresa.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(540, 100);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 47;
            label9.Text = "Tipo Processo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(627, 97);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(230, 23);
            cbTipo.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(540, 71);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 45;
            label8.Text = "Andamento";
            // 
            // cbAndamento
            // 
            cbAndamento.FormattingEnabled = true;
            cbAndamento.Location = new Point(616, 68);
            cbAndamento.Name = "cbAndamento";
            cbAndamento.Size = new Size(224, 23);
            cbAndamento.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 42);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 43;
            label6.Text = "Situação";
            // 
            // cbSituacao
            // 
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(599, 39);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(224, 23);
            cbSituacao.TabIndex = 42;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(910, 306);
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
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(515, 244);
            groupBox3.TabIndex = 39;
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
            // btnCancelar
            // 
            btnCancelar.Location = new Point(183, 926);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(102, 926);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 39;
            btnApagar.Text = "Excluir";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(21, 926);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 38;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // rtfEditor
            // 
            rtfEditor.Location = new Point(26, 435);
            rtfEditor.Name = "rtfEditor";
            rtfEditor.Size = new Size(904, 462);
            rtfEditor.TabIndex = 41;
            // 
            // txtCnpjFormatado
            // 
            txtCnpjFormatado.Location = new Point(321, 115);
            txtCnpjFormatado.Name = "txtCnpjFormatado";
            txtCnpjFormatado.ReadOnly = true;
            txtCnpjFormatado.Size = new Size(182, 23);
            txtCnpjFormatado.TabIndex = 52;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(274, 118);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 53;
            label12.Text = "Limpo";
            // 
            // ModProcessoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 961);
            Controls.Add(rtfEditor);
            Controls.Add(btnCancelar);
            Controls.Add(btnApagar);
            Controls.Add(btnSalvar);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(btnCarimbo);
            Name = "ModProcessoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Processo";
            Load += ModProcessoForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarimbo;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label9;
        private ComboBox cbTipo;
        private Label label8;
        private ComboBox cbAndamento;
        private Label label6;
        private ComboBox cbSituacao;
        private TabPage tabPage2;
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
        private Button btnCancelar;
        private Button btnApagar;
        private Button btnSalvar;
        private TextBox txtIdProcesso;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox txtResponsavel;
        private Label label11;
        private TextBox txtDataRegistro;
        private Label label10;
        private TextBox txtCNPJ;
        private TextBox txtCidade;
        private Label label2;
        private Label label3;
        private Label label7;
        private TextBox txtEmpresa;
        private TextBox txtRazao;
        private Label label4;
        private Controls.RtfEditor rtfEditor;
        private Label label12;
        private TextBox txtCnpjFormatado;
    }
}