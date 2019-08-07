using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1yes
{
    public partial class Login_Frias : Form
    {
        public Login_Frias()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int contraseña=0;

            if(textBox2.Text == "brenda" && textBox1.Text == "putoelqueescribe")
            {
                MessageBox.Show("El usuario y contraseña son correctos");
                contraseña = 1;
            }
                else
                {
                 MessageBox.Show("Error, usuario o contraseña incorrectos");
                }

            if(contraseña == 1)
            {
                MessageBox.Show("Puto el que lee");
               
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Login_Frias_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("putoelqueescribe");
        }
    }
}
