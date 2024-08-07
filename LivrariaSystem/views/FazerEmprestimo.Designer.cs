namespace LivrariaSystem.views
{
    partial class FazerEmprestimo
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
            btnName = new RadioButton();
            btnId = new RadioButton();
            txtBoxSearch = new TextBox();
            txtBoxIdBook = new TextBox();
            txtBoxNameBook = new TextBox();
            txtBoxAuthor = new TextBox();
            txtBoxNumPag = new TextBox();
            txtBoxCodUser = new TextBox();
            ttxtBoxNameUser = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxNumberPhone = new TextBox();
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
            grpBoxFilter.Location = new Point(14, 16);
            grpBoxFilter.Margin = new Padding(3, 4, 3, 4);
            grpBoxFilter.Name = "grpBoxFilter";
            grpBoxFilter.Padding = new Padding(3, 4, 3, 4);
            grpBoxFilter.Size = new Size(197, 65);
            grpBoxFilter.TabIndex = 0;
            grpBoxFilter.TabStop = false;
            grpBoxFilter.Text = "Filtros";
            // 
            // btnName
            // 
            btnName.AutoSize = true;
            btnName.Location = new Point(102, 29);
            btnName.Margin = new Padding(3, 4, 3, 4);
            btnName.Name = "btnName";
            btnName.Size = new Size(71, 24);
            btnName.TabIndex = 1;
            btnName.Text = "Nome";
            btnName.UseVisualStyleBackColor = true;
            // 
            // btnId
            // 
            btnId.AutoSize = true;
            btnId.Checked = true;
            btnId.Location = new Point(24, 29);
            btnId.Margin = new Padding(3, 4, 3, 4);
            btnId.Name = "btnId";
            btnId.Size = new Size(77, 24);
            btnId.TabIndex = 0;
            btnId.TabStop = true;
            btnId.Text = "codigo";
            btnId.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(217, 40);
            txtBoxSearch.Margin = new Padding(3, 4, 3, 4);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(683, 27);
            txtBoxSearch.TabIndex = 1;
            txtBoxSearch.KeyDown += txtBoxSearch_KeyDown;
            // 
            // txtBoxIdBook
            // 
            txtBoxIdBook.Enabled = false;
            txtBoxIdBook.Location = new Point(38, 144);
            txtBoxIdBook.Margin = new Padding(3, 4, 3, 4);
            txtBoxIdBook.Name = "txtBoxIdBook";
            txtBoxIdBook.Size = new Size(172, 27);
            txtBoxIdBook.TabIndex = 2;
            // 
            // txtBoxNameBook
            // 
            txtBoxNameBook.Enabled = false;
            txtBoxNameBook.Location = new Point(232, 144);
            txtBoxNameBook.Margin = new Padding(3, 4, 3, 4);
            txtBoxNameBook.Name = "txtBoxNameBook";
            txtBoxNameBook.Size = new Size(331, 27);
            txtBoxNameBook.TabIndex = 3;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Enabled = false;
            txtBoxAuthor.Location = new Point(586, 144);
            txtBoxAuthor.Margin = new Padding(3, 4, 3, 4);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(314, 27);
            txtBoxAuthor.TabIndex = 4;
            // 
            // txtBoxNumPag
            // 
            txtBoxNumPag.Enabled = false;
            txtBoxNumPag.Location = new Point(38, 228);
            txtBoxNumPag.Margin = new Padding(3, 4, 3, 4);
            txtBoxNumPag.Name = "txtBoxNumPag";
            txtBoxNumPag.Size = new Size(81, 27);
            txtBoxNumPag.TabIndex = 5;
            // 
            // txtBoxCodUser
            // 
            txtBoxCodUser.Location = new Point(40, 339);
            txtBoxCodUser.Margin = new Padding(3, 4, 3, 4);
            txtBoxCodUser.Name = "txtBoxCodUser";
            txtBoxCodUser.Size = new Size(174, 27);
            txtBoxCodUser.TabIndex = 8;
            txtBoxCodUser.KeyDown += textBox8_KeyDown;
            // 
            // ttxtBoxNameUser
            // 
            ttxtBoxNameUser.Enabled = false;
            ttxtBoxNameUser.Location = new Point(285, 339);
            ttxtBoxNameUser.Margin = new Padding(3, 4, 3, 4);
            ttxtBoxNameUser.Name = "ttxtBoxNameUser";
            ttxtBoxNameUser.Size = new Size(615, 27);
            ttxtBoxNameUser.TabIndex = 9;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Enabled = false;
            txtBoxEmail.Location = new Point(40, 429);
            txtBoxEmail.Margin = new Padding(3, 4, 3, 4);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(443, 27);
            txtBoxEmail.TabIndex = 10;
            // 
            // txtBoxNumberPhone
            // 
            txtBoxNumberPhone.Enabled = false;
            txtBoxNumberPhone.Location = new Point(586, 429);
            txtBoxNumberPhone.Margin = new Padding(3, 4, 3, 4);
            txtBoxNumberPhone.Name = "txtBoxNumberPhone";
            txtBoxNumberPhone.Size = new Size(314, 27);
            txtBoxNumberPhone.TabIndex = 11;
            // 
            // dtTimeAluguel
            // 
            dtTimeAluguel.Location = new Point(232, 224);
            dtTimeAluguel.Margin = new Padding(3, 4, 3, 4);
            dtTimeAluguel.Name = "dtTimeAluguel";
            dtTimeAluguel.Size = new Size(286, 27);
            dtTimeAluguel.TabIndex = 12;
            // 
            // dtTimeEntrega
            // 
            dtTimeEntrega.Location = new Point(586, 224);
            dtTimeEntrega.Margin = new Padding(3, 4, 3, 4);
            dtTimeEntrega.Name = "dtTimeEntrega";
            dtTimeEntrega.Size = new Size(284, 27);
            dtTimeEntrega.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 109);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 14;
            label1.Text = "Codigo Livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(232, 109);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 15;
            label2.Text = "Nome Livro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(586, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 16;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(38, 192);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 17;
            label4.Text = "Numero de Paginas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(232, 192);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 18;
            label5.Text = "Data Alugel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(586, 192);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 19;
            label6.Text = "Data Entrega";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(38, 295);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 20;
            label7.Text = "Codigo Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(285, 295);
            label8.Name = "label8";
            label8.Size = new Size(158, 28);
            label8.TabIndex = 21;
            label8.Text = "Nome Completo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(38, 385);
            label9.Name = "label9";
            label9.Size = new Size(59, 28);
            label9.TabIndex = 22;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(586, 385);
            label10.Name = "label10";
            label10.Size = new Size(84, 28);
            label10.TabIndex = 23;
            label10.Text = "Telefone";
            // 
            // btnAlugar
            // 
            btnAlugar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlugar.Location = new Point(354, 532);
            btnAlugar.Margin = new Padding(3, 4, 3, 4);
            btnAlugar.Name = "btnAlugar";
            btnAlugar.Size = new Size(165, 52);
            btnAlugar.TabIndex = 24;
            btnAlugar.Text = "Alugar";
            btnAlugar.UseVisualStyleBackColor = true;
            btnAlugar.Click += btnAlugar_Click;
            // 
            // FazerEmprestimo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Controls.Add(txtBoxNumberPhone);
            Controls.Add(txtBoxEmail);
            Controls.Add(ttxtBoxNameUser);
            Controls.Add(txtBoxCodUser);
            Controls.Add(txtBoxNumPag);
            Controls.Add(txtBoxAuthor);
            Controls.Add(txtBoxNameBook);
            Controls.Add(txtBoxIdBook);
            Controls.Add(txtBoxSearch);
            Controls.Add(grpBoxFilter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FazerEmprestimo";
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
        private TextBox txtBoxCodUser;
        private TextBox ttxtBoxNameUser;
        private TextBox txtBoxEmail;
        private TextBox txtBoxNumberPhone;
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