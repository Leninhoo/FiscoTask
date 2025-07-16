using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscoTask
{
    public partial class RegistrarBombeiroControl : UserControl
    {
        [Category("Dados Customizados")]
        [Description("Número da Empresa")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumeroLivro
        {
            get { return txtLivro.Text; }
            set { txtLivro.Text = value; }
        }
        public RegistrarBombeiroControl()
        {
            InitializeComponent();
        }



        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var db = new DbBombeiros();
            var newBombeiro = new DbBombeiros
            {
                Livro = int.Parse(txtLivro.Text),
                PROCESSO = txtProcesso.Text,
                OBS = rtbObs.Text,
                DATA_REGISTRO = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            };

            db.CreateBombeiro(newBombeiro);
            MessageBox.Show("Processo registrado com sucesso.", "Registro de Processo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtProcesso.Clear();
            rtbObs.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtProcesso.Clear();
            rtbObs.Clear();
        }
    }
}
