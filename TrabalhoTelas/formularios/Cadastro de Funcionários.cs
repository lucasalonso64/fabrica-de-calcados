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
    public partial class Cadastro_de_Funcionários : Form
    {
        public Cadastro_de_Funcionários()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancopetDataSet);

        }

        private void Cadastro_de_Funcionários_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancopetDataSet.CadastroFuncionario' table. You can move, or remove it, as needed.
            this.cadastroFuncionarioTableAdapter.Fill(this.bancopetDataSet.CadastroFuncionario);

        }
    }
}
