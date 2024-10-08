﻿using LivrariaSystem.controllers;
using LivrariaSystem.database;
using LivrariaSystem.models;
using LivrariaSystem.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LivrariaSystem.views.cadastro
{
    public partial class CadastroLivro : Form
    {

        Book book = new Book();
        BookController controller;

        public CadastroLivro()
        {
            InitializeComponent();
            comboBoxGener.DataSource = DataBase.geners;
            controller = new BookController();
        }

        //AddGenero
        private void button2_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtBoxName.Text) ||
                String.IsNullOrEmpty(txtBoxAuthor.Text) ||
                String.IsNullOrEmpty(txtBoxNumPag.Text) ||
                String.IsNullOrEmpty(dtTimeDate.Text) ||
                listViewGeners.Items.Count <= 0)
            {
                MessageBox.Show("Todos os campos são obrigatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                book.Id = DataBase.books.Count + 1;
                book.Title = txtBoxName.Text;
                book.Author = txtBoxAuthor.Text;
                book.NumberPag = Convert.ToInt32(txtBoxNumPag.Text);
                book.Date = Convert.ToDateTime(dtTimeDate.Text);
                book.count = 10;

                controller.createBook(book);
                MessageBox.Show(book.ToString(), "Usuario Cadastrado com SUcesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        //Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            book.Genres.Add(comboBoxGener.Text);

            listViewGeners.Items.Add(comboBoxGener.Text);


        }

        private void CadastroLivro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtBoxName.Text = "";
                txtBoxAuthor.Text = "";
                txtBoxNumPag.Text = "";
                dtTimeDate.Text = "";
                listViewGeners.Items.Clear();

                var book = controller.GetBookById(txtCodigo.Text);
                if(book != null)
                {
                    txtCodigo.Text = Convert.ToString(book.Id);
                    txtBoxName.Text = book.Title;
                    txtBoxAuthor.Text = book.Author;
                    txtBoxNumPag.Text = Convert.ToString(book.NumberPag);
                    dtTimeDate.Text = book.Date.ToString();
                    foreach (string gener in book.Genres)
                    {
                        listViewGeners.Items.Add(gener);
                    }
                }
                else
                {
                    MessageBox.Show("Livro não encontrado", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                
                
            }
        }
    }
}
