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
    public partial class Controle_de_Serviços : Form
    {
        public Controle_de_Serviços()
        {
            InitializeComponent();
        }

        private void SairCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroServicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancopetDataSet);

        }

        private void Controle_de_Serviços_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trabalhoDataSet.CadastroServico' table. You can move, or remove it, as needed.
            this.cadastroServicoTableAdapter.Fill(this.bancopetDataSet.CadastroServico);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeServicoTextBox.Enabled = true;
            valorTextBox.Enabled = true;
        }
          // Configuração do botão cadastrar da tela de serviço
        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroServicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancopetDataSet);
        }

        private void buscarNomeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.cadastroServicoTableAdapter.BuscaNome(this.bancopetDataSet.CadastroServico, nomeServicoToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        

        

       

       
       

        

        

        

        

           



        
    }
}
