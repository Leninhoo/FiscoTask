using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;


namespace FiscoTask
{
    public partial class RecControl : UserControl
    {
        public RecControl()
        {
            InitializeComponent();
        }

        public RichEditControl Rec => richEditControl1;
    }
}
