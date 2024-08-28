namespace LivrariaSystem.views.cadastro
{
    partial class CadastroLivro
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
            comboBoxGener = new ComboBox();
            txtBoxName = new TextBox();
            dtTimeDate = new DateTimePicker();
            txtBoxAuthor = new TextBox();
            txtBoxNumPag = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            listViewGeners = new ListView();
            button2 = new Button();
            txtCodigo = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBoxGener
            // 
            comboBoxGener.FormattingEnabled = true;
            comboBoxGener.Location = new Point(41, 224);
            comboBoxGener.Name = "comboBoxGener";
            comboBoxGener.Size = new Size(180, 23);
            comboBoxGener.TabIndex = 0;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(138, 50);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(210, 23);
            txtBoxName.TabIndex = 1;
            // 
            // dtTimeDate
            // 
            dtTimeDate.Location = new Point(41, 162);
            dtTimeDate.Name = "dtTimeDate";
            dtTimeDate.Size = new Size(180, 23);
            dtTimeDate.TabIndex = 2;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(41, 106);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(307, 23);
            txtBoxAuthor.TabIndex = 3;
            // 
            // txtBoxNumPag
            // 
            txtBoxNumPag.Location = new Point(237, 162);
            txtBoxNumPag.Name = "txtBoxNumPag";
            txtBoxNumPag.Size = new Size(111, 23);
            txtBoxNumPag.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(138, 26);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 5;
            label1.Text = "Nome do Livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 6;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(41, 200);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 7;
            label3.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(237, 138);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 8;
            label4.Text = "N. Paginas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(41, 138);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 9;
            label5.Text = "Data de Lançamento";
            // 
            // button1
            // 
            button1.Location = new Point(237, 223);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 10;
            button1.Text = "Adicionar Genero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listViewGeners
            // 
            listViewGeners.Location = new Point(41, 252);
            listViewGeners.Name = "listViewGeners";
            listViewGeners.Size = new Size(307, 139);
            listViewGeners.TabIndex = 11;
            listViewGeners.UseCompatibleStateImageBehavior = false;
            listViewGeners.View = View.Tile;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(116, 408);
            button2.Name = "button2";
            button2.Size = new Size(156, 36);
            button2.TabIndex = 12;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(41, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(90, 23);
            txtCodigo.TabIndex = 13;
            txtCodigo.KeyDown += textBox1_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(41, 26);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 14;
            label6.Text = "Codigo";
            // 
            // CadastroLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 484);
            Controls.Add(label6);
            Controls.Add(txtCodigo);
            Controls.Add(button2);
            Controls.Add(listViewGeners);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxNumPag);
            Controls.Add(txtBoxAuthor);
            Controls.Add(dtTimeDate);
            Controls.Add(txtBoxName);
            Controls.Add(comboBoxGener);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroLivro";
            Text = "CadastroLivro";
            Load += CadastroLivro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGener;
        private TextBox txtBoxName;
        private DateTimePicker dtTimeDate;
        private TextBox txtBoxAuthor;
        private TextBox txtBoxNumPag;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ListView listViewGeners;
        private Button button2;
        private TextBox txtCodigo;
        private Label label6;
    }
}