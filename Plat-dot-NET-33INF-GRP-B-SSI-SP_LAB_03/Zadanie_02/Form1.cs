//podaæ program dla konsoli do weryfikacji adresu IP w formacie:
//XXX.XXX.XXX.XXX,
//gdzie X to cyfra oraz e-mail za pomoc¹ wyra¿enia regularnego.
using System.Text.RegularExpressions;

namespace Zadanie_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidOctet14(int value)
        {
            return value >= 1 && value <= 254;
        }
        private bool IsValidOctet23(int value)
        {
            return value >= 0 && value <= 255;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int octet1 = int.Parse(textBox1.Text);
                int octet2 = int.Parse(textBox2.Text);
                int octet3 = int.Parse(textBox3.Text);
                int octet4 = int.Parse(textBox4.Text);

                if (IsValidOctet14(octet1) && IsValidOctet14(octet4) && IsValidOctet23(octet2) && IsValidOctet23(octet3))
                {
                    MessageBox.Show("Adres IP jest poprawny.", "Weryfikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adres IP jest niepoprawny. Oktety 1 i 4 musza byc w zakresie 001-254, a oktety 2 i 3 w zakresie 000-255.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj poprawny adres IP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //email
        private void textBoxE_TextChanged(object sender, EventArgs e)
        {
            if (checkEmail(textBoxE.Text))
            {
                textBoxE.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxE.BackColor = Color.Red;
            }
        }

        private bool checkEmail(string email)
        {
            try
            {
                // Wyra¿enie regularne do walidacji adresu e-mail
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkEmail(textBoxE.Text))
            {
                MessageBox.Show("Adres e-mail jest poprawny.", "Weryfikacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adres e-mail jest niepoprawny. Poprawny format to: example@domain.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
