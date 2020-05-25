using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Gestion_Hopital
{
    public partial class EcranAccueil : Form
    {
        public EcranAccueil()
        {
            InitializeComponent();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EcranAccueil_Load(object sender, EventArgs e)
        {

        }
    }
}
