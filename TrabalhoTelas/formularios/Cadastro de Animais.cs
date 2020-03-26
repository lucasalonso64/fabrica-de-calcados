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
    public partial class Cadastro_de_Animais : Form
    {
        public Cadastro_de_Animais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroAnimalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroAnimalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancopetDataSet);

        }

        private void Cadastro_de_Animais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancopetDataSet.Sexo' table. You can move, or remove it, as needed.
            this.sexoTableAdapter.Fill(this.bancopetDataSet.Sexo);
            // TODO: This line of code loads data into the 'bancopetDataSet.tipoAnimal' table. You can move, or remove it, as needed.
            this.tipoAnimalTableAdapter.Fill(this.bancopetDataSet.tipoAnimal);
            // TODO: This line of code loads data into the 'bancopetDataSet.CadastroAnimal' table. You can move, or remove it, as needed.
            this.cadastroAnimalTableAdapter.Fill(this.bancopetDataSet.CadastroAnimal);

        }

        private void tipoAnimalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
