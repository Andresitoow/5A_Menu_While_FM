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
    public partial class Repetir_texto : Form
    {
        public Repetir_texto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            String texto = txtTexto.Text;

            listBox1.Items.Clear();
            for (int i=1 ; i < 11; i ++)
            {
                MessageBox.Show(txtTexto.Text);
            }
        }
    }
}
