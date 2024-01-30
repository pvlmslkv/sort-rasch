namespace sort_rasch
{
    partial class FormforReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormforReg));
            reglogin = new TextBox();
            regpas = new TextBox();
            regpas1 = new TextBox();
            zaregistrirovatsa = new Button();
            pridumatlogin = new Label();
            pridematpalor = new Label();
            povtoritparol = new Label();
            SuspendLayout();
            // 
            // reglogin
            // 
            reglogin.Location = new Point(12, 59);
            reglogin.Name = "reglogin";
            reglogin.Size = new Size(776, 39);
            reglogin.TabIndex = 0;
            reglogin.TextChanged += reglogin_TextChanged;
            // 
            // regpas
            // 
            regpas.Location = new Point(12, 140);
            regpas.Name = "regpas";
            regpas.Size = new Size(776, 39);
            regpas.TabIndex = 1;
            regpas.TextChanged += regpas_TextChanged;
            // 
            // regpas1
            // 
            regpas1.Location = new Point(12, 221);
            regpas1.Name = "regpas1";
            regpas1.Size = new Size(776, 39);
            regpas1.TabIndex = 2;
            regpas1.TextChanged += regpas1_TextChanged;
            // 
            // zaregistrirovatsa
            // 
            zaregistrirovatsa.Cursor = Cursors.Hand;
            zaregistrirovatsa.FlatStyle = FlatStyle.Popup;
            zaregistrirovatsa.Location = new Point(292, 295);
            zaregistrirovatsa.Name = "zaregistrirovatsa";
            zaregistrirovatsa.Size = new Size(262, 45);
            zaregistrirovatsa.TabIndex = 3;
            zaregistrirovatsa.Text = "Зарегистрироваться";
            zaregistrirovatsa.UseVisualStyleBackColor = true;
            zaregistrirovatsa.Click += zaregestrirovatsa_Click;
            // 
            // pridumatlogin
            // 
            pridumatlogin.AutoSize = true;
            pridumatlogin.BackColor = SystemColors.Control;
            pridumatlogin.Location = new Point(12, 24);
            pridumatlogin.Name = "pridumatlogin";
            pridumatlogin.Size = new Size(221, 32);
            pridumatlogin.TabIndex = 4;
            pridumatlogin.Text = "Придумайте логин";
            // 
            // pridematpalor
            // 
            pridematpalor.AutoSize = true;
            pridematpalor.Location = new Point(12, 101);
            pridematpalor.Name = "pridematpalor";
            pridematpalor.Size = new Size(236, 32);
            pridematpalor.TabIndex = 5;
            pridematpalor.Text = "Придумайте пароль";
            // 
            // povtoritparol
            // 
            povtoritparol.AutoSize = true;
            povtoritparol.Location = new Point(12, 186);
            povtoritparol.Name = "povtoritparol";
            povtoritparol.Size = new Size(219, 32);
            povtoritparol.TabIndex = 6;
            povtoritparol.Text = "Повторите пароль";
            // 
            // FormforReg
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(povtoritparol);
            Controls.Add(pridematpalor);
            Controls.Add(pridumatlogin);
            Controls.Add(zaregistrirovatsa);
            Controls.Add(regpas1);
            Controls.Add(regpas);
            Controls.Add(reglogin);
            Name = "FormforReg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reglogin;
        private TextBox regpas;
        private TextBox regpas1;
        private Button zaregistrirovatsa;
        private Label pridumatlogin;
        private Label pridematpalor;
        private Label povtoritparol;
    }
}