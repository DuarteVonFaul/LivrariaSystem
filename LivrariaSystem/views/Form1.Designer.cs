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
            gpBoxCheckBox = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            gpBoxRadioBtn = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btnNomes = new Button();
            btnGenero = new Button();
            gpBoxCheckBox.SuspendLayout();
            gpBoxRadioBtn.SuspendLayout();
            SuspendLayout();
            // 
            // gpBoxCheckBox
            // 
            gpBoxCheckBox.Controls.Add(checkBox3);
            gpBoxCheckBox.Controls.Add(checkBox2);
            gpBoxCheckBox.Controls.Add(checkBox1);
            gpBoxCheckBox.ImeMode = ImeMode.NoControl;
            gpBoxCheckBox.Location = new Point(42, 62);
            gpBoxCheckBox.Name = "gpBoxCheckBox";
            gpBoxCheckBox.Size = new Size(296, 143);
            gpBoxCheckBox.TabIndex = 0;
            gpBoxCheckBox.TabStop = false;
            gpBoxCheckBox.Text = "Checkbox";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Kalline";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(22, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Guilherme";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(22, 72);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(84, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Nathanniel";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // gpBoxRadioBtn
            // 
            gpBoxRadioBtn.Controls.Add(radioButton2);
            gpBoxRadioBtn.Controls.Add(radioButton1);
            gpBoxRadioBtn.Location = new Point(404, 62);
            gpBoxRadioBtn.Name = "gpBoxRadioBtn";
            gpBoxRadioBtn.Size = new Size(200, 100);
            gpBoxRadioBtn.TabIndex = 1;
            gpBoxRadioBtn.TabStop = false;
            gpBoxRadioBtn.Text = "radiobutton";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(38, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Homem";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(38, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mulher";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnNomes
            // 
            btnNomes.Location = new Point(42, 229);
            btnNomes.Name = "btnNomes";
            btnNomes.Size = new Size(75, 23);
            btnNomes.TabIndex = 2;
            btnNomes.Text = "Nomes";
            btnNomes.UseVisualStyleBackColor = true;
            btnNomes.Click += btnNomes_Click;
            // 
            // btnGenero
            // 
            btnGenero.Location = new Point(404, 182);
            btnGenero.Name = "btnGenero";
            btnGenero.Size = new Size(75, 23);
            btnGenero.TabIndex = 3;
            btnGenero.Text = "genero";
            btnGenero.UseVisualStyleBackColor = true;
            btnGenero.Click += btnGenero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenero);
            Controls.Add(btnNomes);
            Controls.Add(gpBoxRadioBtn);
            Controls.Add(gpBoxCheckBox);
            Name = "Form1";
            Text = "Form1";
            gpBoxCheckBox.ResumeLayout(false);
            gpBoxCheckBox.PerformLayout();
            gpBoxRadioBtn.ResumeLayout(false);
            gpBoxRadioBtn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpBoxCheckBox;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox gpBoxRadioBtn;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnNomes;
        private Button btnGenero;
    }
}