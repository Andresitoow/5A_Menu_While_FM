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
    public partial class Pares_e_Impares : Form
    {
        public Pares_e_Impares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limppia los numeros anteriores 
            int i = 0;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1; 
            }
        }

        private void btnimpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limppia los numeros anteriores
            int i = 0;

            while (i <= 20)
            {
                if (i % 2 == 1)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }
        }
    }
}
