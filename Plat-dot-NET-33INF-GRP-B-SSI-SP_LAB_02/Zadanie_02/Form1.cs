//opracowaæ program, który wykonuje cztery podstawowe operacje arytmetyczne, wartoœci
//argumentów maj¹ byæ wprowadzane za pomoc¹ pól tekstowych.

namespace Zadanie_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            operationChoice.Items.AddRange(new string[] { "+", "-", "*", "/" });
            operationChoice.SelectedIndex = 0;
            textBox1.TextChanged += InputChange;
            textBox2.TextChanged += InputChange;
            operationChoice.SelectedIndexChanged += InputChange;
        }
        private void InputChanged(object sender, EventArgs e)
        {
            PerformOperation(operationChoice.SelectedItem.ToString());
        }

        private void InputChange(object? sender, EventArgs e)
        {
            PerformOperation(operationChoice.SelectedItem.ToString());
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void operationChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void PerformOperation(string operation)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = 0;
                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Nie dziel przez zero!");
                            return;
                        }
                        break;
                }
                result_textBox.Text = "" + result;
                textBoxBinary.Text = ConvertToBinary((int)result);
                textBoxHexadecimal.Text = ConvertToHex((int)result);
                textBoxOctadecimal.Text = ConvertToOct((int)result);
            }
            else
            {
                result_textBox.Text = ""; // Clear result if input is invalid
                textBoxBinary.Text = ""; // Clear binary result
                textBoxHexadecimal.Text = "";
                textBoxOctadecimal.Text = "";
            }

        }
        private string ConvertToBinary(int number)
        {
            return Convert.ToString(number, 2); // Convert to binary string
        }

        private string ConvertToHex(int number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }

        private string ConvertToOct(int number)
        {
            return Convert.ToString(number, 8);
        }



        private TextBox textBox1;
        private TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox operationChoice;


        //rowna sie (wynik)
        private void rowna_sie_Click(object sender, EventArgs e)
        {

        }
        private void result_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        //zamiana binarna
        private void labelBinary_Click(object sender, EventArgs e){
        
        }
        private void textBoxBinary_TextChanged(object sender, EventArgs e)
        {

        }
        
        //zamiana heksadecymalna
        private void labelHexadecimal_Click(object sender, EventArgs e)
        {

        }
        private void textBoxHexadecimal_TextChanged(object sender, EventArgs e)
        {

        }

        // zamiana oktodecymalna
        private void labelOctadecimal_Click(object sender, EventArgs e)
        {

        }
        private void textBoxOctadecimal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
