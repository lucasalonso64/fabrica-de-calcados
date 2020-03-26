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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSet1.clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Sair(object sender, EventArgs e)
        {
            Close();
        }
    }
}
