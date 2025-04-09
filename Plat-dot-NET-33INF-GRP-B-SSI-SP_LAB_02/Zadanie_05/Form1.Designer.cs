namespace Zadanie_05
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonClear = new Button();
            labelSelectedItem = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(321, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 128);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(45, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 38);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            buttonAdd.Location = new Point(45, 122);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            buttonRemove.Location = new Point(45, 190);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(112, 44);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            buttonClear.Location = new Point(45, 253);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 45);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelSelectedItem
            // 
            labelSelectedItem.AutoSize = true;
            labelSelectedItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSelectedItem.Location = new Point(321, 200);
            labelSelectedItem.Name = "labelSelectedItem";
            labelSelectedItem.Size = new Size(130, 28);
            labelSelectedItem.TabIndex = 5;
            labelSelectedItem.Text = "Selected Item";
            labelSelectedItem.Click += labelSelectedItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(496, 339);
            Controls.Add(labelSelectedItem);
            Controls.Add(buttonClear);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonClear;
        private Label labelSelectedItem;
    }
}
