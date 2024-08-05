namespace LivrariaSystem.views
{
    partial class Form1
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
            grpBoxFilter = new GroupBox();
            btnId = new RadioButton();
            btnName = new RadioButton();
            txtBoxSearch = new TextBox();
            txtBoxIdBook = new TextBox();
            txtBoxNameBook = new TextBox();
            txtBoxAuthor = new TextBox();
            txtBoxNumPag = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            dtTimeAluguel = new DateTimePicker();
            dtTimeEntrega = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnAlugar = new Button();
            grpBoxFilter.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxFilter
            // 
            grpBoxFilter.Controls.Add(btnName);
            grpBoxFilter.Controls.Add(btnId);
            grpBoxFilter.Location = new Point(12, 12);
            grpBoxFilter.Name = "grpBoxFilter";
            grpBoxFilter.Size = new Size(172, 49);
            grpBoxFilter.TabIndex = 0;
            grpBoxFilter.TabStop = false;
            grpBoxFilter.Text = "Filtros";
            // 
            // btnId
            // 
            btnId.AutoSize = true;
            btnId.Location = new Point(21, 22);
            btnId.Name = "btnId";
            btnId.Size = new Size(62, 19);
            btnId.TabIndex = 0;
            btnId.TabStop = true;
            btnId.Text = "codigo";
            btnId.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            btnName.AutoSize = true;
            btnName.Location = new Point(89, 22);
            btnName.Name = "btnName";
            btnName.Size = new Size(58, 19);
            btnName.TabIndex = 1;
            btnName.TabStop = true;
            btnName.Text = "Nome";
            btnName.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(190, 30);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(598, 23);
            txtBoxSearch.TabIndex = 1;
            // 
            // txtBoxIdBook
            // 
            txtBoxIdBook.Location = new Point(33, 108);
            txtBoxIdBook.Name = "txtBoxIdBook";
            txtBoxIdBook.Size = new Size(151, 23);
            txtBoxIdBook.TabIndex = 2;
            // 
            // txtBoxNameBook
            // 
            txtBoxNameBook.Location = new Point(203, 108);
            txtBoxNameBook.Name = "txtBoxNameBook";
            txtBoxNameBook.Size = new Size(290, 23);
            txtBoxNameBook.TabIndex = 3;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(513, 108);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(275, 23);
            txtBoxAuthor.TabIndex = 4;
            // 
            // txtBoxNumPag
            // 
            txtBoxNumPag.Location = new Point(33, 171);
            txtBoxNumPag.Name = "txtBoxNumPag";
            txtBoxNumPag.Size = new Size(71, 23);
            txtBoxNumPag.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(35, 254);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(153, 23);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(249, 254);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(539, 23);
            textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(35, 322);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(388, 23);
            textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(513, 322);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(275, 23);
            textBox11.TabIndex = 11;
            // 
            // dtTimeAluguel
            // 
            dtTimeAluguel.Location = new Point(203, 168);
            dtTimeAluguel.Name = "dtTimeAluguel";
            dtTimeAluguel.Size = new Size(251, 23);
            dtTimeAluguel.TabIndex = 12;
            // 
            // dtTimeEntrega
            // 
            dtTimeEntrega.Location = new Point(513, 168);
            dtTimeEntrega.Name = "dtTimeEntrega";
            dtTimeEntrega.Size = new Size(249, 23);
            dtTimeEntrega.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 82);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 14;
            label1.Text = "Codigo Livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(203, 82);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 15;
            label2.Text = "Nome Livro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(513, 82);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 16;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(33, 144);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 17;
            label4.Text = "Numero de Paginas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(203, 144);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 18;
            label5.Text = "Data Alugel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(513, 144);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 19;
            label6.Text = "Data Entrega";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(33, 221);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 20;
            label7.Text = "Codigo Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(249, 221);
            label8.Name = "label8";
            label8.Size = new Size(125, 21);
            label8.TabIndex = 21;
            label8.Text = "Nome Completo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(33, 289);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 22;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(513, 289);
            label10.Name = "label10";
            label10.Size = new Size(67, 21);
            label10.TabIndex = 23;
            label10.Text = "Telefone";
            // 
            // btnAlugar
            // 
            btnAlugar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlugar.Location = new Point(310, 399);
            btnAlugar.Name = "btnAlugar";
            btnAlugar.Size = new Size(144, 39);
            btnAlugar.TabIndex = 24;
            btnAlugar.Text = "Alugar";
            btnAlugar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlugar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtTimeEntrega);
            Controls.Add(dtTimeAluguel);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(txtBoxNumPag);
            Controls.Add(txtBoxAuthor);
            Controls.Add(txtBoxNameBook);
            Controls.Add(txtBoxIdBook);
            Controls.Add(txtBoxSearch);
            Controls.Add(grpBoxFilter);
            Name = "Form1";
            Text = "FazerEmprestimo";
            Load += Form1_Load;
            grpBoxFilter.ResumeLayout(false);
            grpBoxFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBoxFilter;
        private RadioButton btnName;
        private RadioButton btnId;
        private TextBox txtBoxSearch;
        private TextBox txtBoxIdBook;
        private TextBox txtBoxNameBook;
        private TextBox txtBoxAuthor;
        private TextBox txtBoxNumPag;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private DateTimePicker dtTimeAluguel;
        private DateTimePicker dtTimeEntrega;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnAlugar;
    }
}