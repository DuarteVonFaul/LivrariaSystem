using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaSystem.views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {

            string message = "O genero Selecionado é: \n";
            foreach (Control c in gpBoxRadioBtn.Controls)
            {

                RadioButton cb = (RadioButton)c;


                if (cb.Checked == true)
                {
                    message += cb.Text;
                }


            }

            MessageBox.Show(message);

        }

        private void btnNomes_Click(object sender, EventArgs e)
        {
            string message = "Os Nomes Selecionados são: \n";
            foreach (Control c in gpBoxCheckBox.Controls) {
            
                CheckBox cb = (CheckBox)c;
                

                if (cb.Checked == true)
                {
                    message += cb.Text;
                    message += "\n";
                }

                
            }

            MessageBox.Show(message);


        }
    }
}
