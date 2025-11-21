using FiscoTask.Views;
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



        private void consutarProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaBombeirosForm bombeiros = new ConsultaBombeirosForm();
            bombeiros.Show();
        }

        private void registrarProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroBombeiroForm registroBombeiro = new RegistroBombeiroForm();
            registroBombeiro.Show();
        }

        private void responsávelInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaResponsavel consultaResponsavel = new ConsultaResponsavel();
            consultaResponsavel.Show();
        }

        private void consultarSóciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaSociosForm constaSocio = new ConsultaSociosForm();
            constaSocio.Show();
        }



        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDocForm registroDocForm = new RegistroDocForm();
            registroDocForm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDocsView.Visible = true;
            ConsultaDocsView.BringToFront();
        }

        private void consultarAtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dbAtos = new ConsultaAtosEmpresariaisForm();
            dbAtos.Show();
        }

        private void registrarAtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarAto = new RegAtosEmpresariaisForm();
            registrarAto.Show();
        }

        private void atualizarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updatedb = new UpdateDataBase();
            updatedb.Show();
        }

        private void cadastrarProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registrarProcesso = new RegistroProcesso();
            registrarProcesso.Show();
        }

        private void consultaDeTarefasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaTarefaForm consult = new ConsultaTarefaForm();
            consult.Show();
        }

        private void registroDeTarefasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistroTarefaForm registro = new RegistroTarefaForm();
            registro.Show();
        }

        private void consultarProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProcessoForm consultaProcesso = new ConsultaProcessoForm();
            consultaProcesso.Show();
        }
    }
}
