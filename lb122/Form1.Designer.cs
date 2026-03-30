namespace lb122
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelResult = new Label();
            textBoxAmount = new TextBox();
            textBoxMonths = new TextBox();
            comboBoxBank = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 97);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Credit amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 97);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Months";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 97);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Bank";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(371, 185);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(39, 15);
            labelResult.TabIndex = 3;
            labelResult.Text = "Result";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(42, 115);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 4;
            // 
            // textBoxMonths
            // 
            textBoxMonths.Location = new Point(198, 115);
            textBoxMonths.Name = "textBoxMonths";
            textBoxMonths.Size = new Size(100, 23);
            textBoxMonths.TabIndex = 5;
            textBoxMonths.TextChanged += textBoxMonths_TextChanged;
            // 
            // comboBoxBank
            // 
            comboBoxBank.FormattingEnabled = true;
            comboBoxBank.Items.AddRange(new object[] { "PrivatBank", "MonoBank", "OschadBank" });
            comboBoxBank.Location = new Point(318, 115);
            comboBoxBank.Name = "comboBoxBank";
            comboBoxBank.Size = new Size(121, 23);
            comboBoxBank.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(177, 174);
            button1.Name = "button1";
            button1.Size = new Size(106, 36);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBoxBank);
            Controls.Add(textBoxMonths);
            Controls.Add(textBoxAmount);
            Controls.Add(labelResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelResult;
        private TextBox textBoxAmount;
        private TextBox textBoxMonths;
        private ComboBox comboBoxBank;
        private Button button1;
    }
}
