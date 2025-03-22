using System.Windows.Forms;

namespace Zadanie_01
{
    public partial class Form1 : Form
    {

        private bool alarm = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            if (alarm)
            {
                DateTime currentTime = DateTime.Now;
                DateTime setAlarmTime = dateTimePicker1.Value;

                if (currentTime.Hour == setAlarmTime.Hour && currentTime.Minute == setAlarmTime.Minute && currentTime.Second == setAlarmTime.Second)
                {
                    notifyIcon1.BalloonTipTitle = "Alarm";
                    notifyIcon1.BalloonTipText = "Zaraz wybuchnie aaa!";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.ShowBalloonTip(3000);
                    BackColor = Color.Red;
                    alarm = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            alarm = true;
            BackColor = Color.Beige;
            timer1.Start();
        }
    }

        
    
}
