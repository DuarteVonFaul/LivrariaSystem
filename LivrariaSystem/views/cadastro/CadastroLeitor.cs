using LivrariaSystem.controllers;
using LivrariaSystem.database;
using LivrariaSystem.models;
using LivrariaSystem.models.response;
using LivrariaSystem.Properties;
using LivrariaSystem.resources;
using LivrariaSystem.utils;
using LivrariaSystem.views.modal;
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
                txtBoxState.Enabled = true;
                txtBoxStreet.Enabled = true;
                txtBoxCity.Enabled = true;

                txtBoxState.Text = "";
                txtBoxStreet.Text = "";
                txtBoxCity.Text = "";
                var task = new Task<Address?>(
                    () =>
                    {

                        return controller.GetAndressByPostalCode(txtBoxPostalCode.Text);

                    });
                task.Start();
                task.Wait();
                var andress = task.Result;

                if (andress != null)
                {
                    if (!String.IsNullOrEmpty(andress.State))
                    {
                        txtBoxState.Text = andress.State;
                        txtBoxState.Enabled = false;
                    }
                    if (!String.IsNullOrEmpty(andress.Street))
                    {
                        txtBoxStreet.Text = andress.Street;
                        txtBoxStreet.Enabled = false;
                    }
                    if (!String.IsNullOrEmpty(andress.City))
                    {
                        txtBoxCity.Text = andress.City;
                        txtBoxCity.Enabled = false;
                    }

                }
            }
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

                user.Id = Convert.ToString(DataBase.readers.Count + 1).PadLeft(10,'0');
                user.Password = Convert.ToString(PasswordGenerator.Generator());
                user.Name = txtBoxFullName.Text;
                user.Address.PostalCode = txtBoxPostalCode.Text;
                user.Address.City = txtBoxCity.Text;
                user.Address.Number = txtBoxNumber.Text;
                user.Address.State = txtBoxState.Text;
                user.Address.Street = txtBoxStreet.Text;
                user.Email = txtBoxMail.Text;
                user.PhoneNumber = txtBoxPhoneNumber.Text;

                controller.createUserReader(user);
                MessageBox.Show(user.ToString(), "Usuario Cadastrado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                CartaoLeitor childForm = new CartaoLeitor(Convert.ToInt32(user.Id));
                childForm.MdiParent = this.MdiParent; // Define o formulário pai
                childForm.Show();
            }
        }
    }
}
