﻿namespace Zadanie_03
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button1.Location = new Point(157, 45);
            button1.Name = "button1";
            button1.Size = new Size(135, 44);
            button1.TabIndex = 0;
            button1.Text = "Informacja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button2.Location = new Point(26, 105);
            button2.Name = "button2";
            button2.Size = new Size(136, 42);
            button2.TabIndex = 1;
            button2.Text = "Ostrzezenie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button3.Location = new Point(285, 105);
            button3.Name = "button3";
            button3.Size = new Size(136, 42);
            button3.TabIndex = 2;
            button3.Text = "Decyzja";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(455, 191);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
