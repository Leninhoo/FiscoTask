namespace FiscoTask
{
    public partial class Form1 : Form
    {
        EmpresasView ConsultaEmpresa = new EmpresasView();
        ConsultaDocsView ConsultaDocsView = new ConsultaDocsView();
        RegistroDocForm RegistroDocForm = new RegistroDocForm();    
        public Form1()
        {
            InitializeComponent();
            ConsultaEmpresa.Dock = DockStyle.Fill;
            ConsultaEmpresa.Visible = false;
            this.Controls.Add(ConsultaEmpresa);

            ConsultaDocsView.Dock = DockStyle.Fill;
            ConsultaDocsView.Visible = false;
            this.Controls.Add(ConsultaDocsView);

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEmpresa.Visible = true;
            ConsultaEmpresa.BringToFront();
        }

        private void consultarDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDocsView.Visible = true;
            ConsultaDocsView.BringToFront();
        }

        private void registroDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDocForm.Show();
        }
    }
}
