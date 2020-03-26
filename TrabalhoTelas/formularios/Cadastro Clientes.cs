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
    public partial class Cadastro_Clientes : Form
    {
        public Cadastro_Clientes()
        {
            InitializeComponent();
        }


        private void cadatroClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadatroClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancopetDataSet);

        }

        private void Cadastro_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trabalhoDataSet1.CadatroCliente' table. You can move, or remove it, as needed.
            this.cadatroClienteTableAdapter.Fill(this.bancopetDataSet.CadatroCliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeClienteTextBox.Enabled = true;
            telefoneMaskedTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
        }

        private void buscaClienteToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               // this.cadatroClienteTableAdapter.BuscaCliente(this.bancopetDataSet.CadatroCliente, nomeClienteToolStripTextBox.Text + "%");

                // Condição para informar que o clinete não foi encontrado
                if (nomeClienteToolStripTextBox1.Text == "")
                {
                    MessageBox.Show("Informe o nome do cliente");
                    //MessageBox.Show("Cliente não encontrado");
                }
                else
                {
                    if (this.cadatroClienteTableAdapter.BuscaCliente(this.bancopetDataSet.CadatroCliente, nomeClienteToolStripTextBox1.Text + "%") == 0)
                    {

                        MessageBox.Show("\n\nCliente não cadastrado", "*** Cadastro de cliente ***",
                         MessageBoxButtons.OK);

                        string texto = "Deseja Cadastrar novo cliente?";
                        string titulo = "***FINALIZANDO APLICAÇÃO***";
                        if (MessageBox.Show(texto, titulo,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmCad frm = new frmCad();
                            frm.ShowDialog();
                            this.Hide();//esconde o form chamador.
                        }
                    }
                    // fim da condição
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscaClienteToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cadatroClienteTableAdapter.BuscaCliente(this.bancopetDataSet.CadatroCliente, nomeClienteToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscaClienteToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
