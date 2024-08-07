namespace LivrariaSystem
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            lIvroToolStripMenuItem = new ToolStripMenuItem();
            leitorToolStripMenuItem = new ToolStripMenuItem();
            movimentaçãoToolStripMenuItem = new ToolStripMenuItem();
            saidaToolStripMenuItem = new ToolStripMenuItem();
            entradaToolStripMenuItem = new ToolStripMenuItem();
            pedidoDeCompraToolStripMenuItem = new ToolStripMenuItem();
            comprarLIvrosToolStripMenuItem = new ToolStripMenuItem();
            movimentaToolStripMenuItem = new ToolStripMenuItem();
            arcevoToolStripMenuItem = new ToolStripMenuItem();
            devolverLivroToolStripMenuItem = new ToolStripMenuItem();
            alugarLivroToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, movimentaçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lIvroToolStripMenuItem, leitorToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // lIvroToolStripMenuItem
            // 
            lIvroToolStripMenuItem.Name = "lIvroToolStripMenuItem";
            lIvroToolStripMenuItem.Size = new Size(130, 26);
            lIvroToolStripMenuItem.Text = "LIvro";
            lIvroToolStripMenuItem.Click += lIvroToolStripMenuItem_Click;
            // 
            // leitorToolStripMenuItem
            // 
            leitorToolStripMenuItem.Name = "leitorToolStripMenuItem";
            leitorToolStripMenuItem.Size = new Size(130, 26);
            leitorToolStripMenuItem.Text = "Leitor";
            leitorToolStripMenuItem.Click += leitorToolStripMenuItem_Click;
            // 
            // movimentaçãoToolStripMenuItem
            // 
            movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saidaToolStripMenuItem, entradaToolStripMenuItem, movimentaToolStripMenuItem });
            movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            movimentaçãoToolStripMenuItem.Size = new Size(122, 24);
            movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // saidaToolStripMenuItem
            // 
            saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            saidaToolStripMenuItem.Size = new Size(224, 26);
            saidaToolStripMenuItem.Text = "Saida";
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidoDeCompraToolStripMenuItem, comprarLIvrosToolStripMenuItem });
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(224, 26);
            entradaToolStripMenuItem.Text = "Entrada";
            // 
            // pedidoDeCompraToolStripMenuItem
            // 
            pedidoDeCompraToolStripMenuItem.Name = "pedidoDeCompraToolStripMenuItem";
            pedidoDeCompraToolStripMenuItem.Size = new Size(216, 26);
            pedidoDeCompraToolStripMenuItem.Text = "Pedido de Compra";
            // 
            // comprarLIvrosToolStripMenuItem
            // 
            comprarLIvrosToolStripMenuItem.Name = "comprarLIvrosToolStripMenuItem";
            comprarLIvrosToolStripMenuItem.Size = new Size(216, 26);
            comprarLIvrosToolStripMenuItem.Text = "Comprar LIvros";
            // 
            // movimentaToolStripMenuItem
            // 
            movimentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arcevoToolStripMenuItem });
            movimentaToolStripMenuItem.Name = "movimentaToolStripMenuItem";
            movimentaToolStripMenuItem.Size = new Size(224, 26);
            movimentaToolStripMenuItem.Text = "Movimenta";
            // 
            // arcevoToolStripMenuItem
            // 
            arcevoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { devolverLivroToolStripMenuItem, alugarLivroToolStripMenuItem1 });
            arcevoToolStripMenuItem.Name = "arcevoToolStripMenuItem";
            arcevoToolStripMenuItem.Size = new Size(224, 26);
            arcevoToolStripMenuItem.Text = "Arcevo";
            // 
            // devolverLivroToolStripMenuItem
            // 
            devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            devolverLivroToolStripMenuItem.Size = new Size(224, 26);
            devolverLivroToolStripMenuItem.Text = "Devolução Livro";
            // 
            // alugarLivroToolStripMenuItem1
            // 
            alugarLivroToolStripMenuItem1.Name = "alugarLivroToolStripMenuItem1";
            alugarLivroToolStripMenuItem1.Size = new Size(224, 26);
            alugarLivroToolStripMenuItem1.Text = "Alugar Livro";
            alugarLivroToolStripMenuItem1.Click += alugarLivroToolStripMenuItem1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "LivrariaSystem";
            Load += home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem lIvroToolStripMenuItem;
        private ToolStripMenuItem leitorToolStripMenuItem;
        private ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private ToolStripMenuItem saidaToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem pedidoDeCompraToolStripMenuItem;
        private ToolStripMenuItem comprarLIvrosToolStripMenuItem;
        private ToolStripMenuItem movimentaToolStripMenuItem;
        private ToolStripMenuItem arcevoToolStripMenuItem;
        private ToolStripMenuItem devolverLivroToolStripMenuItem;
        private ToolStripMenuItem alugarLivroToolStripMenuItem1;
    }
}
