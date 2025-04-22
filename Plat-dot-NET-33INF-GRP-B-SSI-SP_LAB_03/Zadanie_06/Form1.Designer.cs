namespace Zadanie_06
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            button1 = new Button();
            textBoxSMPT = new TextBox();
            textBoxPort = new TextBox();
            textBoxPassword = new TextBox();
            textBoxAttachment = new TextBox();
            label4 = new Label();
            buttonBrowse = new Button();
            label5 = new Label();
            textBoxAuthor = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Wyslij do...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Temat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 432);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(496, 174);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 386);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Zalaczniki";
            // 
            // button1
            // 
            button1.Location = new Point(205, 613);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Wyslij";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxSMPT
            // 
            textBoxSMPT.Location = new Point(13, 227);
            textBoxSMPT.Name = "textBoxSMPT";
            textBoxSMPT.Size = new Size(149, 27);
            textBoxSMPT.TabIndex = 7;
            textBoxSMPT.Text = "SMPT server";
            textBoxSMPT.TextChanged += textBoxSMPT_TextChanged;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(13, 276);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(149, 27);
            textBoxPort.TabIndex = 8;
            textBoxPort.Text = "Port";
            textBoxPort.TextChanged += textBoxPort_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(13, 328);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(149, 27);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxAttachment
            // 
            textBoxAttachment.Location = new Point(13, 379);
            textBoxAttachment.Name = "textBoxAttachment";
            textBoxAttachment.Size = new Size(149, 27);
            textBoxAttachment.TabIndex = 10;
            textBoxAttachment.TextChanged += textBoxAttachment_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 335);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 11;
            label4.Text = "Haslo";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(249, 379);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 29);
            buttonBrowse.TabIndex = 12;
            buttonBrowse.Text = "Dodaj...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 12);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 14;
            label5.Text = "Twoj e-mail:";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(12, 37);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(228, 27);
            textBoxAuthor.TabIndex = 13;
            textBoxAuthor.TextChanged += textBoxAuthor_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 654);
            Controls.Add(label5);
            Controls.Add(textBoxAuthor);
            Controls.Add(buttonBrowse);
            Controls.Add(label4);
            Controls.Add(textBoxAttachment);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxSMPT);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label3;
        private Button button1;
        private TextBox textBoxSMPT;
        private TextBox textBoxPort;
        private TextBox textBoxPassword;
        private TextBox textBoxAttachment;
        private Label label4;
        private Button buttonBrowse;
        private Label label5;
        private TextBox textBoxAuthor;
    }
}
