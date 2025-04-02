namespace Zadanie_07
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "JPG", "image/jpeg", "Built-in JPEG Codec", "Encoder, Decoder" }, -1, Color.Empty, SystemColors.MenuBar, new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "BMP", "image/bmp", "Built-in BMP Codec", "Encoder, Decoder" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "TIFF", "image/tiff", "Built-in TIFF Codec", "Encoder, Decoder" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "GIF", "image/gif", "Built-in GIF Codec", "Encoder, Decoder" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "PNG", "image/png", "Built-in PNG Codec", "Encoder, Decoder" }, -1);
            listView1 = new ListView();
            formatColumn = new ColumnHeader();
            mimeTypeColumn = new ColumnHeader();
            descriptionColumn = new ColumnHeader();
            flagsColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { formatColumn, mimeTypeColumn, descriptionColumn, flagsColumn });
            listView1.ForeColor = SystemColors.WindowFrame;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(592, 275);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // formatColumn
            // 
            formatColumn.Text = "Format";
            formatColumn.Width = 150;
            // 
            // mimeTypeColumn
            // 
            mimeTypeColumn.Text = "MIME";
            mimeTypeColumn.Width = 100;
            // 
            // descriptionColumn
            // 
            descriptionColumn.Text = "Opis";
            descriptionColumn.Width = 180;
            // 
            // flagsColumn
            // 
            flagsColumn.Text = "Flagi";
            flagsColumn.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 297);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader formatColumn;
        private ColumnHeader mimeTypeColumn;
        private ColumnHeader descriptionColumn;
        private ColumnHeader flagsColumn;

    }
}
