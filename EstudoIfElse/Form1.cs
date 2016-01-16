using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoIfElse
{
    public partial class frmIfElse : Form
    {
        public frmIfElse()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txbIdade.Text);

            if(idade >= 18)
            {
                MessageBox.Show("Maior de idade");
            }
            else
            {
                MessageBox.Show("Menor de idade");
            }
        }
    }
}
