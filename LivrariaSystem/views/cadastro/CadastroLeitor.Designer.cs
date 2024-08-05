namespace LivrariaSystem.views.cadastro
{
    partial class CadastroLeitor
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
            components = new System.ComponentModel.Container();
            txtBoxFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxMail = new TextBox();
            label3 = new Label();
            txtBoxPhoneNumber = new TextBox();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            txtBoxNumber = new TextBox();
            label9 = new Label();
            txtBoxState = new TextBox();
            label7 = new Label();
            txtBoxCity = new TextBox();
            label6 = new Label();
            txtBoxStreet = new TextBox();
            label5 = new Label();
            txtBoxPostalCode = new TextBox();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Location = new Point(12, 81);
            txtBoxFullName.Name = "txtBoxFullName";
            txtBoxFullName.Size = new Size(546, 23);
            txtBoxFullName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 1;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtBoxMail
            // 
            txtBoxMail.Location = new Point(12, 135);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(362, 23);
            txtBoxMail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(406, 111);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 5;
            label3.Text = "Numero Telefone";
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(406, 135);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(152, 23);
            txtBoxPhoneNumber.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxNumber);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBoxState);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBoxCity);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtBoxStreet);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBoxPostalCode);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 177);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // txtBoxNumber
            // 
            txtBoxNumber.Location = new Point(441, 59);
            txtBoxNumber.Name = "txtBoxNumber";
            txtBoxNumber.Size = new Size(82, 27);
            txtBoxNumber.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(441, 37);
            label9.Name = "label9";
            label9.Size = new Size(68, 19);
            label9.TabIndex = 19;
            label9.Text = "NUMERO";
            // 
            // txtBoxState
            // 
            txtBoxState.Location = new Point(358, 59);
            txtBoxState.Name = "txtBoxState";
            txtBoxState.Size = new Size(61, 27);
            txtBoxState.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(358, 37);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 15;
            label7.Text = "ESTADO";
            // 
            // txtBoxCity
            // 
            txtBoxCity.Location = new Point(170, 59);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(167, 27);
            txtBoxCity.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(170, 37);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 13;
            label6.Text = "CIDADE";
            // 
            // txtBoxStreet
            // 
            txtBoxStreet.Location = new Point(15, 109);
            txtBoxStreet.Name = "txtBoxStreet";
            txtBoxStreet.Size = new Size(508, 27);
            txtBoxStreet.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(15, 87);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 11;
            label5.Text = "RUA";
            // 
            // txtBoxPostalCode
            // 
            txtBoxPostalCode.Location = new Point(15, 59);
            txtBoxPostalCode.Name = "txtBoxPostalCode";
            txtBoxPostalCode.Size = new Size(139, 27);
            txtBoxPostalCode.TabIndex = 9;
            txtBoxPostalCode.TextChanged += txtBoxPostalCode_TextChanged;
            txtBoxPostalCode.KeyDown += txtBoxPostalCode_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(15, 37);
            label4.Name = "label4";
            label4.Size = new Size(33, 19);
            label4.TabIndex = 9;
            label4.Text = "CEP";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 9F);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripSeparator2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(575, 47);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.add_user;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(44, 44);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.alter_switch;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(44, 44);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.broom;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(44, 44);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // CadastroLeitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 353);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(label2);
            Controls.Add(txtBoxMail);
            Controls.Add(label1);
            Controls.Add(txtBoxFullName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroLeitor";
            Text = "CadastroLeitor";
            Load += CadastroLeitor_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxFullName;
        private Label label1;
        private Label label2;
        private TextBox txtBoxMail;
        private Label label3;
        private TextBox txtBoxPhoneNumber;
        private BindingSource bindingSource1;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private TextBox txtBoxState;
        private Label label7;
        private TextBox txtBoxCity;
        private Label label6;
        private TextBox txtBoxStreet;
        private Label label5;
        private TextBox txtBoxPostalCode;
        private Label label4;
        private TextBox txtBoxNumber;
        private Label label9;
    }
}