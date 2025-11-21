namespace FiscoTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            empresasToolStripMenuItem = new ToolStripMenuItem();
            consultarSóciosToolStripMenuItem = new ToolStripMenuItem();
            responsávelInternoToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            documentosToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            bombeirosToolStripMenuItem = new ToolStripMenuItem();
            registrarProcessoToolStripMenuItem = new ToolStripMenuItem();
            consutarProcessosToolStripMenuItem = new ToolStripMenuItem();
            tarefasToolStripMenuItem = new ToolStripMenuItem();
            atosEmpresariaisToolStripMenuItem = new ToolStripMenuItem();
            consultarAtosToolStripMenuItem = new ToolStripMenuItem();
            registrarAtoToolStripMenuItem = new ToolStripMenuItem();
            alvarásToolStripMenuItem = new ToolStripMenuItem();
            consultaDeTarefasToolStripMenuItem = new ToolStripMenuItem();
            registroDeTarefasToolStripMenuItem = new ToolStripMenuItem();
            processosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProcessoToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            atualizarBancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            Logo = new PictureBox();
            consultarProcessosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, registrosToolStripMenuItem, tarefasToolStripMenuItem, ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empresasToolStripMenuItem, consultarSóciosToolStripMenuItem, responsávelInternoToolStripMenuItem, homeToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            empresasToolStripMenuItem.Size = new Size(196, 22);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += empresasToolStripMenuItem_Click;
            // 
            // consultarSóciosToolStripMenuItem
            // 
            consultarSóciosToolStripMenuItem.Name = "consultarSóciosToolStripMenuItem";
            consultarSóciosToolStripMenuItem.Size = new Size(196, 22);
            consultarSóciosToolStripMenuItem.Text = "Consultar Sócios";
            consultarSóciosToolStripMenuItem.Click += consultarSóciosToolStripMenuItem_Click;
            // 
            // responsávelInternoToolStripMenuItem
            // 
            responsávelInternoToolStripMenuItem.Name = "responsávelInternoToolStripMenuItem";
            responsávelInternoToolStripMenuItem.Size = new Size(196, 22);
            responsávelInternoToolStripMenuItem.Text = "Responsável Interno";
            responsávelInternoToolStripMenuItem.Click += responsávelInternoToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            homeToolStripMenuItem.Size = new Size(196, 22);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentosToolStripMenuItem, bombeirosToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(67, 20);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // documentosToolStripMenuItem
            // 
            documentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, consultarToolStripMenuItem });
            documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            documentosToolStripMenuItem.Size = new Size(142, 22);
            documentosToolStripMenuItem.Text = "Documentos";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(125, 22);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // bombeirosToolStripMenuItem
            // 
            bombeirosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarProcessoToolStripMenuItem, consutarProcessosToolStripMenuItem });
            bombeirosToolStripMenuItem.Name = "bombeirosToolStripMenuItem";
            bombeirosToolStripMenuItem.Size = new Size(142, 22);
            bombeirosToolStripMenuItem.Text = "Bombeiros";
            // 
            // registrarProcessoToolStripMenuItem
            // 
            registrarProcessoToolStripMenuItem.Name = "registrarProcessoToolStripMenuItem";
            registrarProcessoToolStripMenuItem.Size = new Size(177, 22);
            registrarProcessoToolStripMenuItem.Text = "Registrar Processo";
            registrarProcessoToolStripMenuItem.Click += registrarProcessoToolStripMenuItem_Click;
            // 
            // consutarProcessosToolStripMenuItem
            // 
            consutarProcessosToolStripMenuItem.Name = "consutarProcessosToolStripMenuItem";
            consutarProcessosToolStripMenuItem.Size = new Size(177, 22);
            consutarProcessosToolStripMenuItem.Text = "Consutar Processos";
            consutarProcessosToolStripMenuItem.Click += consutarProcessosToolStripMenuItem_Click;
            // 
            // tarefasToolStripMenuItem
            // 
            tarefasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { atosEmpresariaisToolStripMenuItem, alvarásToolStripMenuItem, processosToolStripMenuItem });
            tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            tarefasToolStripMenuItem.Size = new Size(56, 20);
            tarefasToolStripMenuItem.Text = "Tarefas";
            // 
            // atosEmpresariaisToolStripMenuItem
            // 
            atosEmpresariaisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarAtosToolStripMenuItem, registrarAtoToolStripMenuItem });
            atosEmpresariaisToolStripMenuItem.Name = "atosEmpresariaisToolStripMenuItem";
            atosEmpresariaisToolStripMenuItem.Size = new Size(180, 22);
            atosEmpresariaisToolStripMenuItem.Text = "Atos Empresariais";
            // 
            // consultarAtosToolStripMenuItem
            // 
            consultarAtosToolStripMenuItem.Name = "consultarAtosToolStripMenuItem";
            consultarAtosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D4;
            consultarAtosToolStripMenuItem.Size = new Size(192, 22);
            consultarAtosToolStripMenuItem.Text = "Consultar Atos";
            consultarAtosToolStripMenuItem.Click += consultarAtosToolStripMenuItem_Click;
            // 
            // registrarAtoToolStripMenuItem
            // 
            registrarAtoToolStripMenuItem.Name = "registrarAtoToolStripMenuItem";
            registrarAtoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            registrarAtoToolStripMenuItem.Size = new Size(192, 22);
            registrarAtoToolStripMenuItem.Text = "Registrar Ato";
            registrarAtoToolStripMenuItem.Click += registrarAtoToolStripMenuItem_Click;
            // 
            // alvarásToolStripMenuItem
            // 
            alvarásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaDeTarefasToolStripMenuItem, registroDeTarefasToolStripMenuItem });
            alvarásToolStripMenuItem.Name = "alvarásToolStripMenuItem";
            alvarásToolStripMenuItem.Size = new Size(180, 22);
            alvarásToolStripMenuItem.Text = "Alvarás";
            // 
            // consultaDeTarefasToolStripMenuItem
            // 
            consultaDeTarefasToolStripMenuItem.Name = "consultaDeTarefasToolStripMenuItem";
            consultaDeTarefasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            consultaDeTarefasToolStripMenuItem.Size = new Size(269, 22);
            consultaDeTarefasToolStripMenuItem.Text = "Consulta Processos Alvará";
            consultaDeTarefasToolStripMenuItem.Click += consultaDeTarefasToolStripMenuItem_Click_1;
            // 
            // registroDeTarefasToolStripMenuItem
            // 
            registroDeTarefasToolStripMenuItem.Name = "registroDeTarefasToolStripMenuItem";
            registroDeTarefasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
            registroDeTarefasToolStripMenuItem.Size = new Size(269, 22);
            registroDeTarefasToolStripMenuItem.Text = "Registros de Processos Alvará";
            registroDeTarefasToolStripMenuItem.Click += registroDeTarefasToolStripMenuItem_Click_1;
            // 
            // processosToolStripMenuItem
            // 
            processosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarProcessoToolStripMenuItem, consultarProcessosToolStripMenuItem });
            processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            processosToolStripMenuItem.Size = new Size(180, 22);
            processosToolStripMenuItem.Text = "Processos";
            // 
            // cadastrarProcessoToolStripMenuItem
            // 
            cadastrarProcessoToolStripMenuItem.Name = "cadastrarProcessoToolStripMenuItem";
            cadastrarProcessoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarProcessoToolStripMenuItem.Text = "Cadastrar Processo";
            cadastrarProcessoToolStripMenuItem.Click += cadastrarProcessoToolStripMenuItem_Click;
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { atualizarBancoDeDadosToolStripMenuItem });
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(57, 20);
            ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // atualizarBancoDeDadosToolStripMenuItem
            // 
            atualizarBancoDeDadosToolStripMenuItem.Name = "atualizarBancoDeDadosToolStripMenuItem";
            atualizarBancoDeDadosToolStripMenuItem.Size = new Size(208, 22);
            atualizarBancoDeDadosToolStripMenuItem.Text = "Atualizar Banco de Dados";
            atualizarBancoDeDadosToolStripMenuItem.Click += atualizarBancoDeDadosToolStripMenuItem_Click;
            // 
            // Logo
            // 
            Logo.BackgroundImageLayout = ImageLayout.None;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(396, 98);
            Logo.Name = "Logo";
            Logo.Size = new Size(432, 356);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // consultarProcessosToolStripMenuItem
            // 
            consultarProcessosToolStripMenuItem.Name = "consultarProcessosToolStripMenuItem";
            consultarProcessosToolStripMenuItem.Size = new Size(180, 22);
            consultarProcessosToolStripMenuItem.Text = "Consultar Processos";
            consultarProcessosToolStripMenuItem.Click += consultarProcessosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 518);
            Controls.Add(Logo);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FiscoTask";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem empresasToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private PictureBox Logo;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem bombeirosToolStripMenuItem;
        private ToolStripMenuItem registrarProcessoToolStripMenuItem;
        private ToolStripMenuItem consutarProcessosToolStripMenuItem;
        private ToolStripMenuItem responsávelInternoToolStripMenuItem;
        private ToolStripMenuItem documentosToolStripMenuItem;
        private ToolStripMenuItem consultarSóciosToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem atosEmpresariaisToolStripMenuItem;
        private ToolStripMenuItem consultarAtosToolStripMenuItem;
        private ToolStripMenuItem registrarAtoToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ToolStripMenuItem atualizarBancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem alvarásToolStripMenuItem;
        private ToolStripMenuItem consultaDeTarefasToolStripMenuItem;
        private ToolStripMenuItem registroDeTarefasToolStripMenuItem;
        private ToolStripMenuItem processosToolStripMenuItem;
        private ToolStripMenuItem cadastrarProcessoToolStripMenuItem;
        private ToolStripMenuItem consultarProcessosToolStripMenuItem;
    }
}
