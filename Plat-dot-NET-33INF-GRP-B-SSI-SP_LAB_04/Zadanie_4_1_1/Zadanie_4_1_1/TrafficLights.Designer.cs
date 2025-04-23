namespace Zadanie_4_1_1
{
    partial class TrafficLights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customControl11 = new CustomControl1();
            SuspendLayout();
            // 
            // customControl11
            // 
            customControl11.Name = "customControl11";
            customControl11.Size = new Size(0, 0);
            customControl11.TabIndex = 0;
            customControl11.Text = "customControl11";
            customControl11.Click += customControl11_Click;
            ResumeLayout(false);
        }

        #endregion

        private CustomControl1 customControl11;
    }
}
