namespace Zadanie_4_1_1
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
            trafficLights1 = new TrafficLights();
            SuspendLayout();
            // 
            // trafficLights1
            // 
            trafficLights1.CircleColor1 = Color.IndianRed;
            trafficLights1.CircleColor2 = Color.Yellow;
            trafficLights1.CircleColor3 = Color.ForestGreen;
            trafficLights1.Location = new Point(93, 48);
            trafficLights1.Name = "trafficLights1";
            trafficLights1.Radius = 94;
            trafficLights1.Size = new Size(94, 282);
            trafficLights1.State = 0;
            trafficLights1.TabIndex = 0;
            trafficLights1.Text = "trafficLights1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 388);
            Controls.Add(trafficLights1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TrafficLights trafficLights1;
    }
}
