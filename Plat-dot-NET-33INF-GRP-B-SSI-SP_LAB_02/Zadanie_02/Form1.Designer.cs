//opracować program, który wykonuje cztery podstawowe operacje arytmetyczne, wartości
//argumentów mają być wprowadzane za pomocą pól tekstowych.
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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // operationChoice
            // 
            operationChoice.FormattingEnabled = true;
            operationChoice.Location = new Point(159, 87);
            operationChoice.Name = "operationChoice";
            operationChoice.Size = new Size(47, 23);
            operationChoice.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 207);
            Controls.Add(operationChoice);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox operationChoice;

        // Put some text into the control first.  
        //TextBox.Text = "This is a TextBox control.";

        private void InitializeComboBox()
        {
            operationChoice.Items.AddRange(new string[] { "+", "-", "*", "/" });
            operationChoice.SelectedIndex = 0; // Domyślnie wybieramy dodawanie
        }

        private void Calculate()
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                string operation = operationChoice.SelectedItem.ToString();
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num2 != 0 ? num1 / num2 : double.NaN;
                        break;
                }

                MessageBox.Show($"Wynik: {result}", "Wynik obliczeń", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Podaj poprawne liczby!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
