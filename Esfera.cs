using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __ATIVIDADE_AVALIATIVA___5_PONTOS
{
    public partial class Atividade_10_pag_16 : Form
    {
        public Atividade_10_pag_16()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            
            int raio = int.Parse(txtraio.Text);

            MessageBox.Show(( Math.PI * (raio*raio*raio) * 4 / 3 ) .ToString());

        }
    }
}
