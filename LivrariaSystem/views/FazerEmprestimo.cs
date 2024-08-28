using LivrariaSystem.controllers;
using LivrariaSystem.models;
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
    public partial class FazerEmprestimo : Form
    {

        BookController bookController;
        UserController userController;
        Book book;
        Reader user;
        public FazerEmprestimo()
        {
            InitializeComponent();
            bookController = new BookController();
            userController = new UserController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            if (user != null && book != null)
            {
                user.booksReceived.Add(new BookRent
                {
                    ReceivingDate = Convert.ToDateTime(dtTimeAluguel.Text),
                    ReturnDate = Convert.ToDateTime(dtTimeEntrega.Text),
                    book = book
                });

                MessageBox.Show(user.ToString(),"Livro Alugado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falta informações a serem preencidas", "Erro ao alugar Livro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnId.Checked) { 
                    book = bookController.GetBookById(txtBoxSearch.Text);
                    txtBoxIdBook.Text   = book.Id.ToString();
                    txtBoxNameBook.Text = book.Title;
                    txtBoxAuthor.Text   = book.Author;
                    txtBoxNumPag.Text   = book.NumberPag.ToString();
                }
                else if (btnName.Checked) {
                    book = bookController.GetBookByName(txtBoxSearch.Text);
                    txtBoxIdBook.Text   = book.Id.ToString();
                    txtBoxNameBook.Text = book.Title;
                    txtBoxAuthor.Text   = book.Author;
                    txtBoxNumPag.Text   = book.NumberPag.ToString();
                }
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {




            }
        }
    }
}
