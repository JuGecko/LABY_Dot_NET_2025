using System.Windows.Forms;

namespace Zadanie_02
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
            textBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            operationChoice = new ComboBox();
            result_textBox = new TextBox();
            rowna_sie = new Label();
            textBoxBinary = new TextBox();
            labelBinary = new Label();
            textBoxHexadecimal = new TextBox();
            textBoxOctadecimal = new TextBox();
            labelHexadecimal = new Label();
            labelOctadecimal = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(28, 71);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 44);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(266, 71);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 44);
            textBox2.TabIndex = 1;
            // 
            // operationChoice
            // 
            operationChoice.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold);
            operationChoice.FormattingEnabled = true;
            operationChoice.Location = new Point(177, 77);
            operationChoice.Margin = new Padding(3, 4, 3, 4);
            operationChoice.Name = "operationChoice";
            operationChoice.Size = new Size(53, 38);
            operationChoice.TabIndex = 2;
            // 
            // result_textBox
            // 
            result_textBox.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold);
            result_textBox.Location = new Point(445, 71);
            result_textBox.Name = "result_textBox";
            result_textBox.Size = new Size(202, 44);
            result_textBox.TabIndex = 5;
            // 
            // rowna_sie
            // 
            rowna_sie.AutoSize = true;
            rowna_sie.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold);
            rowna_sie.Location = new Point(397, 80);
            rowna_sie.Name = "rowna_sie";
            rowna_sie.Size = new Size(31, 30);
            rowna_sie.TabIndex = 6;
            rowna_sie.Text = "=";
            rowna_sie.Click += rowna_sie_Click;
            // 
            // textBoxBinary
            // 
            textBoxBinary.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxBinary.Location = new Point(445, 145);
            textBoxBinary.Name = "textBoxBinary";
            textBoxBinary.Size = new Size(202, 44);
            textBoxBinary.TabIndex = 7;
            textBoxBinary.TextChanged += textBoxBinary_TextChanged;
            // 
            // labelBinary
            // 
            labelBinary.AutoSize = true;
            labelBinary.Location = new Point(362, 169);
            labelBinary.Name = "labelBinary";
            labelBinary.Size = new Size(66, 20);
            labelBinary.TabIndex = 8;
            labelBinary.Text = "binarnie:";
            labelBinary.Click += labelBinary_Click;
            // 
            // textBoxHexadecimal
            // 
            textBoxHexadecimal.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxHexadecimal.Location = new Point(445, 211);
            textBoxHexadecimal.Name = "textBoxHexadecimal";
            textBoxHexadecimal.Size = new Size(202, 44);
            textBoxHexadecimal.TabIndex = 9;
            textBoxHexadecimal.TextChanged += textBoxHexadecimal_TextChanged;
            // 
            // textBoxOctadecimal
            // 
            textBoxOctadecimal.Font = new Font("Yu Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxOctadecimal.Location = new Point(445, 280);
            textBoxOctadecimal.Name = "textBoxOctadecimal";
            textBoxOctadecimal.Size = new Size(202, 44);
            textBoxOctadecimal.TabIndex = 10;
            textBoxOctadecimal.TextChanged += textBoxOctadecimal_TextChanged;
            // 
            // labelHexadecimal
            // 
            labelHexadecimal.AutoSize = true;
            labelHexadecimal.Location = new Point(303, 235);
            labelHexadecimal.Name = "labelHexadecimal";
            labelHexadecimal.Size = new Size(125, 20);
            labelHexadecimal.TabIndex = 11;
            labelHexadecimal.Text = "heksadecymalnie:";
            labelHexadecimal.Click += labelHexadecimal_Click;
            // 
            // labelOctadecimal
            // 
            labelOctadecimal.AutoSize = true;
            labelOctadecimal.Location = new Point(328, 304);
            labelOctadecimal.Name = "labelOctadecimal";
            labelOctadecimal.Size = new Size(100, 20);
            labelOctadecimal.TabIndex = 12;
            labelOctadecimal.Text = "oktogonalnie:";
            labelOctadecimal.Click += labelOctadecimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 354);
            Controls.Add(labelOctadecimal);
            Controls.Add(labelHexadecimal);
            Controls.Add(textBoxOctadecimal);
            Controls.Add(textBoxHexadecimal);
            Controls.Add(labelBinary);
            Controls.Add(textBoxBinary);
            Controls.Add(rowna_sie);
            Controls.Add(result_textBox);
            Controls.Add(operationChoice);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox result_textBox;
        private Label rowna_sie;
        private TextBox textBoxBinary;
        private Label labelBinary;
        private TextBox textBoxHexadecimal;
        private TextBox textBoxOctadecimal;
        private Label labelHexadecimal;
        private Label labelOctadecimal;
    }
}
