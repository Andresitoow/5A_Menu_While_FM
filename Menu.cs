using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5A_Menu_While_FM
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOp2_Click(object sender, EventArgs e)
        {
            Pares_e_Impares pares = new Pares_e_Impares();
            pares.Show();

            
        }
    }
}
