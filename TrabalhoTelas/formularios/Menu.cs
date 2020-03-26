using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTelas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Cadastro_Clientes TClientes = new formularios.Cadastro_Clientes();
            TClientes.ShowDialog();
        }

        private void cadastroDeAnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Cadastro_de_Animais TAnimais = new formularios.Cadastro_de_Animais();
            TAnimais.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Cadastro_de_Funcionários TFuncionarios = new formularios.Cadastro_de_Funcionários();
            TFuncionarios.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Controle_de_Serviços TServicos = new formularios.Controle_de_Serviços();
            TServicos.ShowDialog();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Histórico_dos_Serviços THistorico = new formularios.Histórico_dos_Serviços();
            THistorico.ShowDialog();
        }

        private void registroAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Agendamento TAgendamento = new formularios.Agendamento();
            TAgendamento.ShowDialog();
        }

        private void registroConcluãoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Registro_Conclusao_Serviço TRegistroConclusao = new formularios.Registro_Conclusao_Serviço();
            TRegistroConclusao.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
