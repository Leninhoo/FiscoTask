using System.Windows.Forms;

namespace FiscoTask
{
    public partial class Form1 : Form
    {
        EmpresasView ConsultaEmpresa = new EmpresasView();
        ConsultaDocsView ConsultaDocsView = new ConsultaDocsView();
        RegistroDocForm RegistroDocForm = new RegistroDocForm();
        private RegistroDocForm registroDocForm;

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
            RegistroDocForm registroDocForm = new RegistroDocForm();
            registroDocForm.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            Logo.Top = (this.ClientSize.Height - Logo.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEmpresa.Visible = false;
            ConsultaEmpresa.SendToBack();

            ConsultaDocsView.Visible = false;
            ConsultaDocsView.SendToBack();


        }
    }
}
