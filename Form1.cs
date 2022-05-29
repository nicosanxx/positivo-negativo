using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace positivo_negativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_num.Text == "")
            {
                MessageBox.Show("PREENCHER CORRETAMENTE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                int numero = Convert.ToInt32(txt_num.Text);

                if(numero < 0)
                {
                    int conversao = numero * -1;
                    lb_result.Text = conversao.ToString();


                }
                else
                {

                    lb_result.Text = numero.ToString();


                }


            }



        }
    }
}
