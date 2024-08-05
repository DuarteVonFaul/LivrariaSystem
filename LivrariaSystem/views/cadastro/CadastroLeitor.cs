using LivrariaSystem.controllers;
using LivrariaSystem.models;
using LivrariaSystem.models.response;
using LivrariaSystem.Properties;
using LivrariaSystem.resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaSystem.views.cadastro
{
    public partial class CadastroLeitor : Form
    {

        public UserController controller;

        public CadastroLeitor()
        {
            InitializeComponent();
            controller = new UserController();
        }

        private void txtBoxPostalCode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                // Suprime o bip padrão do TextBox ao pressionar Enter
                e.SuppressKeyPress = true;

                Task.Run(() =>
                {
                    // Realize a operação de busca no thread de fundo
                    var andress = controller.GetAndressByPostalCode(txtBoxPostalCode.Text);

                    // Atualize a interface do usuário no thread principal
                    this.Invoke(new Action(() =>
                    {
                        if (andress != null)
                        {
                            txtBoxCity.Text = andress.City;
                            txtBoxState.Text = andress.State;
                            txtBoxStreet.Text = andress.Street;
                        }
                        else
                        {
                            // Handle the case where no address was found
                            MessageBox.Show("Address not found.");
                        }
                    }));
                });
            }




        }

        private void CadastroLeitor_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)


        {

            if (String.IsNullOrEmpty(txtBoxPostalCode.Text) ||
                String.IsNullOrEmpty(txtBoxCity.Text) ||
                String.IsNullOrEmpty(txtBoxState.Text) ||
                String.IsNullOrEmpty(txtBoxStreet.Text) ||
                String.IsNullOrEmpty(txtBoxFullName.Text) ||
                String.IsNullOrEmpty(txtBoxNumber.Text) ||
                String.IsNullOrEmpty(txtBoxMail.Text) ||
                String.IsNullOrEmpty(txtBoxPhoneNumber.Text))
            {
                MessageBox.Show("Todos os campos são obrigatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reader user = new Reader();
                user.Name = txtBoxFullName.Text;
                user.Address.PostalCode = txtBoxPostalCode.Text;
                user.Address.City = txtBoxCity.Text;
                user.Address.Number = txtBoxNumber.Text;
                user.Address.State = txtBoxState.Text;
                user.Address.Street = txtBoxStreet.Text;
                user.Email = txtBoxMail.Text;
                user.PhoneNumber = txtBoxPhoneNumber.Text;

                controller.createUserReader(user);
                MessageBox.Show(user.ToString(), "Usuario Cadastrado com SUcesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtBoxPostalCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
