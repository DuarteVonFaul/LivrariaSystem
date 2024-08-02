namespace LivrariaSystem.views.modal
{
    partial class CartaoLeitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lbl_ID = new Label();
            lbl_Nome = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cartão;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.BackColor = Color.White;
            lbl_ID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ID.Location = new Point(185, 265);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(135, 25);
            lbl_ID.TabIndex = 1;
            lbl_ID.Text = "N. 0000000000";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.BackColor = Color.White;
            lbl_Nome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nome.Location = new Point(185, 229);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(341, 25);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "Nome Ficticio Para testar o Component";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(376, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // CartaoLeitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 336);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_Nome);
            Controls.Add(lbl_ID);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CartaoLeitor";
            Text = "Cartão Biblioteca";
            Load += this.CartaoLeitor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_ID;
        private Label lbl_Nome;
        private PictureBox pictureBox2;
    }
}