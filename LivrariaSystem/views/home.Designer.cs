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
            alugarLivroToolStripMenuItem = new ToolStripMenuItem();
            entradaToolStripMenuItem = new ToolStripMenuItem();
            pedidoDeCompraToolStripMenuItem = new ToolStripMenuItem();
            comprarLIvrosToolStripMenuItem = new ToolStripMenuItem();
            movimentaToolStripMenuItem = new ToolStripMenuItem();
            arcevoToolStripMenuItem = new ToolStripMenuItem();
            devolverLivroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, movimentaçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lIvroToolStripMenuItem, leitorToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // lIvroToolStripMenuItem
            // 
            lIvroToolStripMenuItem.Name = "lIvroToolStripMenuItem";
            lIvroToolStripMenuItem.Size = new Size(180, 22);
            lIvroToolStripMenuItem.Text = "LIvro";
            lIvroToolStripMenuItem.Click += lIvroToolStripMenuItem_Click;
            // 
            // leitorToolStripMenuItem
            // 
            leitorToolStripMenuItem.Name = "leitorToolStripMenuItem";
            leitorToolStripMenuItem.Size = new Size(180, 22);
            leitorToolStripMenuItem.Text = "Leitor";
            leitorToolStripMenuItem.Click += leitorToolStripMenuItem_Click;
            // 
            // movimentaçãoToolStripMenuItem
            // 
            movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saidaToolStripMenuItem, entradaToolStripMenuItem, movimentaToolStripMenuItem });
            movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            movimentaçãoToolStripMenuItem.Size = new Size(99, 20);
            movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // saidaToolStripMenuItem
            // 
            saidaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alugarLivroToolStripMenuItem });
            saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            saidaToolStripMenuItem.Size = new Size(180, 22);
            saidaToolStripMenuItem.Text = "Saida";
            // 
            // alugarLivroToolStripMenuItem
            // 
            alugarLivroToolStripMenuItem.Name = "alugarLivroToolStripMenuItem";
            alugarLivroToolStripMenuItem.Size = new Size(180, 22);
            alugarLivroToolStripMenuItem.Text = "Alugar Livro";
            alugarLivroToolStripMenuItem.Click += alugarLivroToolStripMenuItem_Click;
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidoDeCompraToolStripMenuItem, comprarLIvrosToolStripMenuItem });
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(180, 22);
            entradaToolStripMenuItem.Text = "Entrada";
            // 
            // pedidoDeCompraToolStripMenuItem
            // 
            pedidoDeCompraToolStripMenuItem.Name = "pedidoDeCompraToolStripMenuItem";
            pedidoDeCompraToolStripMenuItem.Size = new Size(180, 22);
            pedidoDeCompraToolStripMenuItem.Text = "Pedido de Compra";
            // 
            // comprarLIvrosToolStripMenuItem
            // 
            comprarLIvrosToolStripMenuItem.Name = "comprarLIvrosToolStripMenuItem";
            comprarLIvrosToolStripMenuItem.Size = new Size(180, 22);
            comprarLIvrosToolStripMenuItem.Text = "Comprar LIvros";
            // 
            // movimentaToolStripMenuItem
            // 
            movimentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arcevoToolStripMenuItem });
            movimentaToolStripMenuItem.Name = "movimentaToolStripMenuItem";
            movimentaToolStripMenuItem.Size = new Size(180, 22);
            movimentaToolStripMenuItem.Text = "Movimenta";
            // 
            // arcevoToolStripMenuItem
            // 
            arcevoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { devolverLivroToolStripMenuItem });
            arcevoToolStripMenuItem.Name = "arcevoToolStripMenuItem";
            arcevoToolStripMenuItem.Size = new Size(111, 22);
            arcevoToolStripMenuItem.Text = "Arcevo";
            // 
            // devolverLivroToolStripMenuItem
            // 
            devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            devolverLivroToolStripMenuItem.Size = new Size(180, 22);
            devolverLivroToolStripMenuItem.Text = "Devolver Livro";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem alugarLivroToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem pedidoDeCompraToolStripMenuItem;
        private ToolStripMenuItem comprarLIvrosToolStripMenuItem;
        private ToolStripMenuItem movimentaToolStripMenuItem;
        private ToolStripMenuItem arcevoToolStripMenuItem;
        private ToolStripMenuItem devolverLivroToolStripMenuItem;
    }
}
