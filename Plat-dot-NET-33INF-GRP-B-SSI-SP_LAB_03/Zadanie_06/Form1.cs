//opracowaæ aplikacjê do wysy³ania listu e-mail (równie¿ z za³¹cznikami)
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Zadanie_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkEmail(textBox1.Text))
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }
        private bool checkEmail(string email)
        {
            try
            {
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch
            {
                return false;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Podaj temat wiadomosci.");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new MailMessage object
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(textBoxAuthor.Text);
                mail.To.Add(textBox1.Text);
                mail.Subject = textBox2.Text;
                mail.Body = richTextBox1.Text;

                // Add attachment if a file is selected
                if (!string.IsNullOrEmpty(textBoxAttachment.Text))
                {
                    Attachment attachment = new Attachment(textBoxAttachment.Text);
                    mail.Attachments.Add(attachment);
                }
                // Configure SMTP client
                SmtpClient smtp = new SmtpClient(textBoxSMPT.Text, int.Parse(textBoxPort.Text));
                smtp.Credentials = new NetworkCredential(textBoxAuthor.Text, textBoxPassword.Text);

                // Send the email
                smtp.Send(mail);
                MessageBox.Show("E-mail zostal wyslany", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³ad podczas wysy³ania e-maila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            // Open file dialog to select an attachment
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAttachment.Text = openFileDialog.FileName;
            }
        }

        private void textBoxSMPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAttachment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            if (checkEmail(textBoxAuthor.Text))
            {
                textBoxAuthor.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxAuthor.BackColor = Color.Red;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
