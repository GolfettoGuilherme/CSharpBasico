using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEnums
{
    public partial class frmEstudoEnums : Form
    {
        public frmEstudoEnums()
        {
            InitializeComponent();
        }

        private void frmEstudoEnums_Shown(object sender, EventArgs e)
        {
            //de onde ele vai ler os elementos da combo
            //vão vir do que esta no DiasEnum, sempre usar o typeof para
            //indicar qual é a classe Enum que vai ser usada
            cmbDias.DataSource = Enum.GetNames(typeof(DiasEnum));

        }

        private void btnExibirDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dia escolhido: " + Enum.GetName(typeof(DiasEnum), cmbDias.SelectedIndex));
            //SelectedIndex = o que está selecionado na combo
        }
    }
}
