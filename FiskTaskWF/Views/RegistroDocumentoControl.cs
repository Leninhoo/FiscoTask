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
    public partial class RegistroDocumentoControl : UserControl
    {
        DbDocType DbDocType = new DbDocType();
        [Category("Dados Customizados")]
        [Description("Número da Empresa")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public string NumeroLivro
        {
            get { return txtLivro.Text; }
            set { txtLivro.Text = value; }
        }
        public RegistroDocumentoControl()
        {
            InitializeComponent();
        }

        private void LoadDocType()
        {
            try
            {
                var doctype = DbDocType.ReadType();
                cbTipoDoc.DataSource = doctype;
                cbTipoDoc.DisplayMember = "TIPO";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas: {ex.Message}");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLivro.Text) || string.IsNullOrWhiteSpace(txtVencimento.Text) || string.IsNullOrWhiteSpace(rtbObs.Text) || string.IsNullOrWhiteSpace(cbTipoDoc.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            var db = new DbDocuments();
            var NovoDocumento = new DbDocuments
            {
                Livro = int.Parse(txtLivro.Text),
                DtRegistro = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"),
                Vencimentodoc = DateTime.Parse(txtVencimento.Text),
                Obs = rtbObs.Text,
                Tipo = cbTipoDoc.Text,
            };

            db.CreateDoc(NovoDocumento);
            MessageBox.Show("Documento registrado com sucesso");

            txtVencimento.Clear();
            rtbObs.Clear();
        }

        private void cbTipoDoc_Click(object sender, EventArgs e)
        {
            LoadDocType();
        }
    }
}
