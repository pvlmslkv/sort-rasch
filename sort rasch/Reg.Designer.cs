namespace sort_rasch
{
    partial class Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            loginforReg = new TextBox();
            pasforReg = new TextBox();
            MakeReg = new Button();
            GoReg = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginforReg
            // 
            loginforReg.Location = new Point(13, 57);
            loginforReg.Name = "loginforReg";
            loginforReg.Size = new Size(775, 39);
            loginforReg.TabIndex = 0;
            loginforReg.TextChanged += loginforReg_TextChanged;
            // 
            // pasforReg
            // 
            pasforReg.Location = new Point(12, 146);
            pasforReg.Name = "pasforReg";
            pasforReg.PasswordChar = '$';
            pasforReg.Size = new Size(776, 39);
            pasforReg.TabIndex = 1;
            // 
            // MakeReg
            // 
            MakeReg.Cursor = Cursors.Hand;
            MakeReg.FlatStyle = FlatStyle.Popup;
            MakeReg.Location = new Point(140, 247);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(150, 46);
            MakeReg.TabIndex = 2;
            MakeReg.Text = "Войти";
            MakeReg.UseVisualStyleBackColor = true;
            MakeReg.Click += button1_Click;
            // 
            // GoReg
            // 
            GoReg.Cursor = Cursors.Hand;
            GoReg.FlatStyle = FlatStyle.Popup;
            GoReg.Location = new Point(425, 247);
            GoReg.Name = "GoReg";
            GoReg.Size = new Size(279, 46);
            GoReg.TabIndex = 3;
            GoReg.Text = "Зарегистрироваться";
            GoReg.UseVisualStyleBackColor = true;
            GoReg.Click += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 4;
            label1.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 379);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GoReg);
            Controls.Add(MakeReg);
            Controls.Add(pasforReg);
            Controls.Add(loginforReg);
            ForeColor = SystemColors.ControlText;
            Name = "Reg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosed += Reg_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginforReg;
        private TextBox pasforReg;
        private Button MakeReg;
        private Button GoReg;
        private Label label1;
        private Label label2;
    }
}