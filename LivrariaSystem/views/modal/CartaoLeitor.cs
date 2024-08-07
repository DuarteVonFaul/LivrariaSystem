using LivrariaSystem.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaSystem.views.modal
{
    public partial class CartaoLeitor : Form
    {
        int IdLeitor;
        public CartaoLeitor(int idLeitor)
        {
            InitializeComponent();
            IdLeitor = idLeitor;
        }

        public CartaoLeitor()
        {
            InitializeComponent();
        }

        private void CartaoLeitor_Load(object sender, EventArgs e)
        {
            var user = DataBase.readers[IdLeitor - 1];

            lbl_ID.Text     = user.Id;
            lbl_Nome.Text   = user.Name;
        }
    }
}
