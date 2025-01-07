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
            homeToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            registroDeDocumentosToolStripMenuItem = new ToolStripMenuItem();
            consultarDocumentosToolStripMenuItem = new ToolStripMenuItem();
            bombeirosToolStripMenuItem = new ToolStripMenuItem();
            registrarProcessoToolStripMenuItem = new ToolStripMenuItem();
            consutarProcessosToolStripMenuItem = new ToolStripMenuItem();
            tarefasToolStripMenuItem = new ToolStripMenuItem();
            registroDeTarefasToolStripMenuItem = new ToolStripMenuItem();
            consultaDeTarefasToolStripMenuItem = new ToolStripMenuItem();
            Logo = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, registrosToolStripMenuItem, tarefasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empresasToolStripMenuItem, homeToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(124, 22);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += empresasToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(124, 22);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDeDocumentosToolStripMenuItem, consultarDocumentosToolStripMenuItem, bombeirosToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(67, 20);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeDocumentosToolStripMenuItem
            // 
            registroDeDocumentosToolStripMenuItem.Name = "registroDeDocumentosToolStripMenuItem";
            registroDeDocumentosToolStripMenuItem.Size = new Size(204, 22);
            registroDeDocumentosToolStripMenuItem.Text = "Registro de Documentos";
            registroDeDocumentosToolStripMenuItem.Click += registroDeDocumentosToolStripMenuItem_Click;
            // 
            // consultarDocumentosToolStripMenuItem
            // 
            consultarDocumentosToolStripMenuItem.Name = "consultarDocumentosToolStripMenuItem";
            consultarDocumentosToolStripMenuItem.Size = new Size(204, 22);
            consultarDocumentosToolStripMenuItem.Text = "Consultar Documentos";
            consultarDocumentosToolStripMenuItem.Click += consultarDocumentosToolStripMenuItem_Click;
            // 
            // bombeirosToolStripMenuItem
            // 
            bombeirosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarProcessoToolStripMenuItem, consutarProcessosToolStripMenuItem });
            bombeirosToolStripMenuItem.Name = "bombeirosToolStripMenuItem";
            bombeirosToolStripMenuItem.Size = new Size(204, 22);
            bombeirosToolStripMenuItem.Text = "Bombeiros";
            // 
            // registrarProcessoToolStripMenuItem
            // 
            registrarProcessoToolStripMenuItem.Name = "registrarProcessoToolStripMenuItem";
            registrarProcessoToolStripMenuItem.Size = new Size(180, 22);
            registrarProcessoToolStripMenuItem.Text = "Registrar Processo";
            registrarProcessoToolStripMenuItem.Click += registrarProcessoToolStripMenuItem_Click;
            // 
            // consutarProcessosToolStripMenuItem
            // 
            consutarProcessosToolStripMenuItem.Name = "consutarProcessosToolStripMenuItem";
            consutarProcessosToolStripMenuItem.Size = new Size(180, 22);
            consutarProcessosToolStripMenuItem.Text = "Consutar Processos";
            consutarProcessosToolStripMenuItem.Click += consutarProcessosToolStripMenuItem_Click;
            // 
            // tarefasToolStripMenuItem
            // 
            tarefasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDeTarefasToolStripMenuItem, consultaDeTarefasToolStripMenuItem });
            tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            tarefasToolStripMenuItem.Size = new Size(55, 20);
            tarefasToolStripMenuItem.Text = "Tarefas";
            // 
            // registroDeTarefasToolStripMenuItem
            // 
            registroDeTarefasToolStripMenuItem.Name = "registroDeTarefasToolStripMenuItem";
            registroDeTarefasToolStripMenuItem.Size = new Size(180, 22);
            registroDeTarefasToolStripMenuItem.Text = "Registro de Tarefas";
            registroDeTarefasToolStripMenuItem.Click += registroDeTarefasToolStripMenuItem_Click;
            // 
            // consultaDeTarefasToolStripMenuItem
            // 
            consultaDeTarefasToolStripMenuItem.Name = "consultaDeTarefasToolStripMenuItem";
            consultaDeTarefasToolStripMenuItem.Size = new Size(180, 22);
            consultaDeTarefasToolStripMenuItem.Text = "Consulta de Tarefas";
            consultaDeTarefasToolStripMenuItem.Click += consultaDeTarefasToolStripMenuItem_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 518);
            Controls.Add(Logo);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
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
        private ToolStripMenuItem registroDeDocumentosToolStripMenuItem;
        private ToolStripMenuItem consultarDocumentosToolStripMenuItem;
        private PictureBox Logo;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem registroDeTarefasToolStripMenuItem;
        private ToolStripMenuItem consultaDeTarefasToolStripMenuItem;
        private ToolStripMenuItem bombeirosToolStripMenuItem;
        private ToolStripMenuItem registrarProcessoToolStripMenuItem;
        private ToolStripMenuItem consutarProcessosToolStripMenuItem;
    }
}
