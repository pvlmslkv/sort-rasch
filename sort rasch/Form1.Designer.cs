namespace sort_rasch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MakeSort = new Button();
            Input = new TextBox();
            Output = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MakeSort
            // 
            MakeSort.BackColor = SystemColors.ActiveBorder;
            MakeSort.Cursor = Cursors.Hand;
            MakeSort.FlatStyle = FlatStyle.Popup;
            MakeSort.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MakeSort.ForeColor = SystemColors.ControlText;
            MakeSort.Location = new Point(1150, 58);
            MakeSort.Name = "MakeSort";
            MakeSort.Size = new Size(241, 130);
            MakeSort.TabIndex = 0;
            MakeSort.Text = "Сортировать";
            MakeSort.UseVisualStyleBackColor = false;
            MakeSort.Click += button1_Click;
            // 
            // Input
            // 
            Input.Location = new Point(452, 58);
            Input.Name = "Input";
            Input.Size = new Size(553, 39);
            Input.TabIndex = 1;
            Input.TextChanged += Input_TextChanged_1;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(452, 125);
            Output.Name = "Output";
            Output.Size = new Size(337, 32);
            Output.TabIndex = 2;
            Output.Text = "Вводите числа через пробел";
            Output.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(74, 209);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1317, 397);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 125);
            label1.Name = "label1";
            label1.Size = new Size(320, 32);
            label1.TabIndex = 8;
            label1.Text = "Отсортированные числа ->";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1477, 607);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Output);
            Controls.Add(Input);
            Controls.Add(MakeSort);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сортировщик расчёской";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakeSort;
        private TextBox Input;
        private Label Output;
        private PictureBox pictureBox1;
        private Label label1;
    }
}