using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTelas.formularios
{
    public partial class frmCad : Form
    {
        public frmCad()
        {
            InitializeComponent();
        }

        private void cadatroClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadatroClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancopetDataSet);

        }

        private void frmCad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trabalhoDataSet1.CadatroCliente' table. You can move, or remove it, as needed.
            this.cadatroClienteTableAdapter.Fill(this.bancopetDataSet.CadatroCliente);

        }
    }
}
